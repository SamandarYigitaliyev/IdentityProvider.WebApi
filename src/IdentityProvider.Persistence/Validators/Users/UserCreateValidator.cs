using FluentValidation;
using IdentityProvider.Persistence.Dtos.Users;

namespace IdentityProvider.Persistence.Validators.Users
{
    public class UserCreateValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateValidator()
        {
            RuleFor(dto => dto.FirstName).NotNull().NotEmpty().WithMessage("FistName field is required")
                .MinimumLength(3).WithMessage("FirstName must be more than 3 characters ")
                     .MaximumLength(15).WithMessage("FirstName must be less than 15 charqcters");
            RuleFor(dto => dto.LastName).NotNull().NotEmpty().WithMessage("LastName field is required")
                .MinimumLength(3).WithMessage("LastName must ber more than 3 charcters")
                    .MaximumLength(15).WithMessage("LastName must be less than 15 characters");

            RuleFor(dto => dto.PhoneNumber).Must(phone => PhoneNumberValidator.IsPhoneNumber(phone))
                .WithMessage("Phone number is ivalid! ex: +998xxYYYzzAA ");

            RuleFor(dto => dto.Password).Must(password => PasswordValidator.IsStrongPassword(password).result);
                
        }
    }
}
