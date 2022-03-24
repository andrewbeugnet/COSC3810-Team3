using Microsoft.AspNetCore.Mvc;
using weather_station2.models;

namespace weather_station2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherStationController : ControllerBase
    {
    
        private readonly ILogger<WeatherStationController> _logger;

        public WeatherStationController(ILogger<WeatherStationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherStation> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherStation(50.0, 50.0, 50.0, 50.0))
            .ToArray();
        }
    }
}