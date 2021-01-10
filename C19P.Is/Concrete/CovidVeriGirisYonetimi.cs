using C19P.Is.Abstract;
using C19P.Is.Utilities;
using C19P.Is.ValidationRules.FluentValidation;
using C19P.Veri.Concrete;
using C19P.VeriErisim.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.Concrete
{
    public class CovidVeriGirisYonetimi : ICovidVeriGirisServis
    {
        private ICovidVeriDal _covidVeriDal;
        public CovidVeriGirisYonetimi(ICovidVeriDal covidVeriDal)
        {
            _covidVeriDal = covidVeriDal;
        }
        public void Ekle(CovidVeri covidVeri)
        {
            HataYonetimi.HandleException(() =>
            {
                ValidationTool.Validate(new CovidVeriValidator(), covidVeri);
            });
            _covidVeriDal.Ekle(covidVeri);
        }

        public void Guncelle(CovidVeri covidVeri)
        {
            HataYonetimi.HandleException(() =>
            {
                ValidationTool.Validate(new CovidVeriValidator(), covidVeri);
            });
            _covidVeriDal.Guncelle(covidVeri);
        }

        public void Sil(DateTime tarih)
        {
            if (tarih == null)
                HataYonetimi.HandleException(() => { throw new Exception("Tarih kısmı boş bırakılamaz !"); });
            _covidVeriDal.Sil(new CovidVeri { Tarih = tarih });
        }
    }
}
