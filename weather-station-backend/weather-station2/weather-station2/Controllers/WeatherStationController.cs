using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
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

        [EnableCors]
        [HttpGet]
        public IEnumerable<WeatherStationViewModel> Get()
        {
            var weatherStations = new List<WeatherStation>()
            {
                new WeatherStation(20, 40, 0.5, 5, "Phoenix"),
                new WeatherStation(90, 105, 0, 5, "Milwaukee"),
                new WeatherStation(45, 62, 1.5, 5, "Seattle")
            };

            var viewModels = new List<WeatherStationViewModel>();

            foreach (WeatherStation station in weatherStations) {
                var weatherDataList = new List<WeatherData>();
                for (int i = 0; i < 10; i++) {
                    weatherDataList.Add(station.GetWeatherData());
                }
                viewModels.Add(new WeatherStationViewModel() {
                    GroundTemperatureAverage = Math.Round(weatherDataList.Select(x => x.GroundTemperature).Average(),2),
                    GroundTemperatureMinimum = Math.Round(weatherDataList.Select(x => x.GroundTemperature).Min(),2),
                    GroundTemperatureMaximum = Math.Round(weatherDataList.Select(x => x.GroundTemperature).Max(),2),
                    AirTemperatureAverage = Math.Round(weatherDataList.Select(x => x.AirTemperature).Average(),2),
                    AirTemperatureMinimum = Math.Round(weatherDataList.Select(x => x.AirTemperature).Min(),2),
                    AirTemperatureMaximum = Math.Round(weatherDataList.Select(x => x.AirTemperature).Max(),2),
                    WindSpeedAverage = Math.Round(weatherDataList.Select(x => x.WindSpeed).Average(),2),
                    WindSpeedMinimum = Math.Round(weatherDataList.Select(x => x.WindSpeed).Min(),2),
                    WindSpeedMaximum = Math.Round(weatherDataList.Select(x => x.WindSpeed).Max(),2),
                    TotalRainfall = Math.Round(weatherDataList.Select(x => x.Rainfall).Sum(),2),
                    WindDirection = weatherDataList[9].WindDirection,
                    Location = weatherDataList[9].Location
                });
            }

            return viewModels;
        }
    }
}