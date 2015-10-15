using SoccerMarket.Shared.Patterns.Domain;
using SoccerMarket.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerMarket.Domain.Players.Objects
{
    public sealed class Player : IDomainObject<Guid>
    {
        public Guid Id { get; set; }

        public bool IsDirty => Id == Guid.Empty;

        public PersonalInfo Info { get; set; }
    }
}