using FluentValidation;
using SoccerMarket.Domain.Players.Objects;
using SoccerMarket.Shared.Patterns.Domain;
using System;

namespace SoccerMarket.Domain.Players.Specs
{
    public sealed class CreatePlayerSpec : DomainSpecification<Guid, Player>
    {
        public CreatePlayerSpec()
        {
            RuleFor(player => player.Info).NotNull();
            RuleFor(player => player.Info.Age).GreaterThan(0).LessThan(100);
            RuleFor(player => player.Info.Name).Length(2, 55);
            RuleFor(player => player.Info.LastName).Length(2, 55);
        }
    }
}