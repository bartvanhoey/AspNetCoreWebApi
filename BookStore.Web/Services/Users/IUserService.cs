using System.Threading.Tasks;
using BookStore.Models;

namespace BookStore.Web.Services.Users
{
    public interface IUserService
    {
        Task<User> LoginAsync(User user);
        Task<User> RegisterUserAsync(User user);
        Task<User> RefreshAccessTokenAsync(RefreshRequest refreshRequest);
        Task<User> GetUserByAccessTokenAsync(string accessToken);
    }
}