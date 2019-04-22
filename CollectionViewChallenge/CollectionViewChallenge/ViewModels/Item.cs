using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace CollectionViewChallenge.ViewModels
{
    public class Item
    {
        public string ImageName { get; }
        public bool IsSelected { get; set; }

        public Item(string imageName, double width)
        {
            ImageName = imageName;
            Width = width;
        }

        public Xamarin.Forms.ImageSource ImageSource => Xamarin.Forms.ImageSource.FromResource("CollectionViewChallenge.Images." + ImageName);

        public double Width { get; set; }
    }
}