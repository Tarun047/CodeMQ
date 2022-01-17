using Microsoft.AspNetCore.Mvc;

namespace CodeChamp.Controllers;

[ApiController]
[Route("/health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public string CheckHealth()
    {
        return "Healthy";
    }
}