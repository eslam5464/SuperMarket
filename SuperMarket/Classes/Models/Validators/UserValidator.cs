using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Classes.Models.Validators
{
    class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            //.Cascade(CascadeMode.StopOnFirstFailure)
            RuleFor(u => u.Id).NotEmpty().WithMessage("الرقم التعريفي خطأ");
            RuleFor(u => u.Username).NotEmpty().WithMessage("برجاء كتابه اسم المستخدم");
            RuleFor(u => u.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("برجاء كتابه البريد الالكتروني")
                .EmailAddress().WithMessage("برجاء كتابه بريد الكتروني صحيح");
            RuleFor(u => u.CreationDate);
        }

        //useage

        //UserValidator validator = new UserValidator();
        //var results = validator.Validate(user);

        //if(!results.IsValid){
        //    foreach (var errorMSG in results.Errors)
        // {
        //       errorMSG.PropertyName ;
        //       errorMSG.ErrorMessage ;
        // }
        //}
    }
}
