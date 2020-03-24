using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using user_netcore.Dtos;
using user_netcore.Services;

namespace user_netcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<ActionResult<List<GetUserDto>>> Get()
        {

            return Ok(await userService.get());

        }

        [HttpGet("noDb")]
        public async Task<ActionResult<GetUserDto>> GetOneAsync()
        {

            return Ok(await userService.getNoDb());

        }
    }
}