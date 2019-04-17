namespace CollectionViewChallenge.Models
{
    public abstract class BasePrioritiesItem
    {
        public string SystemName { get; set; }

        public override string ToString()
        {
            return SystemName;
        }
    }
}
