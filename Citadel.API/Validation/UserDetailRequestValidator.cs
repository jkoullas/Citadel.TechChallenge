using Citadel.API.Models;
using FluentValidation;

namespace Citadel.API.Validation
{
    public class UserDetailRequestValidator : AbstractValidator<UserDetailRequest>
    {
        public UserDetailRequestValidator() : base()
        {
            RuleFor(x => x.Name)
                .NotEmpty();

        }
    }
}
