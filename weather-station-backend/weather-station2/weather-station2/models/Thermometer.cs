namespace weather_station2.models
{
    public class Thermometer : Sensor
    {
        private double medianTemperature;

        public Thermometer(double medianTemperature)
        {
            this.medianTemperature = medianTemperature;
        }

        public double GetTemperature()
        {
            return GetSensorValue(medianTemperature, 20, true);
        }
    }
}