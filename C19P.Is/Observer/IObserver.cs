using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.Observer
{
    public interface IObserver
    {
        void Update(string json);
    }
}
