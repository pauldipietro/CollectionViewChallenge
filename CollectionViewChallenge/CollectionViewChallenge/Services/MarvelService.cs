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

                new Character {
                    Id = "1009189",
                    Name = "Black Widow",
                    Description ="",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/f/30/50fecad1f395b.jpg"
                },

                new Character {
                    Id = "1009351",
                    Name = "Hulk",
                    Description ="Caught in a gamma bomb explosion while trying to save the life of a teenager, Dr. Bruce Banner was transformed into the incredibly powerful creature called the Hulk. An all too often misunderstood hero, the angrier the Hulk gets, the stronger the Hulk gets.",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/5/a0/538615ca33ab0.jpg"
                },

                new Character {
                    Id = "1009368",
                    Name = "Spider-Man",
                    Description ="Bitten by a radioactive spider, high school student Peter Parker gained the speed, strength and powers of a spider. Adopting the name Spider-Man, Peter hoped to start a career using his new abilities. Taught that with great power comes great responsibility, Spidey has vowed to use his powers to help people.",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/3/50/526548a343e4b.jpg"
                },

                new Character {
                    Id = "1009282",
                    Name = "Doctor Strange",
                    Description ="",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/5/f0/5261a85a501fe.jpg"
                },

                new Character {
                    Id = "1009338",
                    Name = "Hawkeye",
                    Description ="",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/e/90/50fecaf4f101b.jpg"
                },

                new Character {
                    Id = "1009652",
                    Name = "Thanos",
                    Description ="The Mad Titan Thanos, a melancholy, brooding individual, consumed with the concept of death, sought out personal power and increased strength, endowing himself with cybernetic implants until he became more powerful than any of his brethren.",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/6/40/5274137e3e2cd.jpg"
                },

                new Character{
                    Id = "1009685",
                    Name = "Ultron",
                    Description = "Arguably the greatest and certainly the most horrific creation of scientific genius Dr. Henry Pym, Ultron is a criminally insane rogue sentient robot dedicated to conquest and the extermination of humanity.",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/3/70/5261a838e93c0.jpg"
                },

                new Character{
                    Id = "1009187",
                    Name = "Black Panther",
                    Description = "",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/6/60/5261a80a67e7d.jpg"
                },

                new Character{
                    Id = "1010338",
                    Name = "Captain Marvel (Carol Danvers)",
                    Description = "",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/6/80/5269608c1be7a.jpg"
                },

                new Character{
                    Id = "1009664",
                    Name = "Thor",
                    Description = "As the Norse God of thunder and lightning, Thor wields one of the greatest weapons ever made, the enchanted hammer Mjolnir. While others have described Thor as an over-muscled, oafish imbecile, he's quite smart and compassionate.  He's self-assured, and he would never, ever stop fighting for a worthwhile cause.",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/d/d0/5269657a74350.jpg"
                },

                new Character{
                    Id = "1009407",
                    Name = "Loki",
                    Description = "",
                    UrlImage = "http://i.annihil.us/u/prod/marvel/i/mg/d/90/526547f509313.jpg"
                }
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
