namespace weather_station2.models
{
    public class RainGauge : Sensor
    {
        private double medianRainfall;
        public double rainfall { get; set; }

        public RainGauge(double medianRainfall)
        {
            this.medianRainfall = medianRainfall;
            this.rainfall = GetRainfall();
        }

        public double GetRainfall()
        {
            return GetSensorValue(medianRainfall, 3, false);
        }
    }
}