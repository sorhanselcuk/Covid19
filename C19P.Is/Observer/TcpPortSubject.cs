using C19P.Is.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.Observer
{
    public class TcpPortSubject : ISubject
    {
        List<IObserver> _observers;
        private ICovidBilgiServis _covidBilgiServis;
        public TcpPortSubject(ICovidBilgiServis covidBilgiServis)
        {
            _covidBilgiServis = covidBilgiServis;
            _observers = new List<IObserver>();
        }
        public void NotifyObserver()
        {
            string json = JsonConvert.SerializeObject(_covidBilgiServis.HepsiniGetir());
            foreach (var observer in _observers)
            {
                observer.Update(json);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
