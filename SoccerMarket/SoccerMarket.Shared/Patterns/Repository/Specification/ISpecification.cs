using System.Collections.Generic;

namespace SoccerMarket.Shared.Patterns.Specification
{
    public interface ISpecification<TObject>
    {
        Dictionary<string, string> BrokenRules { get; }
        bool IsSatisfiedBy(TObject someObject);
    }
}