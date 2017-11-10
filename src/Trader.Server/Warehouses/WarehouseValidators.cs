using FluentValidation;
using Hse.Application.Contracts;

namespace Hse.Validation
{
    public class CreateWarehouseValidator : AbstractValidator<CreateWarehouseModel>
    {
        public CreateWarehouseValidator()
        {
            RuleFor(model => model.Name).NotNull().NotEmpty();
        }
    }

    public class RenameWarehouseValidator : AbstractValidator<RenameWarehouseModel>
    {
        public RenameWarehouseValidator()
        {
            RuleFor(model => model.NewName).NotNull().NotEmpty();
        }
    }
}
