namespace weather_station2.models
{
    public class WeatherStation
    {
        private Thermometer thermometer;
        private Barometer barometer;
        private RainGauge rainGauge;
        private Anemometer anemometer;
        private Guid stationId;

        public WeatherStation(double medianTemperature, double medianPressure,  double medianRainfall, double medianWindSpeed)
        {
            thermometer = new Thermometer(medianTemperature);
            barometer = new Barometer(medianPressure);
            rainGauge = new RainGauge(medianRainfall);
            anemometer = new Anemometer(medianWindSpeed);

            stationId = Guid.NewGuid();
        }

        public WeatherData GetWeatherData()
        {
            return new WeatherData() { 
                Temperature = thermometer.GetTemperature(),
                Pressure = barometer.GetPressure(),
                Rainfall = rainGauge.GetRainfall(),
                Windspeed = anemometer.GetWindSpeed(),
                WindDirection = anemometer.GetWindDirection(),
                Timestamp = DateTime.Now};
        }
    }
}