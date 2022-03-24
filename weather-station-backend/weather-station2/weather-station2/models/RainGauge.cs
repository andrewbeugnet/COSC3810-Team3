namespace weather_station2.models
{
    public class RainGauge : Sensor
    {
        private double medianRainfall;

        public RainGauge(double medianRainfall)
        {
            this.medianRainfall = medianRainfall;
        }

        public double GetRainfall()
        {
            return GetSensorValue(medianRainfall, 3, false);
        }
    }
}