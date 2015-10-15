using SoccerMarket.Domain.Players.Objects;
using SoccerMarket.Shared.Patterns.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerMarket.Domain.Players
{
    public interface IPlayerRepository : IRepository<Guid, Player>
    {
        HashSet<Player> GetPlayersByAgeRange(int minAge = 0, int maxAge = 40);
    }
}
