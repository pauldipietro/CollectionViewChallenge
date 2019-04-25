using CoreGraphics;
using System;
using UIKit;

namespace CollectionViewChallenge.iOS.Controls
{
    /// <summary>
    /// Custom iOS UILabel that allows padding of content
    /// </summary>
    internal class UILabelControl : UILabel
    {
        private UIEdgeInsets m_padding = UIEdgeInsets.Zero;
        public UIEdgeInsets Padding
        {
            get { return m_padding; }
            set
            {
                m_padding = value;
                InvalidateIntrinsicContentSize();
            }
        }

        public override CGRect TextRectForBounds(CGRect bounds, nint numberOfLines)
        {
            CGRect rect = base.TextRectForBounds(Padding.InsetRect(bounds), numberOfLines);

            return new CGRect(rect.X - Padding.Left,
                               rect.Y - Padding.Top,
                               rect.Width + Padding.Left + Padding.Right,
                               rect.Height + Padding.Top + Padding.Bottom);
        }

        public override void DrawText(CGRect rect)
        {
            base.DrawText(Padding.InsetRect(rect));
        }
    }
}