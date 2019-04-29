using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using CollectionViewChallenge.Models;
using CollectionViewChallenge.Services;
using Xamarin.Forms;

namespace CollectionViewChallenge.ViewModels
{
    public class PokemonViewModel : INotifyPropertyChanged
    {
        private List<Pokemon> Pokedex;

        private ObservableCollection<Pokemon> pokemons;

        public ObservableCollection<Pokemon> PokemonList
        {
            get { return pokemons; }
            set { pokemons = value; OnPropertyChanged(); }
        }

        public async Task LoadPokedex()
        {
            IsLoading = true;

            Pokedex = await PokemonApiService.GetPokemon();
            PokemonList = new ObservableCollection<Pokemon>(Pokedex);

            IsLoading = false;
        }

        private bool isLoading;

        public bool IsLoading
        {
            get { return isLoading; }
            set { isLoading = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // New code
        private ObservableCollection<Pokemon> icePokemonList;

        public ObservableCollection<Pokemon> IcePokemonList
        {
            get { return icePokemonList; }
            set { icePokemonList = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Pokemon> darkPokemonList;

        public ObservableCollection<Pokemon> DarkPokemonList
        {
            get { return darkPokemonList; }
            set { darkPokemonList = value; OnPropertyChanged(); }
        }

        public async Task LoadIceDarkPokedex()
        {
            IsLoading = true;

            Pokedex = await PokemonApiService.GetPokemon();
            //PokemonList = new ObservableCollection<Pokemon>(Pokedex);

            IcePokemonList = new ObservableCollection<Pokemon>(Pokedex.Where(x => x.Types.Contains("Ice")));
            DarkPokemonList = new ObservableCollection<Pokemon>(Pokedex.Where(x => x.Types.Contains("Dark")));

            IsLoading = false;
        }

        public ICommand SearchPokemonCommand => new Command<string>(SearchPokemon);




        public Pokemon SearchScrollPokemon(string pokemon)
        {
            if (!string.IsNullOrWhiteSpace(pokemon))
            {
                var results = Pokedex.Where(x => x.name.english.ToLower().Contains(pokemon.ToLower()));
                return results.FirstOrDefault();
            }

            return PokemonList.First();
        }

        public void SearchPokemon(string pokemon)
        {
            if (!string.IsNullOrWhiteSpace(pokemon))
            {
                var results = Pokedex.Where(x => x.name.english.ToLower().Contains(pokemon.ToLower()));

                PokemonList = (results.Count() > 0)
                    ? new ObservableCollection<Pokemon>(results)
                    : new ObservableCollection<Pokemon>();
            }
            else
            {
                PokemonList = new ObservableCollection<Pokemon>(Pokedex);
            }
        }
    }
}