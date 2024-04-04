using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideAdminValidator : AbstractValidator<Guide>
    {
        public GuideAdminValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber ad-soyad giriniz..!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Maximum 30 karakter giriniz.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Minimum 3 karakter giriniz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen açıklamasını giriniz..!");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Lütfen açıklamasını giriniz..!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen rehber görselini giriniz..!");
        }
    }
}
