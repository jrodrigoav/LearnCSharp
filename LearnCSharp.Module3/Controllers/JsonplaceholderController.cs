using Microsoft.AspNetCore.Mvc;

namespace LearnCSharp.Module3.Controllers
{
    [Route("api/jsonplaceholder"), ApiController]
    public class JsonplaceholderController : ControllerBase
    {
        [HttpGet("posts")]
        public async Task<IActionResult> GetPosts([FromServices] IJsonplaceholderService service)
        {
            return Ok(await service.GetPostsAsync());
        }
    }
}
