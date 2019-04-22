using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CollectionViewChallenge
{
    public class CustomCollectionView : CollectionView
    {
        public static readonly BindableProperty InsetProperty =
  BindableProperty.Create(nameof(Inset), typeof(bool), typeof(CustomCollectionView), false);

        public bool Inset
        {
            get { return (bool)GetValue(InsetProperty); }
            set { SetValue(InsetProperty, value); }
        }

        public event EventHandler<int> HorizontalScrollUpdated;

        public int ScrollX { get; private set; }

        public int ScrollXWidth { get; private set; }

        public void UpdateXScroll(int scroll, int totalWidth)
        {
            ScrollX = scroll;
            ScrollXWidth = totalWidth;
            HorizontalScrollUpdated?.Invoke(this, scroll);
        }
    }
}
