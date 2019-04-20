using CollectionViewChallenge.Models;
using System.Collections.Generic;

namespace CollectionViewChallenge.Services
{
    public interface ITimelineService
    {
        List<Member> Members { get; }

        IEnumerable<TimelineItem> GetTimelineItems(int amount);
    }
}
