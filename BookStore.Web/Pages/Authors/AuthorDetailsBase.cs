using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Web.Services.BookStore;
using Microsoft.AspNetCore.Components;

namespace BookStore.Web.Pages
{
    public class AuthorDetailsBase : ComponentBase
    {
        [Inject]
        public IBookStoreService<Author> BookStoreService { get; set; }

        [Parameter]
        public string Id { get; set; }
        public Author Author { get; set; } = new Author();

        protected override async Task OnInitializedAsync()
        {
            Author = await BookStoreService.GetByIdAsync("authors", int.Parse(Id));
        }
    }
}