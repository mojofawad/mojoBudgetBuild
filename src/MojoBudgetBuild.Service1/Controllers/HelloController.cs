using Microsoft.AspNetCore.Mvc;

namespace MojoBudgetBuild.Service1.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Hello World from Service 1!");

    [HttpGet("health")]
    public IActionResult HealthCheck() => Ok("Healthy - Service 1");
}