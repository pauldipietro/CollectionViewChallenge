using System.Collections.Generic;
using System.Threading.Tasks;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.Services
{
    public interface ITeamsService
    {
        Task<IEnumerable<Team>> GetTeams();
    }
}
