using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace CollectionViewChallenge
{
    public class SizableView : ContentView
    { 
        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            //Debug.WriteLine($"Measure width: {widthConstraint} height {heightConstraint}");
            var collection = Parent as CollectionView;
            if (collection != null)
            {
                var size = new Size(collection.Width, collection.Height);
                return new SizeRequest(size, size);
            }
            return base.OnMeasure(widthConstraint, heightConstraint);
        }
    }
}
