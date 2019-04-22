
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
                _offsetObserver = ItemsViewController.CollectionView.AddObserver("contentOffset",
                                 Foundation.NSKeyValueObservingOptions.Initial, HandleAction);
                ItemsViewController.CollectionView.ShowsHorizontalScrollIndicator = false;

            }

        }

        private void HandleAction(Foundation.NSObservedChange obj)
        {
            var correctedXScroll = ItemsViewController.CollectionView.ContentOffset.X + Frame.Width / 2 - Frame.Height / 2;

            var totalWidth = ItemsViewController.CollectionView.ContentSize.Width;
            Debug.WriteLine($"Scrolled to:{ItemsViewController.CollectionView.ContentOffset.X} / {totalWidth}");

            CollectionElement.UpdateXScroll((int)correctedXScroll, (int)totalWidth);
        }

        public override void LayoutSubviews()
        {
            if (CollectionElement.Inset)
            {
                ItemsViewController.CollectionView.ContentInset = new UIEdgeInsets(0, Frame.Width / 2 - Frame.Height / 2, 0, Frame.Width / 2 - Frame.Height / 2);
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
