using ApiApplication.Models;

namespace ApiApplication.Services
{
    public interface IUserService
    {
        Task<Users> Registration(Users users);
        Task<Users> CreateUser(Users users);
        Task<UserRoles> CreateUserRole(UserRoles userRole);

    }
}
