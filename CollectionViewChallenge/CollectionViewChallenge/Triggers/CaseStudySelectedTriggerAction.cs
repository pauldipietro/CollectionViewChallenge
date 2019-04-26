using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CollectionViewChallenge.Triggers
{
    public class CaseStudySelectedTriggerAction : TriggerAction<Frame>
    {
        public CaseStudySelectedTriggerAction() { }

        public double Degrees { get; set; }

        protected override void Invoke(Frame cell)
        {
            Animation(cell);
        }

        private async void Animation(Frame cell)
        {
            await cell.RotateXTo(Degrees, 400);
        }
    }
}