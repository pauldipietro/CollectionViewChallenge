using System.Collections.Generic;
using System.Threading.Tasks;
using CollectionViewChallenge.Models;
using Refit;

namespace CollectionViewChallenge.Services
{
    public class PlayersService : IPlayersService
    {
        private const string baseUrl = "https://nba-players.herokuapp.com";

        public async Task<IEnumerable<Player>> GetPlayers(string team)
        {
            var service = RestService.For<IPlayersService>(baseUrl);

            return await service.GetPlayers(team);
        }

        public async Task<IEnumerable<Player>> GetPlayers()
        {
            var service = RestService.For<IPlayersService>(baseUrl);

            return await service.GetPlayers();
        }
    }
}
