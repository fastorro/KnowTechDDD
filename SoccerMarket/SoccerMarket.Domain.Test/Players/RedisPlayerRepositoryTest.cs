using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoccerMarket.Shared.Redis;
using SoccerMarket.Domain.Players;
using SoccerMarket.Domain.Players.Objects;
using SoccerMarket.ValueObject;

namespace SoccerMarket.Domain.Test.Players
{
    [TestClass]
    public class RedisPlayerRepositoryTest
    {
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            RedisConnectionFactory.Connect();
        }

        [TestMethod]
        public void CanAddPlayers()
        {
            /*PlayerRepository playerRepo = new PlayerRepository();

            Player player = new Player
            {
                Info = new PersonalInfo
                {
                    Name = "Matías",
                    LastName = "Fidemraizer",
                    Age = 30
                }
            };

            playerRepo.Add(player);

            Player createdPlayer = playerRepo.GetById(player.Id);*/
        }
    }
}
