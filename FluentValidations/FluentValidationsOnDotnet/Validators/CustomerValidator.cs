using FluentValidation;
using FluentValidationsOnDotnet.Model.Customer;

namespace FluentValidationsOnDotnet.Validators;

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3);
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
    }
}
