using System.Linq;
using System.Collections.Generic;

namespace CollectionViewChallenge.Models
{
    public class GroupMovieModel : List<MovieModel>
    {
        public string GroupName { get; set; }
        public double Height { get; set; }

        public GroupMovieModel(string groupName, IList<MovieModel> movies)
        {
            GroupName = groupName;
            AddRange(movies);
            Height = movies.First().Height;
        }
    }
}
