using C19P.Veri.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.VeriErisim.Abstract
{
    public interface INesne<T> where T: class,IVeri,new()
    {
        void Ekle(T veri);
        void Sil(T veri);
        void Guncelle(T veri);
        T Getir(T veri);
        List<T> HepsiniGetir();
    }
}
