using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoccerMarket.Domain.Players.Objects;

namespace SoccerMarket.Domain.Players
{
    public sealed class DefaultPlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepo;

        public DefaultPlayerService(IPlayerRepository playerRepo)
        {
            _playerRepo = playerRepo;
        }

        private IPlayerRepository PlayerRepo
        {
            get
            {
                return _playerRepo;
            }
        }

        public void AddNewPlayer(Player player)
        {
            PlayerRepo.Add(player);
        }
    }
}
