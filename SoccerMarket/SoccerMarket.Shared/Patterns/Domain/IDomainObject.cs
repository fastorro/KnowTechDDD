using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerMarket.Shared.Patterns.Domain
{
    public interface IDomainObject<TId>
        where TId : IEquatable<TId>
    {
        TId Id { get; }
        bool IsDirty { get; }
    }
}
