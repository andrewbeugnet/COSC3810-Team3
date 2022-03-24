namespace weather_station2.models
{
    public class WeatherData
    {
        public double Temperature { get; set; }
        public double Pressure { get; set; }
        public double Rainfall { get; set; }
        public double Windspeed { get; set; }
        public string WindDirection { get; set; }
        public DateTime Timestamp { get; set; }
    }
}