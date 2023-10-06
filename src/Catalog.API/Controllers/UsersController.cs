using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {

            var result = new[]
            {
                new {Name = "Muhammad Abdulloh", Familya = "Komilov"},
                new {Name = "Jamoldin", Familya = "Meyliyev"},
            };

            return Ok(result);
        }
    }
}
