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

            // Get the width of each photo to set a fixed with in the preview collection
            // This takes ages on an android device (emulator is faster)
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

            // Add the images to our list :)
            for (int i = 0; i < 30; i++)
            {
                var position = i % 7;
                var item = photos.ElementAt(position);
                Items.Add(new Item(item.Key, item.Value));
            }

            BindingContext = this;
        }

        int _currentPosition = 0;
        // These variables contain the position that should be scrolled to
        int _previewTargetPosition;
        int _fullSizeTargetPosition;

        // Scroll event of the preview collection
        private void PreviewCollection_HorizontalScrollUpdated(object sender, int e)
        {
            var scrollProgress = PreviewCollection.ScrollX == 0 ? 0 : (double)(PreviewCollection.ScrollX + PreviewCollection.Height / 2) / ( PreviewCollection.ScrollXWidth );
            scrollProgress = scrollProgress < 0 ? 0 : scrollProgress;
            var position = (int)Math.Round(Items.Count * scrollProgress);
            if (_previewTargetPosition >= 0 && _previewTargetPosition != position)
            {
                // Wait until target position is reached
                return;
            }
            _previewTargetPosition = -1;

            // My calculations are a bit off so i make sure that my index is not out of range :)
            position = position >= 0 ? position : 0;
            position = position > Items.Count - 1 ? Items.Count - 1 : position;

            // Check if the position updated to avoid unnecessary scroll to calls
            if (position != _currentPosition)
            {
                // Set the currently visible item as the target position for the full-size collection to be in-sync
                _currentPosition = position;
                _fullSizeTargetPosition = position;
                var middleImage = Items[position];
                FullViewCollection.ScrollTo(middleImage);
                Debug.WriteLine("Preview scrolled to position: " + position);
            }
        }

        // Scroll event of the full size collection
        private void FullViewCollection_HorizontalScrollUpdated(object sender, int e)
        {
            // Calculate currently visible item
            var scrollProgress = FullViewCollection.ScrollX == 0 ? 0 : (double)FullViewCollection.ScrollX / FullViewCollection.ScrollXWidth;
            scrollProgress = scrollProgress < 0 ? 0 : scrollProgress;
            var position = (int)Math.Round(Items.Count * scrollProgress);

            if (_fullSizeTargetPosition >= 0 && _fullSizeTargetPosition != position)
            {
                // Wait until target position is reached
                return;
            }
            _fullSizeTargetPosition = -1;

            // My calculations are a bit off so i make sure that my index is not out of range :)
            position = position >= 0 ? position : 0;
            position = position > Items.Count - 1 ? Items.Count - 1 : position;

            // Check if the position updated to avoid unnecessary scroll to calls
            if (position != _currentPosition )
            {
                // Set the currently visible item as the target position for the preview collection to be in-sync
                _currentPosition = position;
                var middleImage = Items[position];
                _previewTargetPosition = position;
                PreviewCollection.ScrollTo(middleImage, ScrollToPosition.Center);
                Debug.WriteLine("Full screen scrolled to position: " + position);
            }
        }
    }
}