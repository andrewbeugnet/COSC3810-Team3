namespace weather_station2.models
{
    public class Barometer : Sensor
    {
        private double medianPressure;
        public double pressure { get; set; }

        public Barometer(double medianPressure)
        {
            this.medianPressure = medianPressure;
            this.pressure = GetPressure();
        }

        public double GetPressure()
        {
            return GetSensorValue(medianPressure, 2, false);
        }
    }
}