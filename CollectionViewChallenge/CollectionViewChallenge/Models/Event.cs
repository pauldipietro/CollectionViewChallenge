using System;
using System.ComponentModel;

namespace CollectionViewChallenge.Models
{
    public class Event : INotifyPropertyChanged
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime SubmittedOn { get; set; }
        public int Points { get; set; }

        private bool _DropDownVisible;
        public bool DropDownVisible
        {
            get { return _DropDownVisible; }
            set
            {
                if(_DropDownVisible != value)
                {
                    _DropDownVisible = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("DropDownVisible"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
