using Microsoft.AspNetCore.Mvc;

namespace MojoBudgetBuild.Service3.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Greetings Citizens from Service 3!");

    [HttpGet("health")]
    public IActionResult HealthCheck() => Ok("Healthy - Service 3");
}