using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controller
{
    [ApiController, Route("/api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("hello world");
        }

    }
}