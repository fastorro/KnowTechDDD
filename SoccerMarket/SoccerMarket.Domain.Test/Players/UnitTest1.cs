using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoccerMarket.Domain.Players;
using SoccerMarket.Shared.Patterns.IoC;
using SoccerMarket.Shared.Redis;
using SoccerMarket.Domain.Players.Objects;

namespace SoccerMarket.Domain.Test.Players
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void Init(TestContext context)
        {
            ContainerConfiguration.Configure();
            RedisConnectionFactory.Connect();
        }

        [TestMethod]
        public void TestMethod1()
        {
            IPlayerService playerService = Container.Current.Resolve<IPlayerService>();
            playerService.AddNewPlayer(new Player());
        }
    }
}
