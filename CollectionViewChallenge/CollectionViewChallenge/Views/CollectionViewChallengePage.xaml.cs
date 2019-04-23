using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage, INotifyPropertyChanged
    {
        List<string> oCollectionViewPicker = new List<string> { "Empty List", "Filled List" };
        List<string> oCollectionViewEnabled = new List<string> { "Enable", "Disable" };
        List<string> oCollectionViewLayout = new List<string> { "Horizontal", "Vertical" };
        Dictionary<string, string> oCollectionViewDic;
        private ItemsLayoutOrientation _myProperty;

        public CollectionViewChallengePage()
        {
            try
            {
                InitializeComponent();
                CVPickerEnabled.ItemsSource = oCollectionViewEnabled;
                CVPickerLayout.ItemsSource = oCollectionViewLayout;
                CVPicker.ItemsSource = oCollectionViewPicker;
                AddItemsToList();
                FillCollectionView();
                AddItemsToScrollToPicker();
            }
            catch(Exception oExp)
            {

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ItemsLayoutOrientation GILOrientation
        {
            get
            {
                return _myProperty;
            }
            set
            {
                if (_myProperty != value)
                {
                    _myProperty = value;
                    OnPropertyChanged();
                }
            }
        }

        private void AddItemsToScrollToPicker()
        {
            try
            {
                List<string> oItems = new List<string>();
                oItems.Add("First Element");
                oItems.Add("Second Element");
                oItems.Add("Third Element");
                oItems.Add("Fourth Element");
                oItems.Add("Fifth Element");
                oItems.Add("Sixth Element");
                oItems.Add("Seventh Element");
                oItems.Add("Eigth Element");
                oItems.Add("Nineth Element");
                oItems.Add("Tenth Element");
                ScrollToPicker.ItemsSource = oItems;
            }
            catch(Exception oExp)
            {

            }
        }
        private void AddItemsToList()
        {
            try
            {
                oCollectionViewDic = new Dictionary<string, string>();
                oCollectionViewDic.Add("First Element", "tab_about.png");
                oCollectionViewDic.Add("Second Element", "tab_about.png");
                oCollectionViewDic.Add("Third Element", "tab_about.png");
                oCollectionViewDic.Add("Fourth Element", "tab_about.png");
                oCollectionViewDic.Add("Fifth Element", "tab_about.png");
                oCollectionViewDic.Add("Sixth Element", "tab_about.png");
                oCollectionViewDic.Add("Seventh Element", "tab_about.png");
                oCollectionViewDic.Add("Eigth Element", "tab_about.png");
                oCollectionViewDic.Add("Nineth Element", "tab_about.png");
                oCollectionViewDic.Add("Tenth Element", "tab_about.png");
            }
            catch(Exception oExp)
            {

            }
        }
        private void FillCollectionView()
        {
            try
            {
                List<ListViewElements> oElements = new List<ListViewElements>();
                foreach (var items in oCollectionViewDic)
                {
                    ListViewElements NewSectionItem =
                    new ListViewElements()
                    {
                        LVName = items.Key,
                        LVImage = items.Value
                    };
                    oElements.Add(NewSectionItem);
                }

                CollectionListViewH.ItemsSource = oElements;
                CollectionListViewV.ItemsSource = oElements;
            }
            catch(Exception oExp)
            {

            }
        }
        private void CVPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CollectionListViewH.ItemsSource != null && CVPicker.SelectedIndex == 0)
                {
                    CollectionListViewH.ItemsSource = null;
                    CollectionListViewV.ItemsSource = null;
                }
                else if (CVPicker.SelectedIndex == 1)
                {
                    AddItemsToList();
                    FillCollectionView();
                }
            }
            catch(Exception oExp)
            {

            }
        }

        private void CVPickerLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CollectionListViewH.ItemsSource != null)
                {
                    if (CVPickerLayout.SelectedIndex == 0)
                    {
                        CollectionListViewH.IsVisible = true;
                        CollectionListViewV.IsVisible = false;
                        ScrollToPicker.SelectedItem = null;
                        CVPickerEnabled.SelectedItem = null;
                    }
                    else if(CVPickerLayout.SelectedIndex == 1)
                    {
                        CollectionListViewH.IsVisible = false;
                        CollectionListViewV.IsVisible = true;
                        ScrollToPicker.SelectedItem = null;
                        CVPickerEnabled.SelectedItem = null;
                    }
                }
            }
            catch(Exception oExp)
            {

            }
        }

        private void CVPickedEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CollectionListViewH.ItemsSource != null)
                {
                    if (CVPickerEnabled.SelectedIndex == 0)
                    {
                        CollectionListViewH.IsEnabled = true;
                        CollectionListViewV.IsEnabled = true;
                    }
                    else if (CVPickerEnabled.SelectedIndex == 1)
                    {
                        CollectionListViewH.IsEnabled = false;
                        CollectionListViewV.IsEnabled = false;
                    }
                }
            }
            catch(Exception oExp)
            {

            }
        }

        private void CollectionListViewV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CollectionListViewH_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ScrollToPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CollectionListViewH.ItemsSource != null && CollectionListViewH.IsVisible)
            {
                List<ListViewElements> Items = (List<ListViewElements>)CollectionListViewH.ItemsSource;
                ListViewElements Selecteditem = Items.Select(x => x).Where(y => y.LVName == ScrollToPicker.SelectedItem.ToString()).FirstOrDefault();
                CollectionListViewH.ScrollTo(Selecteditem);
            }
            else if (CollectionListViewV.ItemsSource != null && CollectionListViewV.IsVisible)
            {
                List<ListViewElements> Items = (List<ListViewElements>)CollectionListViewV.ItemsSource;
                ListViewElements Selecteditem = Items.Select(x => x).Where(y => y.LVName == ScrollToPicker.SelectedItem.ToString()).FirstOrDefault();
                CollectionListViewV.ScrollTo(Selecteditem);
            }
        }
    }
    public class ListViewElements
    {
        public string LVName { get; set; }
        public string LVImage { get; set; }
    }
}
