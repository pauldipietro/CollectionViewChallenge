using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewChallenge.Models
{
    class CaseStudyModel : Xamarin.Forms.BindableObject
    {
        public string Icon { get; set; }
        public string Project { get; set; }
        public string Company { get; set; }
        public string Quote { get; set; }
        private bool showQuote { get; set; }
        public bool ShowQuote
        {
            get
            {
                return showQuote;
            }
            set
            {
                showQuote = value;
                OnPropertyChanged("ShowQuote");
                OnPropertyChanged("ShowCompany");
            }
        }

        public bool ShowCompany
        {
            get
            {
                return !showQuote;
            }
        }
    }
}
