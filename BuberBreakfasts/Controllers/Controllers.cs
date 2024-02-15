namespace BuberBreakfast.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
public class BreakfastsController : ControllerBase
{
    [HttpPost("/breakfast")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        return Ok(request);
    }
}
