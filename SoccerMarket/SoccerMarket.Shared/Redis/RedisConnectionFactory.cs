using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerMarket.Shared.Redis
{
    public static class RedisConnectionFactory
    {
        public static ConnectionMultiplexer Connection { get; private set; }

        public static void Connect()
        {
            ConfigurationOptions options = new ConfigurationOptions();
            options.EndPoints.Add("localhost:6379");

            Connection = ConnectionMultiplexer.Connect(options);
        }

        public static IDatabase GetDatabase()
        {
            return Connection.GetDatabase();
        }
    }
}