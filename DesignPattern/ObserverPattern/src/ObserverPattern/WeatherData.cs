namespace ObserverPattern
{
    using System;
    using Interfaces;
    using System.Collections.Generic;

    public class WeatherData : Subject
    {
        public List<Observer> Observers = new List<Observer>();
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; } 
        public void NotifyObservers()
        {
            foreach(var observer in Observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void RegisterObserver(Observer observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            Observers.Remove(observer);
        }

        public void MeasurementsChanges()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp,float humidity,float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanges();
        }
    }
}
