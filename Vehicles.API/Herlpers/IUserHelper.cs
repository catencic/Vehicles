using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Vehicles.API.Data;
using Vehicles.API.Models;

namespace Vehicles.API.Herlpers
{
    public interface IUserHelper
    {

        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();
    }
}
