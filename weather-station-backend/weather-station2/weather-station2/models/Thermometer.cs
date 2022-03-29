namespace weather_station2.models
{
    public class Thermometer : Sensor
    {
        private double medianTemperature;
        public double temperature { get; set; }

        public Thermometer(double medianTemperature)
        {
            this.medianTemperature = medianTemperature;
            this.temperature = GetTemperature();
        }

        public double GetTemperature()
        {
            return GetSensorValue(medianTemperature, 20, true);
        }
    }
}