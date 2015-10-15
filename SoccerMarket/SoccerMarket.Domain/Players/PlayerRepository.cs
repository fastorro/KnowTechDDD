using SoccerMarket.Domain.Players.Objects;
using SoccerMarket.Shared.Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerMarket.Domain.Players
{
    public sealed class PlayerRepository : IPlayerRepository
    {
        public HashSet<Player> GetPlayersByAgeRange(int minAge = 0, int maxAge = 40)
        {
            return null;
        }
             
        public void Add(Player domainObject)
        {
            throw new NotImplementedException();
        }

        public Player GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Player domainObject)
        {
            throw new NotImplementedException();
        }
    }
}
