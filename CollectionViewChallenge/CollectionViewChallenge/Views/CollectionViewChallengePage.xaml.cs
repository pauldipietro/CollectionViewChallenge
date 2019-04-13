using CollectionViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        ObservableCollection<Event> obsEvents = new ObservableCollection<Event>();

        public CollectionViewChallengePage()
        {
            InitializeComponent();
            LoadCollectionView();
            cvEvents.SelectionChanged += CvEvents_SelectionChanged;
        }

        private void CvEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var eventItem = (e.CurrentSelection.FirstOrDefault() as Event);

            if (eventItem is null)
                return;

            //Hack to reflect the DropDownVisible changes on selected item
            var iSelectedIndex = obsEvents.IndexOf(eventItem);
            obsEvents.Remove(eventItem);
            eventItem.DropDownVisible = !eventItem.DropDownVisible;
            obsEvents.Insert(iSelectedIndex, eventItem);

            //This is required when expanded item is selected again, it should be collapsed
            ((CollectionView)sender).SelectedItem = null;
        }

        private void LoadCollectionView()
        {
            var lstEvents = new List<Event>();
            for (var i = 1; i <= 20; i++)
            {
                lstEvents.Add(new Event() { ID = i, Title = "Phasellus ultrices nulla quis nibh", Description = "placerat", StartDate = DateTime.Now, EndDate = DateTime.Now, SubmittedOn = DateTime.Now, Points = 2 });
            }
            obsEvents = new ObservableCollection<Event>(lstEvents);
            cvEvents.ItemsSource = obsEvents;
        }
    }
}