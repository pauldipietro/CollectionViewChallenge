using CollectionViewChallenge.Models;
using CollectionViewChallenge.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewChallenge.ViewModels
{
	public class CVChallangeVM : INotifyPropertyChanged
	{
		public ObservableCollection<Pizza> NewPizza { get; set; }
		public ObservableCollection<Pizza> BestSellers { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		public CVChallangeVM()
		{
			NewPizza = new ObservableCollection<Pizza>(new[] {
				new Pizza { Name = "Crinkle Fries", ImagePath="https://l1.pizzainindia.com/themes/OLO_v2.1/images/deal/p-1.jpg"},
			new Pizza { Name = "Crunchy Strip", ImagePath="https://l1.pizzainindia.com/themes/OLO_v2.1/images/deal/p-2.jpg"},
			new Pizza { Name = "Crunchy Strip", ImagePath="https://l1.pizzainindia.com/themes/OLO_v2.1/images/deal/p-3.jpg"},
			new Pizza { Name = "Crunchy Strip", ImagePath="https://l1.pizzainindia.com/themes/OLO_v2.1/images/deal/p-4.jpg"}
			});


			BestSellers = new ObservableCollection<Pizza>(new[] {
				new Pizza { Name = "Peri Peri Chicken", ImagePath="https://l1.pizzainindia.com/assets/osc/ABAAA/images/products/originals/AfricanPeriPeriVegNonVeg.jpg"},
			new Pizza { Name = "Barbecue Chicken", ImagePath="https://l1.pizzainindia.com/assets/osc/ABAAA/images/products/originals/AussieBarbequeNonVeg.jpg"},
			new Pizza { Name = "Jerk Chicken", ImagePath="https://l1.pizzainindia.com/assets/osc/ABAAA/images/products/originals/JamaicanJerkNonVeg.jpg"},
			new Pizza { Name = "Chicken Tikka", ImagePath="https://l1.pizzainindia.com/assets/osc/ABAAA/images/products/originals/IndianTandooriChickenTikka.jpg"}
			});

			//HomePage = new Command(async () => await HomePageFunc());
			//MenuPage = new Command(async() => await MenuPageFunc());
		}

		//public ICommand HomePage { private set; get; }

		//public async Task HomePageFunc()
		//{
		//	await Navigation.PushModalAsync(new HomePage());
		//}

		//public ICommand MenuPage { private set; get; }

		//public async Task MenuPageFunc()
		//{
		//}
	}
}
