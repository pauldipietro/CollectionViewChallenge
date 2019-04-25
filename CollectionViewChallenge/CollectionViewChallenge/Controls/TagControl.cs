using System.Collections;
using Xamarin.Forms;

namespace CollectionViewChallenge.Controls
{
    public class TagControl : StackLayout
    {
        public readonly static BindableProperty TagsProperty =
            BindableProperty.Create(nameof(Tags), typeof(IEnumerable), typeof(TagControl), null);

        public IEnumerable Tags
        {
            get => (IEnumerable)GetValue(TagsProperty);
            set => SetValue(TagsProperty, value);
        }

        public readonly static BindableProperty TagColourProperty =
            BindableProperty.Create(nameof(TagColour), typeof(Color), typeof(TagControl), Color.Black);

        public Color TagColour
        {
            get => (Color)GetValue(TagColourProperty);
            set => SetValue(TagColourProperty, value);
        }

        public readonly static BindableProperty TagFontSizeProperty =
            BindableProperty.Create(nameof(TagFontSize), typeof(double), typeof(TagControl), 8.0);

        public double TagFontSize
        {
            get => (double)GetValue(TagFontSizeProperty);
            set => SetValue(TagFontSizeProperty, value);
        }

        public readonly static BindableProperty TagTextColourProperty =
            BindableProperty.Create(nameof(TagTextColour), typeof(Color), typeof(TagControl), Color.White);

        public Color TagTextColour
        {
            get => (Color)GetValue(TagTextColourProperty);
            set => SetValue(TagTextColourProperty, value);
        }

        public static readonly BindableProperty TagCornerRadiusProperty =
            BindableProperty.Create(nameof(TagCornerRadius), typeof(int), typeof(TagControl), 0);

        public int TagCornerRadius
        {
            get { return (int)GetValue(TagCornerRadiusProperty); }
            set { SetValue(TagCornerRadiusProperty, value); }
        }

        public readonly static BindableProperty TagPaddingProperty =
            BindableProperty.Create(nameof(TagPadding), typeof(Thickness), typeof(TagControl), new Thickness(0));

        public Thickness TagPadding
        {
            get => (Thickness)GetValue(TagPaddingProperty);
            set => SetValue(TagPaddingProperty, value);
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TagsProperty.PropertyName)
            {
                SetTags();
            }
            else if (propertyName == TagColourProperty.PropertyName ||
                     propertyName == TagFontSizeProperty.PropertyName ||
                     propertyName == TagTextColourProperty.PropertyName ||
                     propertyName == TagCornerRadiusProperty.PropertyName ||
                     propertyName == TagPaddingProperty.PropertyName)
            {
                SetTagProperties();
            }
        }

        private void SetTags()
        {
            Children.Clear();

            foreach (object tag in Tags)
            {
                AddLabel(tag);
            }
        }

        private void AddLabel(object tag)
        {
            LabelControl tagLabel = new LabelControl()
            {
                LineBreakMode = LineBreakMode.NoWrap,
                Text = tag.ToString(),
                TextColor = TagTextColour,
                FontSize = TagFontSize,
                VerticalOptions = LayoutOptions.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.Fill,
                HorizontalTextAlignment = TextAlignment.Center,
                BackgroundColor = TagColour,
                Padding = TagPadding,
                CornerRadius = TagCornerRadius
            };

            Children.Add(tagLabel);
        }

        private void SetTagProperties()
        {
            if (Children == null || Children.Count == 0)
                return;

            foreach (View child in Children)
            {
                LabelControl tag = child as LabelControl;
                if (tag != null)
                {
                    tag.TextColor = TagTextColour;
                    tag.FontSize = TagFontSize;
                    tag.BackgroundColor = TagColour;
                    tag.SetValue(LabelControl.PaddingProperty, TagPadding);
                    tag.CornerRadius = TagCornerRadius;
                }
            }
        }
    }
}
