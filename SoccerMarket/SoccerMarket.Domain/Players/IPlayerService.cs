using SoccerMarket.Domain.Players.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerMarket.Domain.Players
{
    public interface IPlayerService
    {
        void AddNewPlayer(Player player);
    }
}
