using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TimeController : ControllerBase
{
    private readonly ITimeService _timeService;
    public TimeController(ITimeService timeService) { _timeService = timeService; }

    [HttpGet]
    public IActionResult GetGreeting() => Ok(_timeService.GetGreeting());
}