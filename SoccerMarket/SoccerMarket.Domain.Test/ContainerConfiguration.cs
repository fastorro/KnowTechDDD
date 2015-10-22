using Castle.MicroKernel.Registration;
using SoccerMarket.Domain.Players;
using SoccerMarket.Domain.Players.Objects;
using SoccerMarket.Domain.Players.Specs;
using SoccerMarket.Shared.Patterns.IoC;
using SoccerMarket.Shared.Patterns.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerMarket.Domain.Test
{
    public static class ContainerConfiguration
    {
        public static void Configure()
        {
            Container.Configure
            (
                container =>
                {
                    container.Register
                    (
                        Component.For<IPlayerRepository>().ImplementedBy<PlayerRepository>()
                                .LifestyleTransient(),

                        Component.For<IPlayerService>().ImplementedBy<DefaultPlayerService>()
                                .LifestyleTransient(),

                        Component.For<ISpecification<Player>>().ImplementedBy<CreatePlayerSpec>()
                                .LifestyleTransient()
                        );
                }
            );
        }
    }
}
