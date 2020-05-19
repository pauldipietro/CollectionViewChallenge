using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

using System.Linq;
using CollectionViewChallenge.Models;
using System.Diagnostics;
using System.Collections.ObjectModel;
using MvvmHelpers;
using System.Windows.Input;

namespace CollectionViewChallenge.ViewModels
{
    public class MovieViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Movie> Movies { get; }
        public Command<string> GetMoviesCommand { get; }        

        public MovieViewModel()
        {
            Movies = new ObservableRangeCollection<Movie>();
            GetMoviesCommand = new Command<string>(async (test) => await GetMoviesAsync(test));

            GetMoviesCommand.Execute("Hello Bryan");
        }

        async Task GetMoviesAsync(string test)
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var movies = await DataService.GetMoviesAsync();

                Movies.ReplaceRange(movies);

                Title = $"Movies CollectionView ({Movies.Count})";
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get movies: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }       

    }
}
