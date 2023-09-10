using Microsoft.AspNetCore.Mvc;

namespace Api.Crud.net7.Controllers
{
    [Route("")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult HealthCheck()
        {
            return Ok("API is up and running");
        }
    }
}