using System.Collections.ObjectModel;
using CollectionViewChallenge.Models;
using Newtonsoft.Json;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel : BaseViewModel
    {
        private ObservableCollection<Character> _characters;

        public ObservableCollection<Character> Characters
        {
            get { return _characters; }
            set { SetProperty(ref _characters, value); }
        }


        public CollectionViewChallengeViewModel()
        {
            Characters = new ObservableCollection<Character>
            {
                new Character
                {
                    Name = "A-Bomb (HAS)",
                    Description = "Rick Jones has been Hulk's best bud since day one, but now he's more than a friend...he's a teammate! Transformed by a Gamma energy explosion, A-Bomb's thick, armored skin is just as strong and powerful as it is blue. And when he curls into action, he uses it like a giant bowling ball of destruction!",
                    Path = "https://i.annihil.us/u/prod/marvel/i/mg/3/20/5232158de5b16.jpg"
                },
                new Character
                {
                    Name = "Alpha Flight",
                    Description = "",
                    Path = "https://i.annihil.us/u/prod/marvel/i/mg/1/60/52695277ee088.jpg"
                },
                new Character
                {
                    Name = "Avengers",
                    Description = "Earth's Mightiest Heroes joined forces to take on threats that were too big for any one hero to tackle. With a roster that has included Captain America, Iron Man, Ant-Man, Hulk, Thor, Wasp and dozens more over the years, the Avengers have come to be regarded as Earth's No. 1 team.",
                    Path = "https://i.annihil.us/u/prod/marvel/i/mg/9/20/5102c774ebae7.jpg"
                },
                new Character
                {
                    Name = "Angel (Ultimate)",
                    Description = "",
                    Path = "https://i.annihil.us/u/prod/marvel/i/mg/4/50/531769ae4399f.jpg"
                },                
                new Character
                {
                    Name = "Spider-Man",
                    Description = "Bitten by a radioactive spider, high school student Peter Parker gained the speed, strength and powers of a spider. Adopting the name Spider-Man, Peter hoped to start a career using his new abilities. Taught that with great power comes great responsibility, Spidey has vowed to use his powers to help people.",
                    Path = "https://i.annihil.us/u/prod/marvel/i/mg/3/50/526548a343e4b.jpg"
                },
                new Character
                {
                    Name = "Thor",
                    Description = "As the Norse God of thunder and lightning, Thor wields one of the greatest weapons ever made, the enchanted hammer Mjolnir. While others have described Thor as an over-muscled, oafish imbecile, he's quite smart and compassionate.  He's self-assured, and he would never, ever stop fighting for a worthwhile cause.",
                    Path = "https://i.annihil.us/u/prod/marvel/i/mg/d/d0/5269657a74350.jpg"
                },
                new Character
                {
                    Name = "Iron Man",
                    Description = "Wounded, captured and forced to build a weapon by his enemies, billionaire industrialist Tony Stark instead created an advanced suit of armor to save his life and escape captivity. Now with a new outlook on life, Tony uses his money and intelligence to make the world a safer, better place as Iron Man.",
                    Path = "https://i.annihil.us/u/prod/marvel/i/mg/9/c0/527bb7b37ff55.jpg"
                },
                new Character
                {
                    Name = "Hulk",
                    Description = "Caught in a gamma bomb explosion while trying to save the life of a teenager, Dr. Bruce Banner was transformed into the incredibly powerful creature called the Hulk. An all too often misunderstood hero, the angrier the Hulk gets, the stronger the Hulk gets.",
                    Path = "https://i.annihil.us/u/prod/marvel/i/mg/5/a0/538615ca33ab0.jpg"
                },
                new Character
                {
                    Name = "Apocalypse",
                    Description = "",
                    Path = "https://i.annihil.us/u/prod/marvel/i/mg/f/e0/526166076a1d0.jpg"
                }
            };
        }
    }
}
