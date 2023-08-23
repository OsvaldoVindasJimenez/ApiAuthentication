using Microsoft.AspNetCore.Mvc;

using WebApiAuthentication.Models;

namespace WebApiAuthentication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserAuthentication : ControllerBase
    {


        private readonly UserService userService;


        [HttpPost("login")]
        public IActionResult Login(String user, String pass)
        {
    
            if (userService.Authenticate(user, pass) == null)
            {
                return Unauthorized();
            }

            return Ok(new { message = "Login successful" });
        }










    }
}
