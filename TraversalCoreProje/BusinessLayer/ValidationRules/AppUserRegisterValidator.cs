using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator: AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");
            RuleFor(x=>x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x=>x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez.");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez.");

            RuleFor(X => X.Username).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınz.");
            RuleFor(X => X.Username).MaximumLength(20).WithMessage("Lütfen en fazla 5 karakter veri girişi yapınz.");
            RuleFor(X => X.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbiri ile uyuşmuyor.");
        }
    }
}
