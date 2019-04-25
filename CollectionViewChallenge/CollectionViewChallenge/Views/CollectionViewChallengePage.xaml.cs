using CollectionViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        public CollectionViewChallengePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<ListItem> listItems = new List<ListItem>();
            ListItem listItem = new ListItem() {Title="iPhone",Description="2GB RAM, 16GB Internal", Price="$500" ,Percentage="50%"};
            ListItem listItem1 = new ListItem() { Title = "iPhone", Description = "2GB RAM, 16GB Internal", Price = "$500", Percentage = "50%" };
            ListItem listItem2 = new ListItem() { Title = "iPhone", Description = "2GB RAM, 16GB Internal", Price = "$500", Percentage = "50%" };
            ListItem listItem3 = new ListItem() { Title = "iPhone", Description = "2GB RAM, 16GB Internal", Price = "$500", Percentage = "50%" };
            listItems.Add(listItem);
            listItems.Add(listItem1);
            listItems.Add(listItem2);
            listItems.Add(listItem3);
            collectionList.ItemsSource = listItems;
        }
    }
}