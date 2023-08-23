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
        public dynamic Login(String user, String pass)
        {

            List<User> users = new List<User>
            {
                new User{Id = 1,
                Username ="admin ",
                Password ="F1tprotr@cker!"
                },
                new User{Id = 2,
                Username ="asj",
                Password ="123asp"
                },
                new User{Id = 3,
                Username ="Ash",
                Password ="123"
                },
            };

            foreach (var us in users)

            {
                if (us.Username == user && us.Password == pass)
                {
                    return new
                    {
                        success = true,
                        message = "success",
                        result = us
                    };
                }
            }
            return new
            {
                success = false,
                message = "error",
                result = ""
            };
        }


    }
}
