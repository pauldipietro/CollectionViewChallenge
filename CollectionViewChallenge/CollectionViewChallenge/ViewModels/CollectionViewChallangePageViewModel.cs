using System;
using System.Collections.ObjectModel;
using CollectionViewChallenge.Models;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallangePageViewModel
    {
        public ObservableCollection<Promocao> Promocoes { get; set; }
        public ObservableCollection<Categoria> Categorias { get; set; }
        public ObservableCollection<Restaurante> Restaurantes { get; set; }
        public ObservableCollection<Restaurante> UltimosRestaurantes { get; set; }

        public CollectionViewChallangePageViewModel()
        {
            Promocoes = new ObservableCollection<Promocao>()
            {
                new Promocao(@"Opções a partir de R$10 sem taxas", "promo1.png"),
                new Promocao(@"Cortesia do restaurante para você", "promo2.png"),
                new Promocao(@"Populares perto de você", "promo1.png"),
                new Promocao(@"Pra comer leve e gostoso", "promo2.png"),
                new Promocao(@"Delicia pra refrescar", "promo1.png")
            };

            Categorias = new ObservableCollection<Categoria>()
            {
                new Categoria("Brasileira", "http://lorempixel.com/output/food-q-c-270-200-2.jpg"),
                new Categoria("Lanche", "http://lorempixel.com/output/food-q-c-270-200-9.jpg"),
                new Categoria("Saudável", "http://lorempixel.com/output/food-q-c-270-200-5.jpg"),
                new Categoria("Chinesa", "http://lorempixel.com/output/food-q-c-270-200-1.jpg"),
                new Categoria("Japonesa", "http://lorempixel.com/output/food-q-c-270-200-4.jpg"),
                new Categoria("Italiana", "http://lorempixel.com/output/food-q-c-270-200-3.jpg")
            };

            Restaurantes = new ObservableCollection<Restaurante>()
            {
                new Restaurante("Habibs", "https://www.gad.com.br/wp-content/uploads/2018/09/small_S_L_cmyk_neg_logo.png"),
                new Restaurante("Mc Donalds", "http://imagensemoldes.com.br/wp-content/uploads/2018/03/Mc-Donald%C2%B4s-Logo-Vetor-PNG-300x233.png"),
                new Restaurante("Burguer King", "https://upload.wikimedia.org/wikipedia/pt/thumb/c/cf/Logotipo_do_Burger_King.svg/1024px-Logotipo_do_Burger_King.svg.png"),
                new Restaurante("Pizza Hut", "http://viagemdeincentivo.com.br/wp-content/uploads/2014/07/logo-pizza-hut.png"),
                new Restaurante("Bobs", "https://viacafegardenshopping.com.br/wp-content/uploads/2015/11/Bobs-Logo.jpg")
            };
        }
    }
}
