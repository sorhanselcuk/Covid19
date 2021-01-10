using C19P.Is.Abstract;
using C19P.Veri.Concrete;
using C19P.VeriErisim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.Concrete
{
    public class CovidBilgiYonetimi : ICovidBilgiServis
    {
        private ICovidVeriDal _covidVeriDal;
        public CovidBilgiYonetimi(ICovidVeriDal covidVeriDal)
        {
            _covidVeriDal = covidVeriDal;
        }

        public CovidVeri Getir(DateTime tarih)
        {
            return _covidVeriDal.Getir(new CovidVeri { Tarih=tarih });
        }

        public List<CovidVeri> HepsiniGetir()
        {
            return _covidVeriDal.HepsiniGetir().OrderBy(c=>c.Tarih).ToList();
        }

        public int ToplamEntubeSayisi()
        {
            return _covidVeriDal.HepsiniGetir().Sum(c=>c.EntubeSayisi);
        }

        public int ToplamIyilesenSayisi()
        {
            return _covidVeriDal.HepsiniGetir().Sum(c => c.IyilesenSayisi);
        }

        public int ToplamTestSayisi()
        {
            return _covidVeriDal.HepsiniGetir().Sum(c => c.TestSayisi);
        }

        public int ToplamVakaSayisi()
        {
            return _covidVeriDal.HepsiniGetir().Sum(c => c.VakaSayisi);
        }

        public int ToplamVefatSayisi()
        {
            return _covidVeriDal.HepsiniGetir().Sum(c => c.VefatSayisi);
        }
    }
}
