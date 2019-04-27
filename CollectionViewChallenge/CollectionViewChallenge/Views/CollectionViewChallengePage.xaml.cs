using CollectionViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        List<Song> songsList = new List<Song>();

        private static CancellationTokenSource _cancellationTokenSource;

        int startIndex = 0;
        public CollectionViewChallengePage()
        {
            InitializeComponent();

            //let's populate some of my favorite tracks
            songsList.Add(new Song()
            {
                CoverImage = "Heathens.jpg",
                Lyrics = "All my friends are heathens, take it slow\nWait for them to ask you who you know\nPlease don't make any sudden moves\nYou don't know the half of the abuse\nAll my friends are heathens, take it slow\nWait for them to ask you who you know\nPlease don't make any sudden moves\nYou don't know the half of the abuse\nWelcome to the room of people\nWho have rooms of people that they loved one day\nDocked away\nJust because we check the guns at the door\nDoesn't mean our brains will change from hand grenades\nYou're lovin' on the psychopath sitting next to you\nYou're lovin' on the murderer sitting next to you\nYou'll think, How'd I get here, sitting next to you ? \nBut after all I've said, please don't forget\nAll my friends are heathens, take it slow\nWait for them to ask you who you know\nPlease don't make any sudden moves\nYou don't know the half of the abuse\n"
            });

            songsList.Add(new Song()
            {
                CoverImage = "MadOverYou.jpeg",
                Lyrics = "Dance for the dough.\nGyal I wan make you whine for the dough\nTell am... One time for the love\nTell the gyal make she dance for the love\nGhana girl say she wan marry me o\nI hope say she sabi cook wache\nHope your love go sweet pass shito\nBaby girl I say, I say your body na killer o\nI fit to die on top your body. Only on your body\nThat girl for the corner, tell somebody make they call am o\nWay she dey whine am I see fire for her body o\nAnd if she follow me go na enjoyment go kill am o\nBaby girl you bad o\nGirl the way you whine\nI dey mad over you girl.\nI dey mad over you girl\nSay you are my woman eee. My super woman\nI dey mad over you girl. I dey mad over you girl\nDie for the love\nGyal I wan make you whine for the dough\nOne time for the love\nGyal I wan make yoy dance for the dough\nDance for the dough.\nGyal I wan make you whine for the dough\nTell am. One time for the love\nTell the gyal make she dance for the love\nIf I sing for you, you go love me o\nBaby love me non-stop.\nI will love you non-stop\nAlways kiss you on top. Baby o\nAll over the world wan wa mi o.\nPlay the music non-stop\nTell them dance to my song.\nTell them shake bum bum. ohweh"
            });

            songsList.Add(new Song()
            {
                CoverImage = "jazz.jpg",
                Lyrics = "I said, 'Take it easy, baby\nI worked all day and my feet feel just like lead\nYou got my shirt tails flyin' all over the place\nAnd the sweat poppin' out of my head'\nShe said, 'Hey, bossa nova baby\nKeep on workin' for this ain't no time to quit'\nShe said, 'Go, bossa nova baby keep on dancin'\nI'm about to have myself a fit'\nBossa nova, bossa nova\nI said, “Hey little mama, let's sit down\nHave a drink and dig the band'\nShe said, 'Drink, drink, drink oh, fiddle-de-dink\nI can dance with a drink in my hand'\nShe said, 'Hey bossa nova baby\nKeep on workin' for this ain't no time to drink'\nShe said, 'Go bossa nova baby\nKeep on dancin', 'cause I ain't got time to think'\nBossa nova, bossa nova\nI said, 'Come on baby, it's hot in here\nAnd it's oh so cool outside\nIf you lend me a dollar, I can buy some gas\nAnd we can go for a little ride'\nShe said, 'Hey bossa nova baby\nKeep on workin' for I ain't got time for that'\nShe said, 'Go bossa nova baby\nKeep on dancin' or I'll find myself another cat'\nBossa nova, bossa nova\nBossa nova, bossa nova\nBossa nova, bossa nova"
            });

            cv_Songs.ItemsSource = songsList;

            lblLyrics.Text = songsList[0].Lyrics;
            _cancellationTokenSource = new CancellationTokenSource();
            AnimateLyrics();
            ShowProgressTimer();
        }

        private async void AnimateLyrics()
        {
            await Task.Delay(2000);
            int offset = -5;
            CancellationTokenSource cts = _cancellationTokenSource;
            Device.StartTimer(TimeSpan.FromMilliseconds(50), () =>
            {
                if (cts.IsCancellationRequested)
                {
                    return false;
                }
                Device.BeginInvokeOnMainThread(() =>
                {
                    lblLyrics.TranslateTo(0, -10 + offset, 250, Easing.Linear);
                });
                offset--;
                return true;
            });
        }

        private async void ShowProgressTimer()
        {
            int Min = 4;
            int Sec = 12;
            int TotalSec = (Min * 60) + Sec;
            await Task.Run(() =>
            {
                double slidervalue = slider.Minimum;
                CancellationTokenSource cts = _cancellationTokenSource;
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    if (cts.IsCancellationRequested)
                    {
                        return false;
                    }
                    if (TotalSec == 0)
                        return false;
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        TotalSec = TotalSec - 1;
                        TimeSpan _TimeSpan = TimeSpan.FromSeconds(TotalSec);
                        lblStartTimer.Text = string.Format("{0:00}:{1:00}", _TimeSpan.Minutes, _TimeSpan.Seconds);
                        slider.Value = slidervalue++;
                    });
                    return true;
                });
            });
        }

        
        private void nextBtn_Tapped(object sender, EventArgs e)
        {
            if (startIndex < songsList.Count)
            {
                cv_Songs.ScrollTo(startIndex++);
            }
            else
            {
                startIndex = 0;
                cv_Songs.ScrollTo(startIndex);
            }
        }

        private void Cv_Songs_ScrollToRequested(object sender, ScrollToRequestEventArgs e)
        {
            Stop();
            lblLyrics.Text = songsList[e.Index].Lyrics;
            _cancellationTokenSource = new CancellationTokenSource();
            AnimateLyrics();
            ShowProgressTimer();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            if ((playBtn.Source as FileImageSource).File == "pause.png")
                playBtn.Source = "play.png";
            else
                playBtn.Source = "pause.png";
        }

        public void Stop()
        {
            Interlocked.Exchange(ref _cancellationTokenSource, new CancellationTokenSource()).Cancel();
        }
    }
}