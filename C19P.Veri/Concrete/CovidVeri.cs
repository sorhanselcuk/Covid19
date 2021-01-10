using C19P.Veri.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Veri.Concrete
{
    public class CovidVeri:IVeri
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int TestSayisi { get; set; }
        public int EntubeSayisi { get; set; }
        public int VakaSayisi { get; set; }
        public int VefatSayisi { get; set; }
        public int IyilesenSayisi { get; set; }
    }
}
