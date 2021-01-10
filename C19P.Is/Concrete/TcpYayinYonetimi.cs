using C19P.Is.Abstract;
using C19P.Is.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.Concrete
{
    public class TcpYayinYonetimi : ITcpYayinServis
    {
        private ISubject _subject;
        public TcpYayinYonetimi(ISubject subject)
        {
            _subject = subject;
        }

        public void DinleyiciCikar(IObserver observer)
        {
            _subject.RemoveObserver(observer);
        }

        public void DinleyiciEkle(IObserver observer)
        {
            _subject.RegisterObserver(observer);
        }

        public void YayinBaslat()
        {
            _subject.NotifyObserver();
        }
    }
}
