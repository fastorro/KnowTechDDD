using FluentValidation;
using FluentValidation.Results;
using SoccerMarket.Shared.Patterns.Specification;
using System;
using System.Collections.Generic;

namespace SoccerMarket.Shared.Patterns.Domain
{
    public abstract class DomainSpecification<TObjectId, TObject> : AbstractValidator<TObject>, ISpecification<TObject>
        where TObjectId : IEquatable<TObjectId>
        where TObject : IDomainObject<TObjectId>
    {
        public Dictionary<string, string> BrokenRules { get; } = new Dictionary<string, string>();

        public bool IsSatisfiedBy(TObject someObject)
        {
            ValidationResult result = Validate(someObject);

            if (!result.IsValid)
                foreach (ValidationFailure failure in result.Errors)
                    BrokenRules.Add(failure.PropertyName, failure.ErrorMessage);

            return result.IsValid;
        }
    }
}
