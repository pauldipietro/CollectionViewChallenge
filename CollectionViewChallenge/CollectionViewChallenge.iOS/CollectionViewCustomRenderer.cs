
using System;
using System.Diagnostics;
using CollectionViewChallenge;
using CollectionViewChallenge.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomCollectionView), typeof(CollectionViewCustomRenderer))]
namespace CollectionViewChallenge.iOS
{
    public class CollectionViewCustomRenderer : CollectionViewRenderer
    {
        private CustomCollectionView CollectionElement => Element as CustomCollectionView;
        private IDisposable _offsetObserver;
        protected override void OnElementChanged(ElementChangedEventArgs<ItemsView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement is CustomCollectionView)
            {
                // Subscribe to the scroll event
                _offsetObserver = ItemsViewController.CollectionView.AddObserver("contentOffset",
                                 Foundation.NSKeyValueObservingOptions.Initial, HandleAction);
                // Hide the scroll indicator, only required on iOS ?!
                ItemsViewController.CollectionView.ShowsHorizontalScrollIndicator = false;
            }

        }

        private void HandleAction(Foundation.NSObservedChange obj)
        {
            // Remove the inset from the calculated x position
            var correctedXScroll = ItemsViewController.CollectionView.ContentOffset.X + Frame.Width / 2 - Frame.Height / 2;

            // Get the total content width
            var totalWidth = ItemsViewController.CollectionView.ContentSize.Width;
            Debug.WriteLine($"Scrolled to:{ItemsViewController.CollectionView.ContentOffset.X} / {totalWidth}");

            // Update the view
            CollectionElement.UpdateXScroll((int)correctedXScroll, (int)totalWidth);
        }

        public override void LayoutSubviews()
        {
            // Inset is only required for the preview collection
            if (CollectionElement.Inset)
            {
                // Take a little less then half of the width in order for the first image to be centered
                var horizontalInset = Frame.Width / 2 - Frame.Height / 2;
                ItemsViewController.CollectionView.ContentInset = new UIEdgeInsets(0, horizontalInset, 0, horizontalInset);
            }
            base.LayoutSubviews();
        }

        protected override void Dispose(bool disposing)
        {
            _offsetObserver.Dispose();
            _offsetObserver = null;
            base.Dispose(disposing);
        }
    }
}
