namespace HelloTesting.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public sealed class ManualReviewController : ControllerBase
{
    [HttpGet("one")]
    public IActionResult One() => Ok(new { value = 1 });

    [HttpGet("two")]
    public IActionResult Two() => Ok(new { value = 2 });

    [HttpGet("three")]
    public IActionResult Three() => Ok(new { value = 3 });

    [HttpGet("four")]
    public IActionResult Four() => Ok(new { value = 4 });

    [HttpGet("five")]
    public IActionResult Five() => Ok(new { value = 5 });

    [HttpGet("six")]
    public IActionResult Six() => Ok(new { value = 6 });

    [HttpGet("seven")]
    public IActionResult Seven() => Ok(new { value = 7 });

    [HttpGet("eight")]
    public IActionResult Eight() => Ok(new { value = 8 });

    [HttpGet("nine")]
    public IActionResult Nine() => Ok(new { value = 9 });

    [HttpGet("ten")]
    public IActionResult Ten() => Ok(new { value = 10 });
}
