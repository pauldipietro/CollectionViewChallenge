using CollectionViewChallenge.Controls;
using CollectionViewChallenge.iOS.Controls;
using CollectionViewChallenge.iOS.Renderers;
using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LabelControl), typeof(LabelControlRenderer))]

namespace CollectionViewChallenge.iOS.Renderers
{
    public class LabelControlRenderer : LabelRenderer
    {
        private UIEdgeInsets m_padding;

        public LabelControlRenderer()
        {
            m_padding = new UIEdgeInsets();
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            if (Control == null)
                SetNativeControl(new UILabelControl());

            base.OnElementChanged(e);

            if (Control != null)
            {
                UpdateCornerRadius();
                UpdateBorderWidth();
                UpdateBorderColour();
                UpdatePadding();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == LabelControl.CornerRadiusProperty.PropertyName)
                UpdateCornerRadius();
            else if (e.PropertyName == LabelControl.BorderWidthProperty.PropertyName)
                UpdateBorderWidth();
            else if (e.PropertyName == LabelControl.BorderColourProperty.PropertyName)
                UpdateBorderColour();
            else if (e.PropertyName == LabelControl.PaddingProperty.PropertyName)
                UpdatePadding();
        }

        private void UpdateCornerRadius()
        {
            LabelControl label = Element as LabelControl;
            if (label == null)
                return;

            Layer.CornerRadius = label.CornerRadius;
        }

        private void UpdateBorderWidth()
        {
            LabelControl label = Element as LabelControl;
            if (label == null)
                return;

            Layer.BorderWidth = label.BorderWidth;
        }

        private void UpdateBorderColour()
        {
            LabelControl label = Element as LabelControl;
            if (label == null)
                return;

            Layer.BorderColor = label.BorderColour.ToCGColor();
        }

        private void UpdatePadding()
        {
            LabelControl label = Element as LabelControl;
            if (label == null)
                return;

            m_padding.Top = (nfloat)label.Padding.Top;
            m_padding.Left = (nfloat)label.Padding.Left;
            m_padding.Bottom = (nfloat)label.Padding.Bottom;
            m_padding.Right = (nfloat)label.Padding.Right;

            (Control as UILabelControl).Padding = m_padding;
        }
    }
}