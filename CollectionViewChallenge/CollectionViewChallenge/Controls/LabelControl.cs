using Xamarin.Forms;

namespace CollectionViewChallenge.Controls
{
    public class LabelControl : Label
    {
        #region Bindable Properties

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(nameof(CornerRadius), typeof(int), typeof(LabelControl), 0);

        public int CornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create(nameof(BorderWidth), typeof(int), typeof(LabelControl), 0);

        public int BorderWidth
        {
            get { return (int)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        public static readonly BindableProperty BorderColourProperty =
            BindableProperty.Create(nameof(BorderColour), typeof(Color), typeof(LabelControl), Color.Black);

        public Color BorderColour
        {
            get { return (Color)GetValue(BorderColourProperty); }
            set { SetValue(BorderColourProperty, value); }
        }

        public static readonly BindableProperty PaddingProperty =
            BindableProperty.Create(nameof(Padding), typeof(Thickness), typeof(LabelControl), new Thickness(0));

        public Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }

        #endregion // Bindable Properties
    }
}
