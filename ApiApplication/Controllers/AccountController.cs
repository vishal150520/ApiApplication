using ApiApplication.Models;
using ApiApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {

        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("companyregistration")]
        [Route("candidateregistration")]
        public async Task<IActionResult> CompanyRegistration([FromBody] Users user)
        {
            try
            {
                // Create User
                var createdUser = await _userService.Registration(user);
               
                return Ok(new ApiResponse<Users>((int)StatusCodes.Status200OK, true, "User created"));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<Users>((int)StatusCodes.Status400BadRequest, false, ex.Message));
            }
        }
    }
}
