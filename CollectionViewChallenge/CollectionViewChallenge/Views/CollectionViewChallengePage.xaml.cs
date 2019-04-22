using CollectionViewChallenge.ViewModels;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewChallengePage : ContentPage
    {
        public ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();

        public CollectionViewChallengePage()
        {
            InitializeComponent();

            var photos = new Dictionary<string, double>();

            for (int i = 0; i < 7; i++)
            {
                string name = $"sloth{i}.JPG";
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(Item)).Assembly;
                var stream = assembly.GetManifestResourceStream("CollectionViewChallenge.Images." + name);
                double width;
                using (Image<Rgba32> image = SixLabors.ImageSharp.Image.Load(stream))
                {
                    var size = image.Size();
                    var scale = size.Height / 80.0;
                    var scaledHeight = size.Height / scale;
                    width = size.Width / scale;
                    Debug.WriteLine($"Calculated {name}: {size.Width}*{size.Height} -> {Math.Round(width)}*{Math.Round(scaledHeight)}");
                }
                photos.Add(name, width);
            }

            for (int i = 0; i < 30; i++)
            {
                var position = i % 7;
                var item = photos.ElementAt(position);
                Items.Add(new Item(item.Key, item.Value));
            }

            BindingContext = this;
        }

        int _lastPositon = 0;
        private void PreviewCollection_HorizontalScrollUpdated(object sender, int e)
        {
            var scrollProgress = PreviewCollection.ScrollX == 0 ? 0 : (double)(PreviewCollection.ScrollX + PreviewCollection.Height / 2) / ( PreviewCollection.ScrollXWidth );
            scrollProgress = scrollProgress < 0 ? 0 : scrollProgress;
            var position = (int)Math.Round(Items.Count * scrollProgress);
            if (previewTargetPosition >= 0 && previewTargetPosition != position)
            {
                // Wait until target position is reached
                return;
            }
            previewTargetPosition = -1;

            position = position >= 0 ? position : 0;
            position = position > Items.Count - 1 ? Items.Count - 1 : position;

            if (position != _lastPositon)
            {
                _lastPositon = position;
                fullSizeTargetPosition = position;
                var middleImage = Items[position];
                FullViewCollection.ScrollTo(middleImage);
                Debug.WriteLine("Preview scrolled to position: " + position);
            }
        }

        int previewTargetPosition;
        int fullSizeTargetPosition;

        private void FullViewCollection_HorizontalScrollUpdated(object sender, int e)
        {
            var scrollProgress = FullViewCollection.ScrollX == 0 ? 0 : (double)FullViewCollection.ScrollX / FullViewCollection.ScrollXWidth;
            scrollProgress = scrollProgress < 0 ? 0 : scrollProgress;
            var position = (int)Math.Round(Items.Count * scrollProgress);

            if (fullSizeTargetPosition >= 0 && fullSizeTargetPosition != position)
            {
                // Wait until target position is reached
                return;
            }
            fullSizeTargetPosition = -1;
            position = position >= 0 ? position : 0;
            position = position > Items.Count - 1 ? Items.Count - 1 : position;

            if (position != _lastPositon )
            {
                _lastPositon = position;
                var middleImage = Items[position];
                previewTargetPosition = position;
                PreviewCollection.ScrollTo(middleImage, ScrollToPosition.Center);
                Debug.WriteLine("Full screen scrolled to position: " + position);
            }
        }
    }
}