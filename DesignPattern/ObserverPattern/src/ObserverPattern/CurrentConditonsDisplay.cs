namespace ObserverPattern
{
    using System;
    using Interfaces;
    public class CurrentConditonsDisplay : Observer, Display
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private readonly Subject Subject;

        public CurrentConditonsDisplay(Subject subject)
        {
            Subject = subject;
            Subject.RegisterObserver(this);
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
