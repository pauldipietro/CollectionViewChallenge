using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Timers;
using System.Windows.Input;
using CollectionViewChallenge.Models;
using CollectionViewChallenge.Models.Enums;
using Xamarin.Forms;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel : BaseViewModel
    {
        private ICommand _actionCommand;
        private ObservableCollection<CollectionItemViewModel> _singAlongItemSource;
        private ObservableCollection<CollectionItemViewModel> _madeForUserItemSource;
        private ObservableCollection<CollectionItemViewModel> _recentlyPlayedItemSource;
        private string _username;
        private double _playingLength;
        private bool _isPlaying;
        private bool _isFavourite;

        public CollectionViewChallengeViewModel()
        {
            _singAlongItemSource = new ObservableCollection<CollectionItemViewModel>();
            _madeForUserItemSource = new ObservableCollection<CollectionItemViewModel>();
            _recentlyPlayedItemSource = new ObservableCollection<CollectionItemViewModel>();

            _username = string.Empty;
            _playingLength = 0;

            _isPlaying = false;
            _isFavourite = false;
        }

        internal void InitializeView()
        {
            SingAlongItemSource = new ObservableCollection<CollectionItemViewModel>();
            MadeForUserItemSource = new ObservableCollection<CollectionItemViewModel>();
            RecentlyPlayedItemSource = new ObservableCollection<CollectionItemViewModel>();

            Username = "Hachiko";
            PlayingLength = 0;

            IsPlaying = false;
            IsFavourite = false;

            SingAlongItemSource = PopulateCollectionData(CollectionTypes.SingAlong);
            MadeForUserItemSource = PopulateCollectionData(CollectionTypes.MadeForUser);
            RecentlyPlayedItemSource = PopulateCollectionData(CollectionTypes.RecentlyPlayed);
        }

        private ObservableCollection<CollectionItemViewModel> PopulateCollectionData(CollectionTypes types)
        {
            var populatedData = new ObservableCollection<CollectionItemViewModel>();
            var titles = new List<string>();
            var coverUrls = new List<string>();
            var descriptions = new List<string>();

            switch (types)
            {
                case CollectionTypes.SingAlong:
                    titles = new List<string>
                    {
                        "Songs to Sing in the Car",
                        "So You Think You Can Sing",
                        "Sing Along K-Pop",
                        "Sing-along: 90's to Now"
                    };

                    coverUrls = new List<string>
                    {
                        "sing_along1.jpeg",
                        "sing_along2.jpeg",
                        "sing_along3.jpeg",
                        "sing_along4.jpeg"
                    };

                    descriptions = new List<string>
                    {
                        "Shawn Mendes, Lady Gaga, Ariana Grande, Khalid, Queen",
                        "Calum Scott, Beyoncé, Sia, Bruno Mars, David Guetta",
                        "BTS, BLACKPINK, EXO, Red Velvet, SHINee, BIGBANG",
                        "Kelly Clarkson, Beyoncé, Miley Cyrus, Rihanna, Ne-Yo"
                    };
                    break;
                case CollectionTypes.MadeForUser:
                    titles = new List<string>
                    {
                        "Daily Mix 1",
                        "Daily Mix 2",
                        "Daily Mix 3",
                        "Daily Mix 4"
                    };

                    coverUrls = new List<string>
                    {
                        "daily_mix1.jpeg",
                        "daily_mix2.jpeg",
                        "daily_mix3.jpeg",
                        "daily_mix4.jpeg"
                    };

                    descriptions = new List<string>
                    {
                        "JJ Lin, Leehom Wang, Kimberley Chen and more",
                        "Glee Cast, Shawn Mendes, Katy Perry and more",
                        "A.R. Rahman, Penn Masala, Pritam and more",
                        "Andra & The Backbone, Gita Gutawa, Ungu and more"
                    };
                    break;
                case CollectionTypes.RecentlyPlayed:
                    titles = new List<string>
                    {
                        "This is Shawn Mendes",
                        "This is JJ Lin",
                        "All Out 00s",
                        "Blast from the Past"
                    };

                    coverUrls = new List<string>
                    {
                        "recently_played1.jpeg",
                        "recently_played2.jpeg",
                        "recently_played3.jpeg",
                        "recently_played4.jpeg"
                    };

                    descriptions = new List<string>
                    {
                        "",
                        "",
                        "",
                        ""
                    };
                    break;
            }

            for (int i = 0; i < titles.Count; i++)
                populatedData.Add(new CollectionItemViewModel
                {
                    Title = titles[i],
                    CoverUrl = coverUrls[i],
                    Description = descriptions[i],
                    DescRowHeight = string.IsNullOrWhiteSpace(descriptions[i]) ? new GridLength(30) : new GridLength(50)
                });

            return populatedData;
        }

        #region Binding properties
        public ObservableCollection<CollectionItemViewModel> SingAlongItemSource
        {
            get { return _singAlongItemSource; }
            set { SetProperty(ref _singAlongItemSource, value); }
        }

        public ObservableCollection<CollectionItemViewModel> MadeForUserItemSource
        {
            get { return _madeForUserItemSource; }
            set { SetProperty(ref _madeForUserItemSource, value); }
        }

        public ObservableCollection<CollectionItemViewModel> RecentlyPlayedItemSource
        {
            get { return _recentlyPlayedItemSource; }
            set { SetProperty(ref _recentlyPlayedItemSource, value); }
        }

        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        public double PlayingLength
        {
            get { return _playingLength; }
            set { SetProperty(ref _playingLength, value); }
        }

        public bool IsPlaying
        {
            get { return _isPlaying; }
            set { SetProperty(ref _isPlaying, value); }
        }

        public bool IsFavourite
        {
            get { return _isFavourite; }
            set { SetProperty(ref _isFavourite, value); }
        }
        #endregion

        #region ActionCommand
        public ICommand ActionCommand
        {
            get { return _actionCommand ?? (_actionCommand = new Command<string>(ExecuteActionCommand)); }
        }

        private void ExecuteActionCommand(string parameter)
        {
            switch (parameter)
            {
                case "PlayPause":
                    PlayPauseMusic();
                    break;
                case "Favourite":
                    IsFavourite = !IsFavourite;
                    break;
            }
        }

        private void PlayPauseMusic()
        {
            IsPlaying = !IsPlaying;

            Device.StartTimer(TimeSpan.FromMilliseconds(50), () =>
            {
                if (PlayingLength.Equals(400))
                {
                    IsPlaying = false;
                    PlayingLength = 0;
                }

                PlayingLength++;

                return IsPlaying; // True = Repeat again, False = Stop the timer
            });
        }
        #endregion
    }
}
