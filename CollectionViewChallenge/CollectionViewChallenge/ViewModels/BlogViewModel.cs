using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CollectionViewChallenge.Models;
using CollectionViewChallenge.Services;

namespace CollectionViewChallenge.ViewModels
{
    public class BlogViewModel : INotifyPropertyChanged
    {
        #region Properties
        private List<Publication> _listPublications;

        public List<Publication> ListPublications
        {
            get { return _listPublications; }
            set
            {
                _listPublications = value;
                OnPropertyChanged();
            }
        }

        public Publication Publication { get; set; }
        #endregion

        #region Constructors
        public BlogViewModel()
        {
            GetService();
        }
        #endregion

        #region CRUD Services
        public void GetService()
        {
            var service = new PublicationsService();
            ListPublications = service.GetPublication();
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
