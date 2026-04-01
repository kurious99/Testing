namespace HelloTesting.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public sealed class BrokenController : ControllerBase
{
    [HttpGet]
    public int Get()
    {
        return 123;
    }
}
