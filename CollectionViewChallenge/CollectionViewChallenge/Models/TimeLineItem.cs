using System;
using System.Collections.Generic;

namespace CollectionViewChallenge.Models
{
    public class TimeLineItem
    {
        public Guid Id { get; set; }
        public Member Member { get; set; }

        public string Message { get; set; }

        public string ImageUrl { get; set; }

        public List<Reaction> Reactions { get; set; }

        public List<Comment> Comments { get; set; }

        public DateTime Created { get; set; }
    }
}
