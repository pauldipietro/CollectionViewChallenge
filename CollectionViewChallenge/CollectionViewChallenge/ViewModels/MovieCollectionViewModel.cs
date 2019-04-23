using CollectionViewChallenge.Models;
using System.Collections.ObjectModel;

namespace CollectionViewChallenge.ViewModels
{
    public class MovieCollectionViewModel
    {
        public ObservableCollection<Movie> ActionMovies { get; set; }
        public ObservableCollection<Movie> ComedyMovies { get; set; }
     }
}
