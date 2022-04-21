namespace weather_station2.models
{
    public class WeatherStation
    {
        private Thermometer airThermometer;
        private Thermometer groundThermometer;
        private RainGauge rainGauge;
        private Anemometer anemometer;
        private Guid stationId;

        public WeatherStation(double medianGroundTemperature, double medianAirTemperature,  double medianRainfall)
        {
            airThermometer = new Thermometer(medianAirTemperature);
            groundThermometer = new Thermometer(medianGroundTemperature);
            rainGauge = new RainGauge(medianRainfall);
            anemometer = new Anemometer();

            stationId = Guid.NewGuid();
        }

        public WeatherData GetWeatherData()
        {
            return new WeatherData() { 
                GroundTemperature = groundThermometer.GetTemperature(),
                AirTemperature = airThermometer.GetTemperature(),
                Rainfall = rainGauge.GetRainfall(),
                WindDirection = anemometer.GetWindDirection()};
        }
    }
}