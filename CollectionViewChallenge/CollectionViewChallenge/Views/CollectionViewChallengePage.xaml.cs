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

        private ObservableCollection<KudosDetail> _kudos = new ObservableCollection<KudosDetail>();
        public ObservableCollection<KudosDetail> Kudos
        {
            get => _kudos;
            set
            {
                _kudos = value;
                OnPropertyChanged();
            }
        }

        public CollectionViewChallengePage()
        {
            InitializeComponent();

            #region Init data
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

            Kudos.Add(new KudosDetail() { Name = "Bart Lannoeye", Image = "http://dgalywyr863hv.cloudfront.net/pictures/athletes/9979653/3476575/1/medium.jpg" });
            Kudos.Add(new KudosDetail() { Name = "David Ortinau", Image = "http://dgalywyr863hv.cloudfront.net/pictures/athletes/1044152/247516/12/medium.jpg" });
            Kudos.Add(new KudosDetail() { Name = "Tim Heuer", Image = "http://dgalywyr863hv.cloudfront.net/pictures/athletes/5534914/1702130/2/medium.jpg" });
            Kudos.Add(new KudosDetail() { Name = "Jan Karger", Image = "http://dgalywyr863hv.cloudfront.net/pictures/athletes/6182165/1891567/5/medium.jpg" });
            Kudos.Add(new KudosDetail() { Name = "Jan Van de Poel", Image = "http://dgalywyr863hv.cloudfront.net/pictures/athletes/2327722/7025716/2/medium.jpg" });
            #endregion

            StatsView.IsVisible = true;
            //KudosView.IsVisible = false;
            //CommentsView.IsVisible = false;

            BindingContext = this;
        }
    }
}