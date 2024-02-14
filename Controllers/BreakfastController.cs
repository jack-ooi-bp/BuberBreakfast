namespace BuberBreakfast.Controllers;

public class BreakfastsControllers : ControllerBase
{
    [HttpPost("/Breakfast")]
    public IActionResult CreateBreakfast(createBreakfastResponse request)
    {
        return Ok();
    }
}
