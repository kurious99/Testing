using Microsoft.AspNetCore.Mvc;

namespace HelloTesting.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class GreetingsController : ControllerBase
{
    [HttpGet("details")]
    public int GetDetails()
    {
        return 123;
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
