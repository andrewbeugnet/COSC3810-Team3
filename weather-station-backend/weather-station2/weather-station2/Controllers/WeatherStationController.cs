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
            List<WeatherStation> stationList = new List<WeatherStation>();
            WeatherStation station1 = new WeatherStation();
            station1.anemometer = new Anemometer(50);
            station1.barometer = new Barometer(50);
            station1.rainGauge = new RainGauge(50);
            station1.thermometer = new Thermometer(50);
            stationList.Add(station1);
            return stationList;
        }
    }
}