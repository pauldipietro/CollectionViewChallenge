using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewChallenge.Models
{
    public class Item
    {
        public double Latitude {get;set;}
        public double Longitude {get;set;}
        public int Radius {get;set;}
        public TimeSpan AlarmTime {get;set;}

        public ICommand DeleteCommand
        {
            get
            {
                return new Xamarin.Forms.Command((object sender) =>
                {
                    try
                    {
                        var view = sender as CollectionView;
                        if (view != null)
                        {
                            var items = view.ItemsSource as ObservableCollection<Item>;
                            items.Remove(this);
                        }
                        else
                        {
                            var list = sender as ListView;
                            if (list != null)
                            {
                                var items = list.ItemsSource as ObservableCollection<Item>;
                                items.Remove(this);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Oject disposed exception here if you navigate to the ListView page then back to the CollectionViewPage and click add or delete. Android only, iOS is fine. CollectionViewOnly, listview is fine. \n{ex}\n{ex.StackTrace}");
                    }
                });
            }
        }

        public ICommand EditCommand
        {
            get
            {
                return new Xamarin.Forms.Command((object collection) =>
                {
                    Shell.CurrentShell.DisplayAlert("Not implemented", "Edit not implemented in this demo", "Okay");
                });
            }
        }
    }
}