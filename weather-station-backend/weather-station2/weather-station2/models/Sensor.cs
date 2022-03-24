namespace weather_station2.models
{
    public class Sensor
    {
        protected double GetSensorValue(double median, double difference, bool canBeNegative)
        {
            Random rnd = new Random();
            double max = median + difference;
            double min = median - difference;
            if(min < 0 && !canBeNegative) min = 0;
            
            return rnd.NextDouble() * (max - min) + min;
        }
    }
}