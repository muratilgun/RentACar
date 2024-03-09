using FluentValidation;

namespace RentACar.Application.Features.Brands.Commands.Create;
public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
{
    public CreateBrandCommandValidator()
    {
        RuleFor(p => p.Name).NotEmpty().MinimumLength(2);
    }

}
