using System;
using System.Collections.ObjectModel;
using CollectionViewChallenge.Models;
using CollectionViewChallenge.ViewModels.Base;
using Microcharts;
using SkiaSharp;
using Entry = Microcharts.Entry;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel : BaseViewModel
    {
        private ObservableCollection<Entry> _items;
        private Entry _selectedItem;
        private Day _selectedDay;

        public ObservableCollection<Entry> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        public Entry SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;

                // Creando un servicio de navegación
                //NavigationService.NavigateToAsync<XamagramItemDetailViewModel>(_selectedItem);
            }
        }

        private ObservableCollection<Day> _days;

        public ObservableCollection<Day> Days
        {
            get { return _days; }
            set
            {
                _days = value;
                OnPropertyChanged("Items");
            }
        }

        public Day SelectedDay
        {
            get { return _selectedDay; }
            set
            {
                _selectedDay = value;


                // Creando un servicio de navegación
                //NavigationService.NavigateToAsync<XamagramItemDetailViewModel>(_selectedItem);
            }
        }

        private ObservableCollection<ChartType> _charts;

        public ObservableCollection<ChartType> Charts
        {
            get { return _charts; }
            set
            {
                _charts = value;
                OnPropertyChanged("Charts");
            }
        }

        public ObservableCollection<Person> People { get; set; }

        public CollectionViewChallengeViewModel()
        {
            IsBusy = true;

            Items = new ObservableCollection<Entry>
            {
                new Entry(200) {Label = "January", ValueLabel = "200",  Color = SKColor.Parse("#266489") },
                new Entry(400) {Label = "February", ValueLabel = "400",  Color = SKColor.Parse("#68B9C0") },
                new Entry(-100) {Label = "March", ValueLabel = "-100",  Color = SKColor.Parse("#90D585") },
                new Entry(100) {Label = "April", ValueLabel = "100",  Color = SKColor.Parse("#ba85d5") }
            };

            int daysInMonth = System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            Days = new ObservableCollection<Day>();

            for (int i = 1; i <= daysInMonth; i++)
            {
                DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, i);
                var myday = new Day()
                {
                    Id = i.ToString(),
                    DayName = dt.ToString("ddd").ToUpper(),
                    MonthName = dt.ToString("MMM").ToUpper()
                };

                Days.Add(myday);

                if (myday.Id == DateTime.Now.Day.ToString())
                {
                    SelectedDay = myday;
                }
            }

            Charts = new ObservableCollection<ChartType>
            {
                new ChartType() {Id="1" , ChartItem = LineChartType },
                new ChartType() {Id="2" , ChartItem = BarChartType},
                new ChartType() {Id="3" , ChartItem = RadarChartType },
                new ChartType() {Id="4" , ChartItem = PointChartType},
                new ChartType() {Id="5" , ChartItem = RadialGaugeType },
                new ChartType() {Id="6" , ChartItem = DonutType},
            };

            People = new ObservableCollection<Person>
             {
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/54.jpg", FirstName = "Jon", LastName="Coleman" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/50.jpg", FirstName = "Vernon", LastName="Walters" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/women/54.jpg", FirstName = "Beverley", LastName="Sutton" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/women/69.jpg", FirstName = "Scarlet", LastName="Kingsley" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/36.jpg", FirstName = "Everett", LastName="Riley" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/57.jpg", FirstName = "Lenny", LastName="Rodrigues" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/women/29.jpg", FirstName = "Addlynne", LastName="Fowler" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/women/44.jpg", FirstName = "Nicole", LastName="Jennings" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/11.jpg", FirstName = "Ole", LastName="Solksjaer" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/women/90.jpg", FirstName = "Avery", LastName="Burke" },
                new Person(){Avatar = "https://randomuser.me/api/portraits/men/6.jpg", FirstName = "Lionel", LastName="Murphy" }
            };

            IsBusy = false;
        }

        public Chart LineChartType => new LineChart()
        {
            Entries = Items,
            LabelTextSize = 10
        };

        public Chart BarChartType => new BarChart()
        {
            Entries = Items,
            LabelTextSize = 20
        };

        public Chart RadarChartType => new RadarChart()
        {
            Entries = Items,
            LabelTextSize = 20,
            Margin = 20
        };

        public Chart PointChartType => new PointChart()
        {
            Entries = Items,
            LabelTextSize = 20,
            Margin = 20
        };

        public Chart RadialGaugeType => new RadialGaugeChart()
        {
            Entries = Items,
            LabelTextSize = 20,
            Margin = 20
        };

        public Chart DonutType => new DonutChart()
        {
            Entries = Items,
            LabelTextSize = 20,
            Margin = 20
        };
    }
}
