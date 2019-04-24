using System;
using System.Collections.Generic;

namespace CollectionViewChallenge.Models
{
    public class GroupPodcast : List<Podcast>
    {
        public string GroupName { get; set; }

        public GroupPodcast(string groupName, IList<Podcast> podcasts)
        {
            GroupName = groupName;
            AddRange(podcasts);
        }
    }
}
