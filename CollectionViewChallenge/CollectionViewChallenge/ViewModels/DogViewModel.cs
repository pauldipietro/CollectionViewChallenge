using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using CollectionViewChallenge.Models;
using CollectionViewChallenge.Services;
using System.Runtime.CompilerServices;

namespace CollectionViewChallenge.ViewModels
{
    public class DogViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<Dog> dogList;

        private ObservableCollection<Dog> dogCollection;

        public ObservableCollection<Dog> DogCollection
        {
            get { return dogCollection; }
            set { dogCollection = value; OnPropertyChanged(); }
        }

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; OnPropertyChanged(); }
        }

        public async Task LoadData()
        {
            IsBusy = true;
            dogList = await DogApiService.GetDogs();
            DogCollection = new ObservableCollection<Dog>(dogList);
            IsBusy = false;

        }
    }
}
