using CollectionViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewChallenge.Services
{
    public class MarvelService : IMarvelService<Character>
    {
        private List<Character> characters;

        public MarvelService()
        {
            characters = new List<Character>();
            var mockItems = new List<Character>
            {
                new Character {
                    Id = "1009220",
                    Name = "Captain America",
                    Description ="Vowing to serve his country any way he could, young Steve Rogers took the super soldier serum to become America's one-man army. Fighting for the red, white and blue for over 60 years, Captain America is the living, breathing symbol of freedom and liberty.",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/3/50/537ba56d31087.jpg"
                },

                new Character {
                    Id = "1009368",
                    Name = "Iron Man",
                    Description ="Wounded, captured and forced to build a weapon by his enemies, billionaire industrialist Tony Stark instead created an advanced suit of armor to save his life and escape captivity. Now with a new outlook on life, Tony uses his money and intelligence to make the world a safer, better place as Iron Man.",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/9/c0/527bb7b37ff55.jpg"
                },
            };

            foreach (var item in mockItems)
            {
                characters.Add(item);
            }
        }
        public async Task<Character> GetCharacterAsync(string id)
        {
            return await Task.FromResult(characters.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Character>> GetCharactersAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(characters);
        }
    }
}
