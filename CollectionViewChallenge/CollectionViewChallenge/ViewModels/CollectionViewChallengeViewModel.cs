using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using CollectionViewChallenge.Models;
using Xamarin.Forms;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel
    {
        public ICommand ItemTappedCommand => new Command<Movie>(async (item) => await OnMovieTappedAsync(item));
        public ObservableCollection<Movie> Movies { get; set; }

        public CollectionViewChallengeViewModel()
        {
            #region MockItems
            Movies = new ObservableCollection<Movie>
            {
                new Movie
                {
                  VoteCount = 175,
                  Id = 299534,
                  Video = false,
                  VoteAverage = 8.2,
                  Title = "Avengers: Endgame",
                  Popularity = 437.513,
                  PosterPath = "https://image.tmdb.org/t/p/original/or06FN3Dka5tukK1e9sl16pB3iy.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Avengers: Endgame",
                  BackdropPath = "https://image.tmdb.org/t/p/original/7RyHsO4yDXtBv1zUU3mTpHeQ0d5.jpg",
                  Adult = false,
                  Overview = "After the devastating events of Avengers: Infinity War, the universe is in ruins due to the efforts of the Mad Titan, Thanos. With the help of remaining allies, the Avengers must assemble once more in order to undo Thanos' actions and restore order to the universe once and for all, no matter what consequences may be in store.",
                  ReleaseDate = "2019-04-24"
                },
                new Movie
                {
                            VoteCount = 222,
                  Id = 456740,
                  Video = false,
                  VoteAverage = 5.3,
                  Title = "Hellboy",
                  Popularity = 321.833,
                  PosterPath = "https://image.tmdb.org/t/p/original/bk8LyaMqUtaQ9hUShuvFznQYQKR.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Hellboy",
                  BackdropPath = "https://image.tmdb.org/t/p/original/5BkSkNtfrnTuKOtTaZhl8avn4wU.jpg",
                  Adult = false,
                  Overview = "Hellboy comes to England, where he must defeat Nimue, Merlin's consort and the Blood Queen. But their battle will bring about the end of the world, a fate he desperately tries to turn away.",
                  ReleaseDate = "2019-04-10"
                },
                new Movie
                {
                  VoteCount = 497,
                  Id = 537915,
                  Video = false,
                  VoteAverage = 6.5,
                  Title = "After",
                  Popularity = 262.288,
                  PosterPath = "https://image.tmdb.org/t/p/original/u3B2YKUjWABcxXZ6Nm9h10hLUbh.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "After",
                  BackdropPath = "https://image.tmdb.org/t/p/original/8lESY7UGpOsbL2caib9Qe4bOebF.jpg",
                  Adult = false,
                  Overview = "A young woman falls for a guy with a dark secret and the two embark on a rocky relationship.",
                  ReleaseDate = "2019-04-11"
                },
                new Movie
                {
                  VoteCount = 106,
                  Id = 480414,
                  Video = false,
                  VoteAverage = 5.7,
                  Title = "The Curse of La Llorona",
                  Popularity = 149.833,
                  PosterPath = "https://image.tmdb.org/t/p/original/jhZlXSnFUpNiLAek9EkPrtLEWQI.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "The Curse of La Llorona",
                  BackdropPath = "https://image.tmdb.org/t/p/original/u2vGggeMPAkhEtD7bYGfeThsQiM.jpg",
                  Adult = false,
                  Overview = "A social worker dealing with the disappearance of two children fears for her own family after beginning the investigation.",
                  ReleaseDate = "2019-04-17"
                },
                new Movie
                {
                  VoteCount = 148,
                  Id = 487297,
                  Video = false,
                  VoteAverage = 5.6,
                  Title = "What Men Want",
                  Popularity = 128.248,
                  PosterPath = "https://image.tmdb.org/t/p/original/30IiwvIRqPGjUV0bxJkZfnSiCL.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "What Men Want",
                  BackdropPath = "https://image.tmdb.org/t/p/original/umecegsPpKr2ZXA62Da9CQBVoIO.jpg",
                  Adult = false,
                  Overview = "Magically able to hear what men are thinking, a sports agent uses her newfound ability to turn the tables on her overbearing male colleagues.",
                  ReleaseDate = "2019-02-08"
                },
                new Movie
                {
                  VoteCount = 53,
                  Id = 376865,
                  Video = false,
                  VoteAverage = 6.2,
                  Title = "High Life",
                  Popularity = 78.17,
                  PosterPath = "https://image.tmdb.org/t/p/original/wElOvH7H6sLElsTOLu1MY6oWRUx.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "High Life",
                  BackdropPath = "https://image.tmdb.org/t/p/original/6gHdAO1Lvk9bjzhY4hX3wVRkAhF.jpg",
                  Adult = false,
                  Overview = "Monte and his baby daughter are the last survivors of a damned and dangerous mission to the outer reaches of the solar system. They must now rely on each other to survive as they hurtle toward the oblivion of a black hole.",
                  ReleaseDate = "2018-11-07"
                },
                new Movie
                {
                  VoteCount = 64,
                  Id = 411728,
                  Video = false,
                  VoteAverage = 7.2,
                  Title = "The Professor and the Madman",
                  Popularity = 63.248,
                  PosterPath = "https://image.tmdb.org/t/p/original/gtGCDLhfjW96qVarwctnuTpGOtD.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "The Professor and the Madman",
                  BackdropPath = "https://image.tmdb.org/t/p/original/zhNfM1CSQqJtIqelwlK9iKtSd9P.jpg",
                  Adult = false,
                  Overview = "Professor James Murray begins work compiling words for the first edition of the Oxford English Dictionary in the mid 19th century and receives over 10,000 entries from a patient at Broadmoor Criminal Lunatic Asylum , Dr William Minor.",
                  ReleaseDate = "2019-03-07"
                },
                new Movie
                {
                  VoteCount = 300,
                  Id = 157433,
                  Video = false,
                  VoteAverage = 5.9,
                  Title = "Pet Sematary",
                  Popularity = 55.133,
                  PosterPath = "https://image.tmdb.org/t/p/original/7SPhr7Qj39vbnfF9O2qHRYaKHAL.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Pet Sematary",
                  BackdropPath = "https://image.tmdb.org/t/p/original/n2aX63BmW7zIKgKJ58e6rKlSsdi.jpg",
                  Adult = false,
                  Overview = "Louis Creed, his wife Rachel and their two children Gage and Ellie move to a rural home where they are welcomed and enlightened about the eerie 'Pet Sematary' located nearby. After the tragedy of their cat being killed by a truck, Louis resorts to burying it in the mysterious pet cemetery, which is definitely not as it seems, as it proves to the Creeds that sometimes dead is better.",
                  ReleaseDate = "2019-04-04"
                },
                new Movie
                {
                  VoteCount = 28,
                  Id = 458253,
                  Video = false,
                  VoteAverage = 7.3,
                  Title = "Missing Link",
                  Popularity = 52.17,
                  PosterPath = "https://image.tmdb.org/t/p/original/gEkKHiiQRVUSX15Iwo8VFydXrtu.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Missing Link",
                  BackdropPath = "https://image.tmdb.org/t/p/original/ob4XnKBqAh1rg381hayebJx6EkE.jpg",
                  Adult = false,
                  Overview = "The charismatic Sir Lionel Frost considers himself to be the world's foremost investigator of myths and monsters. Trouble is, none of his small-minded, high-society peers seems to recognize this. Hoping to finally gain acceptance from these fellow adventurers, Sir Lionel travels to the Pacific Northwest to prove the existence of a legendary creature known as the missing link.",
                  ReleaseDate = "2019-04-04"
                },
                new Movie
                {
                  VoteCount = 385,
                  Id = 527261,
                  Video = false,
                  VoteAverage = 0,
                  Title = "The Silence",
                  Popularity = 48.139,
                  PosterPath = "https://image.tmdb.org/t/p/original/lTVOquzxw2DPF3MKuYd1ynz9F6H.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "The Silence",
                  BackdropPath = "https://image.tmdb.org/t/p/original/iHJQIKSLHN2mUUWySpj2MO5HVtS.jpg",
                  Adult = false,
                  Overview = "With the world under attack by deadly creatures who hunt by sound, a teen and her family seek refuge outside the city and encounter a mysterious cult.",
                  ReleaseDate = "2019-05-16"
                },
                new Movie
                {
                  VoteCount = 60,
                  Id = 453755,
                  Video = false,
                  VoteAverage = 7,
                  Title = "Arctic",
                  Popularity = 45.424,
                  PosterPath = "https://image.tmdb.org/t/p/original/w9GVlRteCgY103DN8CdFik3HUhO.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Arctic",
                  BackdropPath = "https://image.tmdb.org/t/p/original/adNNHvX31BATsQjSBurupj0gt30.jpg",
                  Adult = false,
                  Overview = "A man stranded in the Arctic is finally about to receive his long awaited rescue. However, after a tragic accident, his opportunity is lost and he must then decide whether to remain in the relative safety of his camp or embark on a deadly trek through the unknown for potential salvation.",
                  ReleaseDate = "2018-07-26"
                },
                new Movie
                {
                  VoteCount = 195,
                  Id = 300681,
                  Video = false,
                  VoteAverage = 5.6,
                  Title = "Replicas",
                  Popularity = 43.307,
                  PosterPath = "https://image.tmdb.org/t/p/original/hhPBTAn9b4TYOxc1JYNsX4BFAlW.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Replicas",
                  BackdropPath = "https://image.tmdb.org/t/p/original/sHPfBVFq7dlnXCz1zFdbEdwcBDJ.jpg",
                  Adult = false,
                  Overview = "A scientist becomes obsessed with returning his family to normalcy after a terrible accident.",
                  ReleaseDate = "2018-10-25"
                },
                new Movie
                {
                  VoteCount = 460,
                  Id = 440161,
                  Video = false,
                  VoteAverage = 7.1,
                  Title = "The Sisters Brothers",
                  Popularity = 40.66,
                  PosterPath = "https://image.tmdb.org/t/p/original/7Tl2nZ6uvmxwK14Skbf9VFHEHpX.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "The Sisters Brothers",
                  BackdropPath = "https://image.tmdb.org/t/p/original/iOa6iD7t7nv6wghPuMdZCaQSDJh.jpg",
                  Adult = false,
                  Overview = "Oregon, 1851. Hermann Kermit Warm, a chemist and aspiring gold prospector, keeps a profitable secret that the Commodore wants to know, so he sends the Sisters brothers, two notorious assassins, to capture him on his way to California.",
                  ReleaseDate = "2018-09-19"
                },
                new Movie{
                  VoteCount = 628,
                  Id = 361292,
                  Video = false,
                  VoteAverage = 7.1,
                  Title = "Suspiria",
                  Popularity = 40.253,
                  PosterPath = "https://image.tmdb.org/t/p/original/dzWTnkert9EoiPWldWJ15dnfAFl.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Suspiria",
                  BackdropPath = "https://image.tmdb.org/t/p/original/AmO8I38bkHwKhgxPNrd6djBQyPU.jpg",
                  Adult = false,
                  Overview = "A darkness swirls at the center of a world-renowned dance company, one that will engulf the troupe's artistic director, an ambitious young dancer and a grieving psychotherapist. Some will succumb to the nightmare, others will finally wake up.",
                  ReleaseDate = "2018-10-11"
                },
                new Movie
                {
                  VoteCount = 123,
                  Id = 450001,
                  Video = false,
                  VoteAverage = 5.1,
                  Title = "Master Z: Ip Man Legacy",
                  Popularity = 40.028,
                  PosterPath = "https://image.tmdb.org/t/p/original/nkCoAik5I4j3Gkd2upj9xv4F0QN.jpg",
                  OriginalLanguage = "cn",
                  OriginalTitle = "葉問外傳：張天志",
                  BackdropPath = "https://image.tmdb.org/t/p/original/grtVFGJ4ts0nDAPpc1JWbBoVKTu.jpg",
                  Adult = false,
                  Overview = "After being defeated by Ip Man, Cheung Tin Chi is attempting to keep a low profile. While going about his business, he gets into a fight with a foreigner by the name of Davidson, who is a big boss behind the bar district. Tin Chi fights hard with Wing Chun and earns respect.",
                  ReleaseDate = "2018-12-20"
                },
                new Movie
                {
                  VoteCount = 419,
                  Id = 527641,
                  Video = false,
                  VoteAverage = 8.2,
                  Title = "Five Feet Apart",
                  Popularity = 39.837,
                  PosterPath = "https://image.tmdb.org/t/p/original/kreTuJBkUjVWePRfhHZuYfhNE1T.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Five Feet Apart",
                  BackdropPath = "https://image.tmdb.org/t/p/original/d7wa3VpUpKDQ7GG9EMw8zSJCFoI.jpg",
                  Adult = false,
                  Overview = "Seventeen-year-old Stella spends most of her time in the hospital as a cystic fibrosis patient. Her life is full of routines, boundaries and self-control -- all of which get put to the test when she meets Will, an impossibly charming teen who has the same illness.",
                  ReleaseDate = "2019-03-15"
                },
                new Movie
                {
                  VoteCount = 14,
                  Id = 514439,
                  Video = false,
                  VoteAverage = 7.4,
                  Title = "Breakthrough",
                  Popularity = 37.643,
                  PosterPath = "https://image.tmdb.org/t/p/original/t58dx7JIgchr9If5uxn3NmHaHoS.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Breakthrough",
                  BackdropPath = "https://image.tmdb.org/t/p/original/6jaNHf9ja84YG3KWMDK1nOnvGDg.jpg",
                  Adult = false,
                  Overview = "When he was 14, Smith drowned in Lake St. Louis and was dead for nearly an hour. According to reports at the time, CPR was performed 27 minutes to no avail. Then the youth's mother, Joyce Smith, entered the room, praying loudly. Suddenly, there was a pulse, and Smith came around.",
                  ReleaseDate = "2019-04-11"
                },
                new Movie{
                  VoteCount = 454,
                  Id = 489925,
                  Video = false,
                  VoteAverage = 7.4,
                  Title = "Eighth Grade",
                  Popularity = 36.218,
                  PosterPath = "https://image.tmdb.org/t/p/original/xTa9cLhGHfQ7084UvoPQ2bBXKqd.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Eighth Grade",
                  BackdropPath = "https://image.tmdb.org/t/p/original/7cDZkagW1YTnT4nP1BYrLPSd04B.jpg",
                  Adult = false,
                  Overview = "Thirteen-year-old Kayla endures the tidal wave of contemporary suburban adolescence as she makes her way through the last week of middle school — the end of her thus far disastrous eighth grade year — before she begins high school.",
                  ReleaseDate = "2018-01-19"
                },
                new Movie
                {
                  VoteCount = 25,
                  Id = 526050,
                  Video = false,
                  VoteAverage = 5.9,
                  Title = "Little",
                  Popularity = 33.645,
                  PosterPath = "https://image.tmdb.org/t/p/original/4MDB6jJl3U7xK1Gw64zIqt9pQA4.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Little",
                  BackdropPath = "https://image.tmdb.org/t/p/original/tmM78qRhpg0i2Cky8Q8hXKASOXY.jpg",
                  Adult = false,
                  Overview = "A woman receives the chance to relive the life of her younger self, at a point in her life when the pressures of adulthood become too much for her to bear.",
                  ReleaseDate = "2019-04-04"
                },
                new Movie
                {
                  VoteCount = 0,
                  Id = 531309,
                  Video = false,
                  VoteAverage = 0,
                  Title = "Brightburn",
                  Popularity = 30.002,
                  PosterPath = "https://image.tmdb.org/t/p/original/roslEbKdY0WSgYaB5KXvPKY0bXS.jpg",
                  OriginalLanguage = "en",
                  OriginalTitle = "Brightburn",
                  BackdropPath = "https://image.tmdb.org/t/p/original/uHEI6v8ApQusjbaRZ8o7WcLYeWb.jpg",
                  Adult = false,
                  Overview = "What if a child from another world crash-landed on Earth, but instead of becoming a hero to mankind, he proved to be something far more sinister?",
                  ReleaseDate = "2019-04-24"
                }
            };
            #endregion
        }

        async Task OnMovieTappedAsync(Movie movie)
        {
            if (movie != null)
            {
                await Application.Current.MainPage.DisplayAlert("Movie tapped", movie.Title, "OK");
            }
        }
    }
}
