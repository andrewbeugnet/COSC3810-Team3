namespace weather_station2.models
{
    public class Anemometer: Sensor
    {

        private double medianSpeed;
        public double speed { get; set; }
        public Anemometer(double medianSpeed)
        {
            this.medianSpeed = medianSpeed;
            this.speed = GetSpeed();
        }

        public string GetWindDirection()
        {
            Random rnd = new Random();
            int value = rnd.Next(8);
            switch(value)
            {
                case 0:
                return "N";
                case 1:
                return "NE";
                case 2:
                return "E";
                case 3:
                return "SE";
                case 4:
                return "S";
                case 5:
                return "SW";
                case 6:
                return "W";
                case 7:
                return "NW";
            }
            return "HOW?";
        }

        public double GetSpeed()
        {
            return GetSensorValue(medianSpeed, 2, false);
        }
    }
}