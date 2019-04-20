﻿using System.Collections.Generic;
using CollectionViewChallenge.Models;
using CollectionViewChallenge.Services;
using Microsoft.Extensions.DependencyInjection;
using MvvmHelpers;
using System.Linq;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel
        : BaseViewModel
    {
        private readonly ITimelineService _timelineService;

        public CollectionViewChallengeViewModel()
        {
            _timelineService = App.ServiceProvider.GetRequiredService<ITimelineService>();

            TimelineItems = _timelineService.GetTimelineItems(10).ToList();
        }

        public List<TimelineItem> TimelineItems { get; set; }

    }
}
