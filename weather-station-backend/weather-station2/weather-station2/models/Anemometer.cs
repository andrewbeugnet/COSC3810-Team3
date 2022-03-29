namespace weather_station2.models
{
    public class Anemometer : Sensor
    {
        private double medianWindSpeed;
        public double windspeed { get; set; }
        public string direction { get; set; }

        public Anemometer(double medianWindSpeed)
        {
            this.medianWindSpeed = medianWindSpeed;
            this.direction = GetWindDirection();
            this.windspeed = GetWindSpeed();
        }

        public double GetWindSpeed()
        {
            return GetSensorValue(medianWindSpeed, 4, false);
        }

        public string GetWindDirection()
        {
            Random rnd = new Random();
            int value = (int)rnd.NextInt64(4);
            switch(value)
            {
                case 0:
                return "South";
                case 1:
                return "East";
                case 2:
                return "West";
                case 3:
                return "North";
                default:
                return "No Wind";
            }
        }

    }
}