using Microsoft.AspNetCore.Mvc;
using User.Domain.Services;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService UserService;
        public UserController(IUserService userService)
        {
            UserService = userService;
        }
        public ActionResult Get(string username)
        {
            var dto = UserService.GetUserByUsername(username);
            return Ok(dto);
        }
    }
}
