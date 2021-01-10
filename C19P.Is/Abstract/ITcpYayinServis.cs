using C19P.Is.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.Abstract
{
    public interface ITcpYayinServis
    {
        void YayinBaslat();
        void DinleyiciEkle(IObserver observer);
        void DinleyiciCikar(IObserver observer);
    }
}
