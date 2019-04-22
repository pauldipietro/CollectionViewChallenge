using System.ComponentModel;
using System.Runtime.CompilerServices;
using CollectionViewChallenge.Extensions;
using Xamarin.Forms;

namespace CollectionViewChallenge.Views
{
    public class FeedCategory : INotifyPropertyChanged
    {
        public static FeedCategory ForCategory(string category)
            => new FeedCategory
            {
                Name = category,
                Image = ImageSource.FromFile($"{category.ToSafeAssetName()}.jpg")
            };

        public string Name { get; set; }
        public ImageSource Image { get; private set; }

        private bool _selected;
        public bool Selected
        {
            get { return _selected; }
            set
            {
                if (_selected != value)
                {
                    _selected = value;
                    OnPropertyChanged();
                }
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}