using Microsoft.AspNetCore.Mvc;

namespace MojoBudgetBuild.Service2.Controllers;

[ApiController]
[Route("[controller]")]
public class HowdyController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Howdy Earthlings from Service 2!");

    [HttpGet("health")]
    public IActionResult HealthCheck() => Ok("Healthy - Service 2");
}