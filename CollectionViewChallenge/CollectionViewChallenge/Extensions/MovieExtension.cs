using System.Linq;
using System.Collections.Generic;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.Extensions
{
    public static class MovieExtension
    {
        public static IList<GroupMovieModel> GroupByCategory(this IList<MovieModel> movies)
        {
            return movies
                .GroupBy(m => m.Category)
                .Select(group => new GroupMovieModel(group.Key, group.ToList()))
                .ToList();
        }
    }
}
