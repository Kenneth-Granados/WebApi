using Commons;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    // private readonly ILogger<WeatherForecastController> _logger;
    private ILoggerManager _logger;

    // public WeatherForecastController(ILogger<WeatherForecastController> logger) //generado por la plantilla
    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }

    // [HttpGet(Name = "GetWeatherForecast")]
    // public IEnumerable<WeatherForecast> Get()
    // {
    //      return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateTime.Now.AddDays(index),
    //         TemperatureC = Random.Shared.Next(-20, 55),
            
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }
    // [HttpGet]
    // public IEnumerable<string> Get()
    // {
       
    //     _logger.LogInfo("Here is info message from our values controller. es:Aquí hay un mensaje de información de nuestro controlador de valores"); 
    //     _logger.LogDebug("Here is debug message from our values controller. es:Aquí hay un mensaje de depuración de nuestro controlador de valores"); 
    //     _logger.LogWarn("Here is warn message from our values controller. es: Aquí hay un mensaje de advetencia de nuestro controlador de valores"); 
    //     _logger.LogError("Here is an error message from our values controller. es: Aquí hay un mensaje de error de nuestro controlador de valores");
    //     return new string[] { "value1", "value2" };
    // }
}
