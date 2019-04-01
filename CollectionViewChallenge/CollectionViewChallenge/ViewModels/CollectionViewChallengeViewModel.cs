using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel : INotifyPropertyChanged
    {
        public CollectionViewChallengeViewModel()
        {
            Items.CollectionChanged += Items_CollectionChanged;
        }

        //Only needed for the ListViewComparisson to show the empty view
        private void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(ItemsExit));
            OnPropertyChanged(nameof(EmptyViewVisible));
        }

        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>
        {
            new Item{  Latitude = -37.5577513, Longitude = 145.215634, Radius  = 150, AlarmTime = new TimeSpan(8,0,0)},
            new Item{  Latitude = -37.52577513, Longitude = 144.215634, Radius  = 10, AlarmTime = new TimeSpan(9,0,0)},

        };

        public bool EmptyViewVisible
        {
            get
            {
                return Items.Count == 0;
            }
        }

        public bool ItemsExit
        {
            get
            {
                return Items.Count > 0;
            }
        }


        public System.Windows.Input.ICommand AddSubscriptionCommand
        {
            get
            {
                return new Xamarin.Forms.Command(() =>
                {
                    try
                    {
                        Items.Add(new Item { Latitude = -37.515955, Longitude = 145.232444, Radius = 10, AlarmTime = new TimeSpan(8, 0, 0) });
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Oject disposed exception here if you navigate to the ListView page then back to the CollectionViewPage and click add or delete. Android only, iOS is fine. CollectionViewOnly, listview is fine. \n{ex}\n{ex.StackTrace}");
                    }

                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
