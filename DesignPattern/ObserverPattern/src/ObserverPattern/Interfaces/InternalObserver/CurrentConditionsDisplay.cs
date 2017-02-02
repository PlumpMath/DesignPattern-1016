namespace ObserverPattern.Interfaces.InternalObserver
{
    using System;
    public class CurrentConditionsDisplay : Display, IObserver<CurrentConditionsDisplay>
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private WeatherData observable;

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(CurrentConditionsDisplay value)
        {
            throw new NotImplementedException();
        }

        

        public CurrentConditionsDisplay(WeatherData observalbe)
        {
            observable = observable;
            observable.Subscribe(this);
        }
        public void Display()
        {
            Console.WriteLine("\n current conditions : \n temperature : " + Temperature + "F degrees" +
                 "and  " + Humidity + "% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Display();
        }
    }
}
