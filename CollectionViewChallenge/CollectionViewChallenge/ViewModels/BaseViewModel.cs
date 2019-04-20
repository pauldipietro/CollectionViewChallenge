using System;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;

namespace CollectionViewChallenge.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public BaseViewModel()
        {

        }
 
        public bool IsInitialized { get; set; }

        private bool isBusy;
        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public async Task PushModalAsync(Xamarin.Forms.Page page)
        {
            if (App.Navigation != null)
                await App.Navigation.PushModalAsync(page);
        }

        public async Task PopModalAsync()
        {
            if (App.Navigation != null)
                await App.Navigation.PopModalAsync();
        }

        public async Task PushAsync(Xamarin.Forms.Page page)
        {
            if (App.Navigation != null)
                await App.Navigation.PushAsync(page);
        }

        public async Task PopAsync()
        {
            if (App.Navigation != null)
                await App.Navigation.PopAsync();
        }

        public void RemoveStackPages(Xamarin.Forms.Page exceptedPage = null)
        {
            var existingPages = App.Navigation.NavigationStack.ToList();
            foreach (var page in existingPages)
            {
                if (page != null && page == exceptedPage)
                    continue;

                App.Navigation.RemovePage(page);
            }
        }

        #region INotifyPropertyChanging implementation

        public event PropertyChangingEventHandler PropertyChanging;

        #endregion

        public void OnPropertyChanging(string propertyName)
        {
            if (PropertyChanging == null)
                return;

            PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}