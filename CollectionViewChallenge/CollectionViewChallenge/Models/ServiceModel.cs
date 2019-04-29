using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CollectionViewChallenge.Models
{
    class ServiceModel : Xamarin.Forms.BindableObject
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        private bool animate { get; set; }
        public bool Animate {
            get
            {
                return animate;
            }
            set
            {
                animate = value;
                OnPropertyChanged("Animate");
            }
        }
    }
}
