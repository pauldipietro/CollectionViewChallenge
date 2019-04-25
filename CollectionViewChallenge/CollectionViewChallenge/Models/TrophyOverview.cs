using MvvmHelpers;

namespace CollectionViewChallenge.Models
{
    public class TrophyOverview : ObservableObject
    {
        private int m_bronze;
        public int Bronze
        {
            get => m_bronze;
            set => SetProperty(ref m_bronze, value, onChanged: RaiseTotalChanged);
        }

        private int m_silver;
        public int Silver
        {
            get => m_silver;
            set => SetProperty(ref m_silver, value, onChanged: RaiseTotalChanged);
        }

        private int m_gold;
        public int Gold
        {
            get => m_gold;
            set => SetProperty(ref m_gold, value, onChanged: RaiseTotalChanged);
        }

        private int m_platinum;
        public int Platinum
        {
            get => m_platinum;
            set => SetProperty(ref m_platinum, value, onChanged: RaiseTotalChanged);
        }

        public int Total
        {
            get => Bronze + Silver + Gold + Platinum;
        }

        private void RaiseTotalChanged()
        {
            OnPropertyChanged(nameof(Total));
        }
    }
}
