using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public List<ToDos> Get()
    {
        List<ToDos> myToDos = new List<ToDos>();
        ToDos toDo = new ToDos(){ID = 1, ToDo = "complete PA3", Completed = false};
        ToDos toDo2 = new ToDos(){ID = 1, ToDo = "complete PA2", Completed = false};
        ToDos toDo3 = new ToDos(){ID = 1, ToDo = "complete PA1", Completed = false};

        myToDos.Add(toDo);
        myToDos.Add(toDo2);
        myToDos.Add(toDo3);
        return myToDos;
    }
}
