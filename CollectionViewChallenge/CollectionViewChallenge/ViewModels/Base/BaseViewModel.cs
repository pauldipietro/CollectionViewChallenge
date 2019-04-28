using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CollectionViewChallenge.ViewModels.Base
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        //protected readonly INavigationService NavigationService;
        

        public BaseViewModel()
        {
            //  NavigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
        }

        string title;
        public string Title
        {
            get => title;
            set
            {
                if (title == value)
                    return;
                title = value;
                OnPropertyChanged();
            }
        }

        bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy == value)
                    return;
                isBusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));
            }
        }

        public bool IsNotBusy => !IsBusy;

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion INotifyPropertyChanged
    }
}
