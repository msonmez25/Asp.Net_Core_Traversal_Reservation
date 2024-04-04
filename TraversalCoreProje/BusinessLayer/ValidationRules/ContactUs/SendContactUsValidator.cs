using DTOLayer.DTOs.ContactDTOS;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator: AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen isim-soyisim alanını boş bırakmayınız.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen mail alanını boş bırakmayınız.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfen konu alanını boş bırakmayınız.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Lütfen mesaj alanını boş bırakmayınız.");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Lütfen isim-soyisim alanını en az 5 karakter olacak şeklide yazınız.");
            RuleFor(x => x.Mail).MinimumLength(12).WithMessage("Lütfen mail alanını en az 12 karakter olacak şeklide yazınız.");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Lütfen konu alanını en az 5 karakter olacak şeklide yazınız.");
            RuleFor(x => x.Message).MinimumLength(5).WithMessage("Lütfen mesaj alanını en az 5 karakter olacak şeklide yazınız.");
        }
    }
}
