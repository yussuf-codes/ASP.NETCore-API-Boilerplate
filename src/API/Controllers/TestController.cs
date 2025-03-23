using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
	[HttpGet]
	public IActionResult Get()
	{
		return Ok("Hello, ASP.NET Core!");
	}
}
