namespace ObserverPattern.Interfaces.InternalObserver
{
    using System;
    using System.Collections.Generic;
    public class WeatherData : IObservable<CurrentConditionsDisplay>
    {
        bool isChanged = false;
            public List<Observer> Observers = new List<Observer>();
            public float Temperature { get; set; }
            public float Humidity { get; set; }
            public float Pressure { get; set; }
            public void NotifyObservers()
            {
            if (isChanged)
            {
                foreach (var observer in Observers)
                {
                    observer.Update(Temperature, Humidity, Pressure);
                }
            }
            isChanged = false;
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
            SetChanged();
                NotifyObservers();
            }

        private void SetChanged()
        {
            isChanged = true;
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
            {
                Temperature = temp;
                Humidity = humidity;
                Pressure = pressure;
                MeasurementsChanges();
            }

        public IDisposable Subscribe(IObserver<CurrentConditionsDisplay> observer)
        {
            throw new NotImplementedException();
        }
    }
    }


