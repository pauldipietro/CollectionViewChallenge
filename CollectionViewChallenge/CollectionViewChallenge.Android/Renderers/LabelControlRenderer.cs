using Android.Content;
using Android.Graphics.Drawables;
using CollectionViewChallenge.Controls;
using CollectionViewChallenge.Droid.Helpers;
using CollectionViewChallenge.Droid.Renderers;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LabelControl), typeof(LabelControlRenderer))]

namespace CollectionViewChallenge.Droid.Renderers
{
    public class LabelControlRenderer : LabelRenderer
    {
        private GradientDrawable m_background;

        public LabelControlRenderer(Context context)
            : base(context)
        {
            m_background = new GradientDrawable();
            m_background.SetShape(ShapeType.Rectangle);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                UpdatePadding();
            }
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);

            LabelControl label = Element as LabelControl;
            if (label == null)
                return;

            m_background.SetColor(label.BackgroundColor.ToAndroid());

            int cornerRadiusPx = ConversionHelper.ConvertDPToPixels(label.CornerRadius);
            m_background.SetCornerRadius(cornerRadiusPx);

            int borderWidthPx = ConversionHelper.ConvertDPToPixels(label.BorderWidth);
            m_background.SetStroke(borderWidthPx, label.BorderColour.ToAndroid());

            Background = m_background;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == VisualElement.BackgroundColorProperty.PropertyName)
                Invalidate();
            else if (e.PropertyName == LabelControl.CornerRadiusProperty.PropertyName)
                Invalidate();
            else if (e.PropertyName == LabelControl.BorderWidthProperty.PropertyName)
                Invalidate();
            else if (e.PropertyName == LabelControl.BorderColourProperty.PropertyName)
                Invalidate();
            else if (e.PropertyName == LabelControl.PaddingProperty.PropertyName)
                UpdatePadding();
        }

        private void UpdatePadding()
        {
            LabelControl label = Element as LabelControl;
            if (label == null)
                return;

            int left = ConversionHelper.ConvertDPToPixels((int)label.Padding.Left + label.BorderWidth);
            int top = ConversionHelper.ConvertDPToPixels((int)label.Padding.Top + label.BorderWidth);
            int right = ConversionHelper.ConvertDPToPixels((int)label.Padding.Right + label.BorderWidth);
            int bottom = ConversionHelper.ConvertDPToPixels((int)label.Padding.Bottom + label.BorderWidth);

            Control.SetPadding(left, top, right, bottom);
        }
    }
}