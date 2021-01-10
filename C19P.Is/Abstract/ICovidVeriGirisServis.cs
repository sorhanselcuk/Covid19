using C19P.Veri.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.Abstract
{
    public interface ICovidVeriGirisServis
    {
        void Ekle(CovidVeri covidVeri);
        void Guncelle(CovidVeri covidVeri);
        void Sil(DateTime tarih);
    }
}
