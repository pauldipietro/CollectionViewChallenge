using CollectionViewChallenge.Models;
using CollectionViewChallenge.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        public CollectionViewChallengePage()
        {
            InitializeComponent();
            BindingContext = new MovieCollectionViewModel
            {
                ComedyMovies = new ObservableCollection<Movie>(new[]
                {
                    new Movie
                    {
                        Title = "Happy Gilmore",
                        Image = ImageSource.FromUri(new Uri("https://m.media-amazon.com/images/M/MV5BZWI2NjliOTYtZjE1OS00YzAyLWJjYTQtYWNmZTQzMTQzNzVjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg"))
                    },
                    new Movie
                    {
                        Title = "Billy Madison",
                        Image = ImageSource.FromUri(new Uri("https://m.media-amazon.com/images/M/MV5BMzcyMjZmNjctNGNhMS00ZmQxLWFkNzQtYTIxYjVkYmU1NmNmXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg"))
                    },
                    new Movie
                    {
                        Title = "Mr. Deeds",
                        Image = ImageSource.FromUri(new Uri("https://m.media-amazon.com/images/M/MV5BMTU3NTE3M2QtNWQ0MS00ZmRkLWIwNTMtOTA0ZGM5N2UwMWNjL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY268_CR0,0,182,268_AL_.jpg"))
                    }
                }),
                ActionMovies = new ObservableCollection<Movie>(new[]
                {
                    new Movie
                    {
                        Title = "The Avengers: Endgame",
                        Image = ImageSource.FromUri(new Uri("https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_UX182_CR0,0,182,268_AL_.jpg"))
                    },
                    new Movie
                    {
                        Title = "Captain America: The First Avenger",
                        Image = ImageSource.FromUri(new Uri("https://m.media-amazon.com/images/M/MV5BMTYzOTc2NzU3N15BMl5BanBnXkFtZTcwNjY3MDE3NQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"))
                    },
                    new Movie
                    {
                        Title = "Iron Man",
                        Image = ImageSource.FromUri(new Uri("https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_UX182_CR0,0,182,268_AL_.jpg"))
                    }
                })
            };
        }
    }
}