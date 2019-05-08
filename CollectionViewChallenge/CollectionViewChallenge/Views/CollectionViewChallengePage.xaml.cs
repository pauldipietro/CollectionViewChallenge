using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicData;
using DynamicData.Binding;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
		public IObservableCollection<ViewModel> Data { get; } = new ObservableCollectionExtended<ViewModel>();
		SourceList<ViewModel> List = new SourceList<ViewModel>();

		public CollectionViewChallengePage()
        {
            InitializeComponent();

			List.AddRange(Enumerable.Range(0, 1000).Select(x => new ViewModel()));
			List.Connect().Bind(Data).DisposeMany().Subscribe();

			BindingContext = this;
		}

		void OnClearClicked(object sender, EventArgs e)
		{
			// verify that PropertyChanged interface works
			Data.PropertyChanged += (sn, ev) =>
			{
				Console.WriteLine("Data changed");
			};

			List.Clear();		
		}

		void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (e.CurrentSelection.Count == 0)
				return;

			var item = e.CurrentSelection.FirstOrDefault() as ViewModel;
			item.Toggle();
			var colView = sender as CollectionView;
			UpdateSelection(colView, item);
		}

		async void UpdateSelection(CollectionView colView, ViewModel item)
		{
			TBUpdating.Text = "Updating Selection ...";

			await Task.Delay(1000); // make scroll action visible
			colView.ScrollTo(item, position: ScrollToPosition.Center);
			colView.SelectedItem = null;

			TBUpdating.Text = String.Empty;
		}
	}
}