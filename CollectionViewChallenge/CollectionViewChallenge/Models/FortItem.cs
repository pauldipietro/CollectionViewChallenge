using System;

namespace CollectionViewChallenge.Models
{
    public class FortItem : BasePrioritiesItem
    {
        public string DistanceToHQ { get; }
        public string StationPad { get; }
        public string StationDistance { get; }
        public string MajorFaction { get; }

        public FortItem(string systemName, string distanceToHQ, string stationPad, string stationDistance, string majorFaction)
        {
            SystemName = systemName;
            DistanceToHQ = distanceToHQ;
            StationPad = stationPad;
            StationDistance = stationDistance;
            MajorFaction = majorFaction;
        }

        public override string ToString()
        {
            return String.Format("{0} ({1}) - {2} ({3})", SystemName, DistanceToHQ, StationPad, StationDistance);
        }
    }
}
