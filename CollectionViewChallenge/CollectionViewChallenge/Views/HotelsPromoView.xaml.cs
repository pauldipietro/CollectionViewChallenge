using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotelsPromoView : ContentPage
    {
        public static ObservableCollection<HotelsLv> items = new ObservableCollection<HotelsLv>()
            {
                new HotelsLv()
        {
            Id = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now.ToString("G"),
                    Name = "Kempinski Hotel CA",
                    Description = "Hotel in California",
                    StarsNumber = "2Stars",
                    Latitude = "36.568151624528966",
                    Longitude = "-119.50030705930174",
                    Email = "kempinski@hotel.com",
                    Phone = "16259",
                    Web = "www.kempinski.com",
                    Image = "https://ihg.scene7.com/is/image/ihg/even-hotels-eugene-5405616297-4x3",
                    Rating = "85",
                    BestDiscount = "30",
                    RoomPrice = "1098"
                },
                new HotelsLv()
        {
            Id = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now.ToString("G"),
                    Name = "Aston Hotel San Francisco",
                    Description = "Hotel in San francisco",
                    StarsNumber = "3Stars",
                    Latitude = "-34.7382",
                    Longitude = "-58.50450",
                    Email = "aston@hotel.com",
                    Phone = "3444",
                    Web = "www.aston.com",
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/0d/7f/48/0a/dublin-s-newest-hotel.jpg",
                    Rating = "90",
                    BestDiscount = "40",
                    RoomPrice = "1098"
                },
                new HotelsLv()
        {
            Id = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now.ToString("G"),
                    Name = "Pear Tree Hotel",
                    Description = "Hotel in UK",
                    StarsNumber = "3Stars",
                    Latitude = "52.8996801",
                    Longitude = "-1.477368",
                    Email = "pear@hotel.com",
                    Phone = "16259",
                    Web = "www.pear.com",
                    Image = "https://q-ec.bstatic.com/images/hotel/max1280x900/101/101430248.jpg",
                    Rating = "90",
                    BestDiscount = "40",
                    RoomPrice = "1098"
                },
                new HotelsLv()
        {
            Id = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now.ToString("G"),
                    Name = "Hilton Hotel & Resort",
                    Description = "Hotel in India",
                    StarsNumber = "4Stars",
                    Latitude = "15.4967",
                    Longitude = "73.88409999999999",
                    Email = "hilton@hotel.com",
                    Phone = "16259",
                    Web = "www.hilton.com",
                    Image = "http://ihg.scene7.com/is/image/ihg/holiday-inn-wichita-3912056013-4x3",
                    Rating = "90",
                    BestDiscount = "40",
                    RoomPrice = "1098"
                }
    };
        public HotelsPromoView()
        {
            try
            {
                InitializeComponent();
                CV.ItemsSource = items;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error "+ex.Message);
            }
        }
    }
    public class HotelsLv
    {
        public string Id { get; set; }
        public string CreatedAt { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StarsNumber { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Web { get; set; }
        public string Image { get; set; }
        public string Rating { get; set; }
        public string BestDiscount { get; set; }
        public string RoomPrice { get; set; }
    }
}