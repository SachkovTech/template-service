using Microsoft.AspNetCore.Mvc;

namespace ProjectTemplate.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpPost]
    public IActionResult Post()
    {
        return Ok();
    }
}