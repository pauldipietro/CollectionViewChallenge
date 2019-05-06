using System.Collections.Generic;
using System.Threading.Tasks;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.Services
{
    public interface IDataService
    {
        Task<IEnumerable<Movie>> GetMoviesAsync();
    }
}
