using ApiApplication.Models;
using ApiApplication.Services;
using Microsoft.EntityFrameworkCore;

namespace ApiApplication.Services
{
    public class UserService:IUserService
    {
         private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Users> Registration(Users users)
        {

            if (users != null && _context != null)
            {
                try
                {
                    Users user = new Users()
                    {
                        FirstName = users.FirstName,
                        Lastname = users.Lastname,
                        Email = users.Email,
                        Password = users.Password,
                        IsVerified = false,
                        Phone = users.Phone,
                        ModifiedDate = DateTime.UtcNow,
                        CreatedDate = DateTime.UtcNow,
                        CreatedBy = "System",
                        ModifiedBy = "System",
                    };
                    // Create User

                    var createdUser = await CreateUser(user);
                    if (createdUser != null)
                    {
                        //  Create Roles
                        foreach (var item in users.roles)
                        {
                            var roleId = item.RoleID;
                            if (roleId > 0)
                            {
                                UserRoles userRole = new UserRoles()
                                {
                                    RoleID = roleId,
                                    UserID = createdUser.UserID
                                };
                                await CreateUserRole(userRole);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                
                    throw ex;
                }

            }
            return null;
        }
        
        public async Task<UserRoles> CreateUserRole(UserRoles userRole)
        {
            if (_context != null && userRole != null)
            {
                try
                {
                    
                    await _context.AddRangeAsync(userRole);
                    await _context.SaveChangesAsync();
                    return userRole;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return null;
        }
        public async Task<Users> CreateUser(Users userModel)
        {
            if (_context != null && userModel != null)
            {
     
                try
                {
                    await _context.Users.AddAsync(userModel);
                    await _context.SaveChangesAsync();
                    return userModel;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return null;
        }
    }
}
