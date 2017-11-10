using System;
using FluentValidation;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Hse.Validation
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            if (actionContext.ModelState.IsValid) return;

            var errors = actionContext.ModelState
                .Where(e => e.Value.Errors.Any())
                .Select(e => new
                {
                    Name = e.Key,
                    Message = e.Value.Errors.First().ErrorMessage
                })
                .ToArray();

            actionContext.Result = new BadRequestObjectResult(errors);
        }
    }

    public class GuidValidator : AbstractValidator<Guid>
    {
        public GuidValidator()
        {
            RuleFor(guid => guid).NotEmpty();
        }
    }

    public class StringValidator : AbstractValidator<string>
    {
        public StringValidator()
        {
            RuleFor(value => value).NotNull().NotEmpty();
        }
    }

    public class ValidatorFactory : ValidatorFactoryBase
    {
        private readonly IServiceProvider _serviceProvider;

        public ValidatorFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <exception cref="System.ArgumentNullException">The <paramref name="validatorType" /> is <c>null</c>.</exception>
        public override IValidator CreateInstance(Type validatorType) =>
            _serviceProvider.GetService(validatorType) as IValidator;
    }
}