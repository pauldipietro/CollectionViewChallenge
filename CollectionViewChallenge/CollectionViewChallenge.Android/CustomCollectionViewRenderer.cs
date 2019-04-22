using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CollectionViewChallenge;
using CollectionViewChallenge.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomCollectionView), typeof(CustomCollectionViewRenderer))]
namespace CollectionViewChallenge.Droid
{
    public class CustomCollectionViewRenderer : CollectionViewRenderer
    {
        private CustomCollectionView CollectionElement => ((CustomCollectionView) Element);

        public CustomCollectionViewRenderer(Context context) : base(context)
        { 
        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            // Inset is only required for the preview collection
            if(CollectionElement.Inset)
            {
                SetClipToPadding(false);
                // Take a little less then half of the width in order for the first image to be centered
                var horizontalInset = w / 2 - h / 2;
                SetPadding(horizontalInset, 0, horizontalInset, 0);
            }
            
            base.OnSizeChanged(w, h, oldw, oldh);
        }

        public override void OnScrolled(int dx, int dy)
        { 
            // Propagede the scroll events to the view, this is quite easy on android :)
            var scrollOffsetX = ComputeHorizontalScrollOffset();
            var totalWidth = ComputeHorizontalScrollRange();
            CollectionElement.UpdateXScroll(scrollOffsetX, totalWidth);
            base.OnScrolled(dx, dy);
        }
    }
}