using DTOLayer.DTOs.Announcement;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class UpdateAnnouncementValidator : AbstractValidator<UpdateAnnouncementDto>
    {
        public UpdateAnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlığı boş bırakmayınız.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen duyuru içeriğini boş bırakmayınız.");
            RuleFor(x => x.DateAnnouncement).NotEmpty().WithMessage("Lütfen duyuru tarihi boş bırakmayınız.");

            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen başlığı en az 5 karakter olacak şeklide yazınız.");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen duyuru içeriği en az 20 karakter olacak şeklide yazınız.");

            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen başlığı en fazla 5 karakter olacak şeklide yazınız.");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen duyuru içeriği en fazla 20 karakter olacak şeklide yazınız.");
        }
    }
}
