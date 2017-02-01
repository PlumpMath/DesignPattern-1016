namespace ObserverPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditonsDisplay currentConditionsDisplay = new CurrentConditonsDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 75, 20.4f);
        }
    }
}
