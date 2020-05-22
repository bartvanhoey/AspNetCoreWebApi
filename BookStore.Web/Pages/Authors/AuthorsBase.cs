using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Web.Services.BookStore;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Blazored.LocalStorage;
using BookStore.Web.Services.Users;

namespace BookStore.Web.Pages
{
    public class AuthorsBase : ComponentBase
    {
        [Inject]
        public IBookStoreService<Author> BookStoreService { get; set; }
        [Inject]
        public IUserService UserService { get; set; }
        [Inject]
        public ILocalStorageService LocalStorageService { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
        public bool IsVisible { get; set; } = false;
        public Author Author { get; set; } = new Author();
        protected ElementReference firstNameRef;
        public string[] Cities { get; set; }
        public string RecordName { get; set; }
        public bool Result { get; set; } = true;
        private string _selectedCity;

        private async Task LoadAuthors()
        {

            var authors = (await BookStoreService.GetAllAsync("authors"));
            authors = null;
            if (authors == null)
            {

                var accessToken = await LocalStorageService.GetItemAsync<string>("accessToken");
                var refreshToken = await LocalStorageService.GetItemAsync<string>("refreshToken");

                var refreshRequest = new RefreshRequest
                {
                    AccessToken = accessToken,
                    RefreshToken = refreshToken
                };

                var user = (await UserService.RefreshTokenAsync(refreshRequest)) as UserWithToken;
                await LocalStorageService.SetItemAsync("accessToken", user.AccessToken);
                // LocalStorageService.SetItemAsync("refreshtoken", user.RefreshToken);

                authors = (await BookStoreService.GetAllAsync("authors"));
            }

            Authors = authors != null ? authors.OrderByDescending(a => a.AuthorId).ToList() : new List<Author>();

            StateHasChanged();
        }
        protected void OnSelectCityChange(ChangeEventArgs changeEventArgs)
        {
            _selectedCity = (string)changeEventArgs.Value;
        }
        public async Task SaveAuthorAsync()
        {
            Author.City = _selectedCity;
            Author savedAuthor;
            if (Author.AuthorId > 0)
                savedAuthor = await BookStoreService.UpdateAsync("authors", Author.AuthorId, Author);
            else
                savedAuthor = await BookStoreService.SaveAsync("authors", Author);
            Result = savedAuthor != null ? true : false;
            IsVisible = true;
            RecordName = Author.FirstName + " " + Author.LastName;
            await LoadAuthors();
            Author = new Author();
            await JSRuntime.InvokeVoidAsync("setFocus", firstNameRef);
        }

        public async Task DeleteAuthor(int id)
        {
            await BookStoreService.DeleteAsync("authors", id);
            await LoadAuthors();
        }

        public void EditAuthor(Author author)
        {
            Author = author;
            IsVisible = false;
        }

        // protected override async Task OnInitializedAsync()
        // {

        // }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await LoadAuthors();
        }
    }
}