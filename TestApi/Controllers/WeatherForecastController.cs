using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ChangeIsHereController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ChangeIsHereController> _logger;

    public ChangeIsHereController(ILogger<ChangeIsHereController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetHaha")]
    public IEnumerable<Haha> Get()
    {
        return Enumerable.Range(1, 3).Select(index => new Haha
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            Greeting = "Hahahah"
        })
        .ToArray();
    }
}
