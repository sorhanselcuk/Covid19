using C19P.Veri.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.Abstract
{
    public interface ICovidBilgiServis
    {
        int ToplamTestSayisi();
        int ToplamVakaSayisi();
        int ToplamVefatSayisi();
        int ToplamEntubeSayisi();
        int ToplamIyilesenSayisi();
        CovidVeri Getir(DateTime tarih);
        List<CovidVeri> HepsiniGetir();
    }
}
