namespace weather_station2.models
{
    public class WeatherStationViewModel
    {
        public string Location {get; set;}
        public double GroundTemperatureAverage {get; set;}
        public double GroundTemperatureMinimum {get; set;}
        public double GroundTemperatureMaximum {get; set;}
        public double AirTemperatureAverage {get; set;}
        public double AirTemperatureMinimum {get; set;}
        public double AirTemperatureMaximum {get; set;}

        public double WindSpeedAverage {get; set;}
        public double WindSpeedMinimum {get; set;}
        public double WindSpeedMaximum {get; set;}
        public double TotalRainfall {get; set;}
        public string WindDirection {get; set;}
    }
}