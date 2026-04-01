using Microsoft.AspNetCore.Mvc;

namespace HelloTesting.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class GreetingsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            message = "Hello from GreetingsController"
        });
    }

    [HttpGet("{name}")]
    public IActionResult GetByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return BadRequest(new { message = "Name is required." });
        }

        return Ok(new
        {
            message = $"Hello, {name.Trim()}!"
        });
    }
}
