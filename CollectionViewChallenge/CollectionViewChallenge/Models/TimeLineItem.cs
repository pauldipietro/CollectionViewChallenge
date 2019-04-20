using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Humanizer;
using Xamarin.Forms;
using MvvmHelpers;

namespace CollectionViewChallenge.Models
{
    public class TimelineItem : BaseViewModel
    {
        public TimelineItem()
        {
            Reactions = new List<Reaction>();
        }

        public Guid Id { get; set; }
     
        public Member Member { get; set; }

        public string Message { get; set; }

        public string ImageUrl { get; set; }

        private List<Reaction> _reactions;
        public List<Reaction> Reactions
        {
            get => _reactions;
            set => SetProperty(ref _reactions, value);
        }

        public string ReactionsText
        {
            get
            {
                if (Reactions.Any())
                    return $"({Reactions.Count})";

                return string.Empty;
            }
        }

        public string LikeImage => Reactions.Any(reaction => reaction.Member.Id == App.CurrentUser.Id) ? "liked" : "like";

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public DateTime Created { get; set; } = DateTime.Now;

        public string HumanizedDate => Created.Humanize();

        public ICommand AddReactionCommand => new Command(AddReaction);

        private void AddReaction()
        {
            Reactions.Add(new Reaction
            {
                Member = App.CurrentUser,
                ReactionType = ReactionType.Like,
                Created = DateTime.Now
            });

            OnPropertyChanged(nameof(ReactionsText));
            OnPropertyChanged(nameof(LikeImage));
        }
    }
}
