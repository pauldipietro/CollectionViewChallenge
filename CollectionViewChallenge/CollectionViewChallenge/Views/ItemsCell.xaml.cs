using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsCell : Grid
    {
        public ItemsCell()
        {
            InitializeComponent();
        }

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            return base.OnMeasure(widthConstraint, widthConstraint);
        }

        protected override void OnSizeAllocated(double width, double height)
        { 
            if (width > 0 && height != width)
            {
                HeightRequest = width;
                InvalidateMeasure();
            }
            base.OnSizeAllocated(width, width);
        }
    }
}