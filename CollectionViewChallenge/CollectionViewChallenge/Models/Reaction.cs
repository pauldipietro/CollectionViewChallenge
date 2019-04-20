using System;

namespace CollectionViewChallenge.Models
{
    public class Reaction
    {
        public Member Member { get; set; }

        public ReactionType ReactionType { get; set; }

        public DateTime Created { get; set; }
    }
}