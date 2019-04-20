using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollectionViewChallenge.Models
{
    public class TimelineItem
    {
        public Guid Id { get; set; }
        public Member Member { get; set; }

        public string Message { get; set; }

        public string ImageUrl { get; set; }

        public List<Reaction> Reactions { get; set; } = new List<Reaction>();

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public DateTime Created { get; set; } = DateTime.Now;

        public ICommand AddReactionCommand => new Command<ReactionType>((reactionType) => AddReaction(reactionType));

        private void AddReaction(ReactionType reactionType)
        {
            Reactions.Add(new Reaction
            {
                //Member = TODO context / current user fake
                ReactionType = reactionType,
                Created = DateTime.Now
            });
        }
    }
}
