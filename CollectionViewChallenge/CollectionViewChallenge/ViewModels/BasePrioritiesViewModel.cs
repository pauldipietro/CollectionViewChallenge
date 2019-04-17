using System;
using System.Windows.Input;

namespace CollectionViewChallenge.ViewModels
{
    public abstract class BasePrioritiesViewModel : BaseViewModel
    {
        #region Properties

        public ICommand RetryDownloadCommand { get; protected set; }

        private string _cycle;
        public string Cycle
        {
            get { return _cycle; }
            protected set
            {
                if (_cycle != value)
                {
                    _cycle = value;
                    OnPropertyChanged(nameof(Cycle));
                }
            }
        }

        private DateTime _lastUpdated;
        public DateTime LastUpdated
        {
            get { return _lastUpdated; }
            protected set
            {
                if (_lastUpdated != value)
                {
                    _lastUpdated = value;
                    OnPropertyChanged(nameof(LastUpdated));
                }
            }
        }

        private bool _showMessage;
        public bool ShowMessage
        {
            get { return _showMessage; }
            protected set
            {
                if (_showMessage != value)
                {
                    _showMessage = value;
                    OnPropertyChanged(nameof(ShowMessage));
                }
            }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            protected set
            {
                if (_message != value)
                {
                    _message = value;
                    OnPropertyChanged(nameof(Message));
                }
            }
        }

        private bool _isErrorMessage;
        public bool IsErrorMessage
        {
            get { return _isErrorMessage; }
            protected set
            {
                if (_isErrorMessage != value)
                {
                    _isErrorMessage = value;
                    OnPropertyChanged(nameof(IsErrorMessage));
                }
            }
        }

        #endregion
    }
}
