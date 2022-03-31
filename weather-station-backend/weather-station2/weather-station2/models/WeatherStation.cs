namespace weather_station2.models
{
    public class WeatherStation
    {
        public Thermometer thermometer { get; set; }

        public Barometer barometer { get; set; }

        public RainGauge rainGauge { get; set; }

        public Anemometer anemometer { get; set; }

        public Guid stationId => Guid.NewGuid();
    }
}