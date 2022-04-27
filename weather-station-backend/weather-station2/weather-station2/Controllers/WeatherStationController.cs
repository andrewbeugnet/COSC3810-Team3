using Microsoft.AspNetCore.Mvc;
using weather_station2.models;
using System.Linq;

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
        public IEnumerable<WeatherStationViewModel> Get()
        {
            var weatherStations = new List<WeatherStation>()
            {
                new WeatherStation(20, 40, 0.5),
                new WeatherStation(90, 105, 0),
                new WeatherStation(45, 62, 1.5)
            };

            var viewModels = new List<WeatherStationViewModel>();

            foreach (WeatherStation station in weatherStations) {
                var weatherDataList = new List<WeatherData>();
                for (int i = 0; i < 10; i++) {
                    weatherDataList.Add(station.GetWeatherData());
                }
                viewModels.Add(new WeatherStationViewModel() {
                    GroundTemperatureAverage = weatherDataList.Select(x => x.GroundTemperature).Average(),
                    GroundTemperatureMinimum = weatherDataList.Select(x => x.GroundTemperature).Min(),
                    GroundTemperatureMaximum = weatherDataList.Select(x => x.GroundTemperature).Max(),
                    AirTemperatureAverage = weatherDataList.Select(x => x.AirTemperature).Average(),
                    AirTemperatureMinimum = weatherDataList.Select(x => x.AirTemperature).Min(),
                    AirTemperatureMaximum = weatherDataList.Select(x => x.AirTemperature).Max(),
                    TotalRainfall = weatherDataList.Select(x => x.Rainfall).Sum(),
                    WindDirection = weatherDataList[9].WindDirection
                });
            }

            return viewModels;
        }
    }
}