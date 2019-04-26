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
                DisplayDescription = "total distance",
                Icon = MaterialFontIcons.MapMarker
            });

            Stats.Add(new StatisticsDetail()
            {
                DisplayValue = "27,1 km",
                DisplayDescription = "average speed",
                Icon = MaterialFontIcons.Speedometer
            });

            Stats.Add(new StatisticsDetail()
            {
                DisplayValue = "43,5 km",
                DisplayDescription = "max speed",
                Icon = MaterialFontIcons.Speedometer
            });

            Stats.Add(new StatisticsDetail()
            {
                DisplayValue = "1h 13m",
                DisplayDescription = "moving time",
                Icon = MaterialFontIcons.Timer
            });

            Stats.Add(new StatisticsDetail()
            {
                DisplayValue = "124,0m",
                DisplayDescription = "elevation gain",
                Icon = MaterialFontIcons.ImageFilterHdr
            });

            Stats.Add(new StatisticsDetail()
            {
                DisplayValue = "146 bpm",
                DisplayDescription = "average heart rate",
                Icon = MaterialFontIcons.HeartOutline
            });

            BindingContext = this;
        }
    }
}