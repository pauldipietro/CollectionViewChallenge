using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewChallenge.Services
{
    public interface IMarvelService<T>
    {
        Task<T> GetCharacterAsync(string id);
        Task<IEnumerable<T>> GetCharactersAsync(bool forceRefresh = false);
    }
}
