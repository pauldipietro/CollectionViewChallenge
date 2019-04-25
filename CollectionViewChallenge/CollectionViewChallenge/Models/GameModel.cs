using MvvmHelpers;
using System.Collections.Generic;

namespace CollectionViewChallenge.Models
{
    public class GameModel : ObservableObject
    {
        private string m_id;
        public string Id
        {
            get => m_id;
            set => SetProperty(ref m_id, value);
        }

        private string m_title;
        public string Title
        {
            get => m_title;
            set => SetProperty(ref m_title, value);
        }

        private string m_icon;
        public string Icon
        {
            get => m_icon;
            set => SetProperty(ref m_icon, value);
        }

        private string m_detail;
        public string Detail
        {
            get => m_detail;
            set => SetProperty(ref m_detail, value);
        }

        private GamePlatform m_platforms;
        public GamePlatform Platforms
        {
            get => m_platforms;
            set => SetProperty(ref m_platforms, value, onChanged: () => OnPropertyChanged(nameof(PlatformTags)));
        }

        private TrophyOverview m_trophies;
        public TrophyOverview Trophies
        {
            get => m_trophies;
            set => SetProperty(ref m_trophies, value);
        }

        private TrophyOverview m_earnedTrophies;
        public TrophyOverview EarnedTrophies
        {
            get => m_earnedTrophies;
            set => SetProperty(ref m_earnedTrophies, value);
        }

        private int m_progress;
        public int Progress
        {
            get => m_progress;
            set => SetProperty(ref m_progress, value);
        }

        private string m_lastUpdatedDate;
        public string LastUpdatedDate
        {
            get => m_lastUpdatedDate;
            set => SetProperty(ref m_lastUpdatedDate, value);
        }

        public IEnumerable<string> PlatformTags
        {
            get
            {
                if (Platforms == GamePlatform.None)
                    return null;

                string[] tags = Platforms.ToString()?.Replace(" ", string.Empty)?.Split(',');
                return tags;
            }
        }
    }
}
