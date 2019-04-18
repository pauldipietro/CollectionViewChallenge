using System.ComponentModel;
using Xamarin.Forms;

namespace CollectionViewChallenge.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation MyNavigation { get; set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void OnAppearing()
        {
            RefreshView();
            MessagingCenter.Subscribe<App>(this, "AppOnResume", (_) => RefreshView());
        }

        public virtual void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<App>(this, "AppOnResume");
        }

        protected abstract void RefreshView();
    }
}
