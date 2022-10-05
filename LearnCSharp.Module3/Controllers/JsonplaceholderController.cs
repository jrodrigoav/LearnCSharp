using Microsoft.AspNetCore.Mvc;

namespace LearnCSharp.Module3.Controllers
{
    [Route("api/jsonplaceholder"), ApiController]
    public class JsonplaceholderController : ControllerBase
    {
        private readonly IJsonplaceholderService _jsonplaceholderService;
        public JsonplaceholderController(IJsonplaceholderService jsonplaceholderService)
        {

            _jsonplaceholderService = jsonplaceholderService;
        }
        [HttpGet("posts")]
        public async Task<IActionResult> GetPosts()
        {
            return Ok(await _jsonplaceholderService.GetPostsAsync());
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _jsonplaceholderService.GetUsersAsync());
        }
        [HttpGet("todos")]
        public async Task<IActionResult> GetTodos()
        {
            return Ok(await _jsonplaceholderService.GetTodosAsync());
        }

        [HttpGet("comments")]
        public async Task<IActionResult> GetComments()
        {
            return Ok(await _jsonplaceholderService.GetCommentsAsync());
        }
        [HttpGet("albums")]
        public async Task<IActionResult> GetAlbums()
        {
            return Ok(await _jsonplaceholderService.GetAlbumsAsync());
        }

        [HttpGet("photos")]
        public async Task<IActionResult> GetPhotos([FromServices] IJsonplaceholderService service)
        {
            return Ok(await service.GetPhotosAsync());
        }
    }
}
