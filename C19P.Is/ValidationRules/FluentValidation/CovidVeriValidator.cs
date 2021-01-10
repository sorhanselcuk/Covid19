using C19P.Veri.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.ValidationRules.FluentValidation
{
    public class CovidVeriValidator:AbstractValidator<CovidVeri>
    {
        public CovidVeriValidator()
        {
            RuleFor(c => c.Tarih).NotEmpty().WithMessage("Tarih boş bırakılamaz !");
            RuleFor(c => c.TestSayisi).NotEmpty().WithMessage("Test sayısı boş bırakılamaz !");
            RuleFor(c => c.EntubeSayisi).NotEmpty().WithMessage("Entübe hasta sayısı boş bırakılamaz !");
            RuleFor(c => c.VakaSayisi).NotEmpty().WithMessage("Vaka sayısı boş bırakılamaz !");
            RuleFor(c => c.TestSayisi).NotEmpty().WithMessage("Vefat sayısı boş bırakılamaz !");
            RuleFor(c => c.TestSayisi).NotEmpty().WithMessage("İyileşen hasta sayısı boş bırakılamaz !");
        }
    }
}
