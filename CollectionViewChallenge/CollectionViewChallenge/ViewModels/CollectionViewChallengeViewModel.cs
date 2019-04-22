using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel : BaseViewModel
    {
        private ICommand _switchCommand;
        private ObservableCollection<CollectionItemViewModel> _collectionItemSource;
        private bool _isComingSoon;

        public CollectionViewChallengeViewModel()
        {
            _collectionItemSource = new ObservableCollection<CollectionItemViewModel>();
            _isComingSoon = false;
        }

        internal void InitializeView()
        {
            CollectionItemSource = new ObservableCollection<CollectionItemViewModel>();
            IsComingSoon = false;
        }

        internal async Task LoadNowShowingDataAsync()
        {
            var movieData = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Avengers: Endgame", "avengers_endgame.jpeg"),
                new Tuple<string, string>("[Special Screening] Avengers: Endgame", "avengers_endgame_special.jpeg"),
                new Tuple<string, string>("Hellboy", "hellboy.png"),
                new Tuple<string, string>("Shazam!", "shazam.jpg"),
                new Tuple<string, string>("[FEEL THE MAX] Captain Marvel", "captain_marvel.jpeg"),
                new Tuple<string, string>("The Curse Of The Weeping Woman", "the_curse.jpeg"),
                new Tuple<string, string>("Kanchana 3", "kanchana.jpeg"),
                new Tuple<string, string>("Kalank", "kalank.jpeg"),
            };

            for (int i = 0; i < movieData.Count; i++)
            {
                await Task.Delay(10);

                CollectionItemSource.Add(new CollectionItemViewModel
                {
                    Title = movieData[i].Item1,
                    PosterUrl = movieData[i].Item2,
                    HasIMAX = i < 4 && i != 1,
                    IsAdvanced = i < 2
                });
            }
        }

        private async Task LoadComingSoonDataAsync()
        {
            var movieData = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Invincible Dragon", "invincible_dragon.jpeg"),
                new Tuple<string, string>("Supermum", "supermum.jpeg"),
                new Tuple<string, string>("Student of the Year 2", "student.jpeg"),
                new Tuple<string, string>("Mata Batin 2", "mata_batin.jpeg"),
                new Tuple<string, string>("The Sun Is Also a Star", "the_sun.jpeg"),
                new Tuple<string, string>("UglyDolls", "ugly_dolls.jpeg"),
                new Tuple<string, string>("Brightburn", "brightburn.jpeg"),
                new Tuple<string, string>("London Sweeties", "london_sweeties.jpeg"),
            };

            for (int i = 0; i < movieData.Count; i++)
            {
                await Task.Delay(10);

                CollectionItemSource.Add(new CollectionItemViewModel
                {
                    Title = movieData[i].Item1,
                    PosterUrl = movieData[i].Item2,
                    HasIMAX = false,
                    IsAdvanced = false
                });
            }
        }

        #region Binding properties
        public ObservableCollection<CollectionItemViewModel> CollectionItemSource
        {
            get { return _collectionItemSource; }
            set { SetProperty(ref _collectionItemSource, value); }
        }

        public bool IsComingSoon
        {
            get { return _isComingSoon; }
            set { SetProperty(ref _isComingSoon, value); }
        }
        #endregion

        #region SwitchCommand
        public ICommand SwitchCommand
        {
            get
            {
                async void executeSwitchCommand(string parameter)
                {
                    switch (parameter)
                    {
                        case "NowShowing":
                            if (IsComingSoon)
                            {
                                IsComingSoon = !IsComingSoon;
                                CollectionItemSource = new ObservableCollection<CollectionItemViewModel>();
                                await LoadNowShowingDataAsync();
                            }
                            break;
                        default:
                            if (!IsComingSoon)
                            {
                                IsComingSoon = !IsComingSoon;
                                CollectionItemSource = new ObservableCollection<CollectionItemViewModel>();
                                await LoadComingSoonDataAsync();
                            }
                            break;
                    }
                }
                return _switchCommand ?? (_switchCommand = new Command<string>(executeSwitchCommand));
            }
        }
        #endregion
    }

    public class CollectionItemViewModel
    {
        public ImageSource PosterUrl { get; set; }
        public string Title { get; set; }
        public bool IsAdvanced { get; set; }
        public bool HasIMAX { get; set; }
    }
}
