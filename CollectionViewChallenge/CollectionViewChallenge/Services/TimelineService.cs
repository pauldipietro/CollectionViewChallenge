using Bogus;
using CollectionViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionViewChallenge.Services
{
    public class TimelineService
        : ITimelineService
    {
        private readonly List<Member> _members;

        public TimelineService() =>
            _members = GenerateFakeMembers(5);

        public List<TimelineItem> GetTimelineItems(int amount) => 
            new Faker<TimelineItem>()
                .RuleFor(item => item.Created, (faker, item) => faker.Date.Past(1, DateTime.Now))
                .RuleFor(item => item.Message, (faker, item) => faker.Lorem.Lines(2))
                .RuleFor(item => item.Member, (faker, item) => _members.First())
                .RuleFor(item => item.Reactions, (faker, item) => GenerateFakeReactions(3, item.Member, item.Created))
                .Generate(amount);
        
        private List<Member> GenerateFakeMembers(int number) =>
            new Faker<Member>()
                .RuleFor(member => member.Id, (faker, member) => Guid.NewGuid())
                .RuleFor(member => member.FirstName, (faker, member) => faker.Person.FirstName)
                .RuleFor(member => member.LastName, (faker, member) => faker.Person.LastName)
            .Generate(number);

        private List<Reaction> GenerateFakeReactions(int amount, Member excludedMember, DateTime createdAfter) =>
            new Faker<Reaction>()
                .RuleFor(reaction => reaction.ReactionType, (faker, reaction) =>
                    faker.Random.ListItem<ReactionType>(Enum.GetValues(typeof(ReactionType)).Cast<ReactionType>().ToList()))
                .RuleFor(reaction => reaction.Member, (faker, reaction) =>
                    faker.Random.ListItem<Member>(_members.Where(member => member.Id != excludedMember.Id).ToList()))
                .RuleFor(reaction => reaction.Created, (faker, reaction) => faker.Date.Between(createdAfter, DateTime.Now))
            .Generate(amount);
    }
}
