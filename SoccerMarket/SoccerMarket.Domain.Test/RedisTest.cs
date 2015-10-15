using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoccerMarket.Shared.Patterns.Domain;
using SoccerMarket.Shared.Patterns.Repository;
using SoccerMarket.Shared.Redis;
using StackExchange.Redis;
using System.Collections.Generic;

namespace SoccerMarket.Domain.Test
{
    [TestClass]
    public class RedisTest
    {
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            RedisConnectionFactory.Connect();
        }

        [TestMethod]
        public void TestMethod1()
        {
            IDatabase db = RedisConnectionFactory.GetDatabase();

            db.StringSet("a", "hello world");

            string a = db.StringGet("a");
        }
    }
}
