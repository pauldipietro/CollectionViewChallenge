using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CollectionViewChallenge.Data;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<ArtistElement> Artists { get; private set; }
        public ObservableCollection<Item> Albums { get; private set; }

        public CollectionViewChallengeViewModel()
        {
            GetArtists();
            GetAlbums();
        }

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        void GetArtists()
        {
            var resource = new ArtistsResource();
            Artists = new ObservableCollection<ArtistElement>(resource.GetArtists());
        }

        void GetAlbums()
        {
            var resource = new AlbumsResource();
            Albums = new ObservableCollection<Item>(resource.GetAlbums());
        }
    }
}
