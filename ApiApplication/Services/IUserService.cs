using ApiApplication.Models;

namespace ApiApplication.Services
{
    public interface IUserService
    {
        Task<Users> Registration(Users users);
    }
}
