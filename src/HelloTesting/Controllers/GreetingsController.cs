using Microsoft.AspNetCore.Mvc;

namespace HelloTesting.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class GreetingsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        int mantap = 567;

        return Ok(new
        {
            message = "Hello from GreetingsController",
            version = "v2"
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
