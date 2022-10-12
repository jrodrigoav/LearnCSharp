using Microsoft.AspNetCore.Mvc;

namespace LearnCSharp.Module3.Controllers
{
    [Route("api/users"), ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;

        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _service.GetAllAsync());
        }       
    }
}
