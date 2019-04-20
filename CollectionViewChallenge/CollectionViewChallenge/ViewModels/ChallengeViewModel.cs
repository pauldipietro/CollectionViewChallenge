using System;
using System.Collections.ObjectModel;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.ViewModels
{
    public class ChallengeViewModel : BaseViewModel
    {
        private ObservableCollection<Product> products = new ObservableCollection<Product>();

        public ChallengeViewModel()
        {
            IsBusy = true;
            LoadProducts();
            IsBusy = false;
        }

        private void LoadProducts()
        {
            Products.Add(new Product()
            {
                Selected = false,
                Name = "CERVEJA SKOL 350 ML",
                Code = "7891149200504",
                Photo = "https://cdn-cosmos.bluesoft.com.br/products/7891149200504"
            });

            Products.Add(new Product()
            {
                Selected = true,
                Name = "CERVEJA PALE LAGER 330ML HEINEKEN",
                Code = "78936683",
                Photo = "https://cdn-cosmos.bluesoft.com.br/products/78936683"
            });

            Products.Add(new Product()
            {
                Selected = false,
                Name = "CERVEJA BRAHMA",
                Code = "7891149010509",
                Photo = "https://cdn-cosmos.bluesoft.com.br/products/7891149010509"
            });

            Products.Add(new Product()
            {
                Selected = false,
                Name = "SKOL PILSEN LATA 1 UNIDADE",
                Code = "7891149103102",
                Photo = "https://cdn-cosmos.bluesoft.com.br/products/7891149103102"
            });

            Products.Add(new Product()
            {
                Selected = false,
                Name = "CERVEJA STELLA ARTOIS",
                Code = "7891149101900",
                Photo = "https://cdn-cosmos.bluesoft.com.br/products/7891149101900"
            });

            Products.Add(new Product()
            {
                Selected = true,
                Name = "ITAIPAVA PILSEN LATA 1 UNIDADE",
                Code = "7897395020101",
                Photo = "https://cdn-cosmos.bluesoft.com.br/products/7897395020101"
            });


            Products.Add(new Product()
            {
                Selected = true,
                Name = "CERVEJA COLÔNIA PILSEN LATA",
                Code = "7898032910120",
                Photo = "https://cdn-cosmos.bluesoft.com.br/products/7898032910120"
            });

            Products.Add(new Product()
            {
                Selected = false,
                Name = "PETRA SCHWARZBIER ESCURA PREMIUM LATA 1 UNIDADE",
                Code = "7897395020644",
                Photo = "https://cdn-cosmos.bluesoft.com.br/products/7897395020644"
            });

            Products.Add(new Product()
            {
                Selected = false,
                Name = "KAISER RADLER FRUIT BEER LATA 1 UNIDADE",
                Code = "7896045504343",
                Photo = "https://cdn-cosmos.bluesoft.com.br/products/kaiser-radler-fruit-beer-lata-350-ml-1-unidade_600x600-PU87ea7_1.jpg"
            });

            Products.Add(new Product()
            {
                Selected = true,
                Name = "BEER XX LAGER ESPECIAL",
                Code = "75005719",
                Photo = "https://cdn-cosmos.bluesoft.com.br/products/75005719"
            });
        }

        public ObservableCollection<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
             }
        }
    }
}
