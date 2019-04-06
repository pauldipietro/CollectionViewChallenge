using System.Collections.Generic;
using System.Threading.Tasks;
using CollectionViewChallenge.Models;
using Refit;

namespace CollectionViewChallenge.Services
{
    public interface IPlayersService
    {
        [Get("/players-stats-teams/{team}")]
        Task<IEnumerable<Player>> GetPlayers(string team);

        [Get("/players-stats")]
        Task<IEnumerable<Player>> GetPlayers();
    }
}
