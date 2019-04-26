using System;
using Xamarin.Forms;
using System.Collections.Generic;
using CollectionViewChallenge.Controls;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using CollectionViewChallenge.Models;
using System.ComponentModel;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel : INotifyPropertyChanged 
    {
        public ObservableCollection<CustomButton> Buttons {get; set;}

        public CollectionViewChallengeViewModel()
        {
            FillButtonList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void FillButtonList()
        {
            var btnAlert = new CustomButton(new SfxItem
            {
                id = 0,
                name = "Button 1",
                category = 1,
                file = "file1",
                enabled = true,
                likeCount = 1
            });
            var btnAnimal = new CustomButton(new SfxItem
            {
                id = 0,
                name = "Button 2",
                category = 2,
                file = "file1",
                enabled = true,
                likeCount = 1
            });
            var btnMeme = new CustomButton(new SfxItem
            {
                id = 0,
                name = "Button 3",
                category = 3,
                file = "file1",
                enabled = true,
                likeCount = 1
            });
            var btnMusic = new CustomButton(new SfxItem
            {
                id = 0,
                name = "Button 4",
                category = 4,
                file = "file1",
                enabled = true,
                likeCount = 1
            });
            var btnSfx = new CustomButton(new SfxItem
            {
                id = 0,
                name = "Button 5",
                category = 5,
                file = "file1",
                enabled = true,
                likeCount = 1
            });

            Buttons.Add(btnAlert);
            Buttons.Add(btnAnimal);
            Buttons.Add(btnMeme);
            Buttons.Add(btnMusic);
            Buttons.Add(btnSfx);
        }
    }
}
