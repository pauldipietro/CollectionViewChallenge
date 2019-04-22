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
            if(CollectionElement.Inset)
            {
                SetClipToPadding(false);
                var firstItemSize = h;
                var lastItemSize = h;
                SetPadding(w / 2 - firstItemSize, 0, w / 2 , 0);
            }
            
            base.OnSizeChanged(w, h, oldw, oldh);
        }

        public override void OnScrolled(int dx, int dy)
        {
            var x1 = ComputeHorizontalScrollExtent();
            var x2 = ComputeHorizontalScrollOffset();
            var x3 = ComputeHorizontalScrollRange();
            CollectionElement.UpdateXScroll(x2, x3);
            base.OnScrolled(dx, dy);
        }
    }
}