using CollectionViewChallenge.Models;
using System.Collections.Generic;

namespace CollectionViewChallenge.Services
{
    public interface ITimelineService
    {
        List<TimelineItem> GetTimelineItems(int amount);
    }
}
