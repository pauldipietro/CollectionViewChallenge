using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewChallenge.Triggers
{
    public class ServiceSelectedTriggerAction : TriggerAction<Grid>
    {
        public ServiceSelectedTriggerAction() { }

        public double Scale { get; set; }

        protected override void Invoke(Grid service)
        {
            Animation(service);
        }

        private async void Animation(Grid service)
        {

            await service.ScaleTo(Scale, 400);
            await service.ScaleTo(1, 400);
        }
    }
}
