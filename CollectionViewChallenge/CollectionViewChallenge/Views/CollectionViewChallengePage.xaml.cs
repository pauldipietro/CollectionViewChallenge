using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewChallenge.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {

        private ObservableCollection<Item> _items = new ObservableCollection<Item>();
        public ObservableCollection<Item> Items
        {
            get => _items;
            set => _items = value;
        }



        public CollectionViewChallengePage()
        {
            InitializeComponent();

            BindingContext = this;
            PopulateData();
        }


        private void PopulateData()
        {
            Items.Add(new Item
            {
                Id = "1",
                Name = "Bruno Caceiro",
                Team = "Xamarin",
                ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2017/04/monkey-MVP.png",
                Points = "1000"
            });
            Items.Add(new Item
            {
                Id = "2",
                Name = "Paul Di Pietro",
                Team = "Xamarin",
                ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2017/04/monkey-MVP.png",
                Points = "1000"
            });
            Items.Add(new Item
            {
                Id = "3",
                Name = "David Ortinau",
                Team = "Xamarin",
                ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2017/04/monkey-MVP.png",
                Points = "1000"
            });
            Items.Add(new Item
            {
                Id = "4",
                Name = "Bruno",
                Team = "Xamarin",
                ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2017/04/monkey-MVP.png",
                Points = "1000"
            });
            Items.Add(new Item
            {
                Id = "5",
                Name = "Bruno Caceiro",
                Team = "Xamarin",
                ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2017/04/monkey-MVP.png",
                Points = "1000"
            });
            Items.Add(new Item
            {
                Id = "6",
                Name = "Paul Di Pietro",
                Team = "Xamarin",
                ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2017/04/monkey-MVP.png",
                Points = "1000"
            });
            Items.Add(new Item
            {
                Id = "7",
                Name = "David Ortinau",
                Team = "Xamarin",
                ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2017/04/monkey-MVP.png",
                Points = "1000"
            });
            Items.Add(new Item
            {
                Id = "8",
                Name = "Xamarin Monkey",
                Team = "Xamarin",
                ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2017/04/monkey-MVP.png",
                Points = "1000"
            });
            Items.Add(new Item
            {
                Id = "9",
                Name = "Bruno",
                Team = "Xamarin",
                ImageUrl = "https://blog.xamarin.com/wp-content/uploads/2017/04/monkey-MVP.png",
                Points = "1000"
            });


        }


        }
    }