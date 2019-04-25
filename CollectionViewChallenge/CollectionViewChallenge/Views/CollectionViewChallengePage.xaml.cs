using System.Collections.ObjectModel;
using System.ComponentModel;
using CollectionViewChallenge.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage, INotifyPropertyChanged
    {
        private int _selectedViewModelIndex = 0;
        public int SelectedViewModelIndex
        {
            get => _selectedViewModelIndex;
            set
            {
                _selectedViewModelIndex = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<StatisticsDetail> _stats = new ObservableCollection<StatisticsDetail>();
        public ObservableCollection<StatisticsDetail> Stats
        {
            get => _stats;
            set
            {
                _stats = value;
                OnPropertyChanged();
            }
        }

        public CollectionViewChallengePage()
        {
            InitializeComponent();

            Stats.Add(new StatisticsDetail()
            {
                DisplayValue = "24,5 km",
                DisplayDescription = "total distance"
            });
            Stats.Add(new StatisticsDetail()
            {
                DisplayValue = "27,1 km",
                DisplayDescription = "average speed"
            });

            BindingContext = this;
        }
    }
}