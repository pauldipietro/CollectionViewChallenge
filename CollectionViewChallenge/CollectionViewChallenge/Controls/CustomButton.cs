using System;
using Xamarin.Forms;
using CollectionViewChallenge.Models;
using System.Windows.Input;

namespace CollectionViewChallenge.Controls
{
    public class CustomButton : Image
    {
        public SfxItem Button { get; set; }
        private bool playMulti;
        bool isPlaying;

        public ICommand ButtonPressedCommand { get; private set; }

        public CustomButton() { }

        public CustomButton(SfxItem _btn)
        {
            this.Button = _btn;

            switch (Button.category)
            {
                case 1: { Source = "alert_unpressed"; } break;
                case 2: { Source = "animal_unpressed"; } break;
                case 3: { Source = "meme_unpressed"; } break;
                case 4: { Source = "music_unpressed"; } break;
                case 5: { Source = "sfx_unpressed"; } break;
            }

            ButtonPressedCommand = new Command(ButtonPressed);

            playMulti = true;
        }

        public void ButtonPressed()
        {
            if (!isPlaying)
            {
                Play();
                SwitchImage();
                
            }
            else
            {
                Stop();
                SwitchImage();
            }
            isPlaying = !isPlaying;
        }

        public void Play()
        {
           if (playMulti)
           {
                 
           }
        }

        public void Stop()
        {

        }

        public void SwitchImage()
        {
            if (!isPlaying)
            {
                switch (Button.category)
                {
                    case 1: { Source = "alert_pressed"; } break;
                    case 2: { Source = "animal_pressed"; } break;
                    case 3: { Source = "meme_pressed"; } break;
                    case 4: { Source = "music_pressed"; } break;
                    case 5: { Source = "sfx_pressed"; } break;
                }
            }
            else
            {
                switch (Button.category)
                {
                    case 1: { Source = "alert_unpressed"; } break;
                    case 2: { Source = "animal_unpressed"; } break;
                    case 3: { Source = "meme_unpressed"; } break;
                    case 4: { Source = "music_unpressed"; } break;
                    case 5: { Source = "sfx_unpressed"; } break;
                }
            }
        }

    }
}
