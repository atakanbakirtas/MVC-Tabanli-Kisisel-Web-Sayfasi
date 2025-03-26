using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidation:AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-mail boş olamaz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş olamaz.");
        }
    }
}
