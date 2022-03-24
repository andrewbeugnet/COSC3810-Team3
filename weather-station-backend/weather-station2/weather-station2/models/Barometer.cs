namespace weather_station2.models
{
    public class Barometer : Sensor
    {
        private double medianPressure;

        public Barometer(double medianPressure)
        {
            this.medianPressure = medianPressure;
        }

        public double GetPressure()
        {
            return GetSensorValue(medianPressure, 2, false);
        }
    }
}