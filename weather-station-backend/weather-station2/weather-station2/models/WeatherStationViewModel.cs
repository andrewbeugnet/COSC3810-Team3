namespace weather_station2.models
{
    public class WeatherStationViewModel
    {
        public double GroundTemperatureAverage {get; set;}
        public double GroundTemperatureMinimum {get; set;}
        public double GroundTemperatureMaximum {get; set;}
        public double AirTemperatureAverage {get; set;}
        public double AirTemperatureMinimum {get; set;}
        public double AirTemperatureMaximum {get; set;}
        public double TotalRainfall {get; set;}
        public string WindDirection {get; set;}
    }
}