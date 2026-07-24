using Microsoft.AspNetCore.Mvc;

namespace Lab1_HelloWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello ASP.NET Core 8 Web API");
        }

        [HttpGet("welcome")]
        public IActionResult Welcome()
        {
            return Ok("Welcome to Cognizant Deep Skilling");
        }
    }
}