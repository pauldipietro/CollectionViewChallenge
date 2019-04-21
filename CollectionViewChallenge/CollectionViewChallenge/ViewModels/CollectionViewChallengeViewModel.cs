using CollectionViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel : BaseViewModel
    {
        private ObservableCollection<Course> _courses;

        public ObservableCollection<Course> Courses
        {
            get { return _courses; }
            set { SetProperty(ref _courses, value); }
        }


        public CollectionViewChallengeViewModel()
        {
            Courses = new ObservableCollection<Course>
            {
                new Course
                {
                    Title = "16 - Words and Phrases",
                    Description = "Contamination",
                    ReviewsWords = 19,
                    DifficultWords = 7,
                    ImageUrl = "https://spaceholder.cc/256x256?id=1"
                },
                new Course
                {
                    Title = "15 - Words and Phrases",
                    Description = "In Disguise",
                    ReviewsWords = 19,
                    DifficultWords = 1,
                    ImageUrl = "https://spaceholder.cc/256x256?id=2"
                },
                new Course
                {
                    Title = "14 - Words and Phrases",
                    Description = "Cracking Kanji",
                    ReviewsWords = 5,
                    DifficultWords = 0,
                    ImageUrl = "https://spaceholder.cc/256x256?id=3"
                },
                new Course
                {
                    Title = "13 - Words and Phrases",
                    Description = "Fuel Your Vocab: Human Parts",
                    ReviewsWords = 21,
                    DifficultWords = 0,
                    ImageUrl = "https://spaceholder.cc/256x256?id=4"
                },
                new Course
                {
                    Title = "12 - Words and Phrases",
                    Description = "Fuel Your Vocab: Types of Humans",
                    ReviewsWords = 15,
                    DifficultWords = 1,
                    ImageUrl = "https://spaceholder.cc/256x256?id=4"
                },
                new Course
                {
                    Title = "11 - Words and Phrases",
                    Description = "Cracking Kanji",
                    ReviewsWords = 6,
                    DifficultWords = 0,
                    ImageUrl = "https://spaceholder.cc/256x256?id=5"
                },
                new Course
                {
                    Title = "10 - Words and Phrases",
                    Description = "Fuel Your Vocab: Places to Explore",
                    ReviewsWords = 13,
                    DifficultWords = 2,
                    ImageUrl = "https://spaceholder.cc/256x256?id=6"
                },
                new Course
                {
                    Title = "9 - Words and Phrases",
                    Description = "Found in Space",
                    ReviewsWords = 26,
                    DifficultWords = 0,
                    ImageUrl = "https://spaceholder.cc/256x25?id=7"
                },
                new Course
                {
                    Title = "8 - Words and Phrases",
                    Description = "Cracking Kanji",
                    ReviewsWords = 6,
                    DifficultWords = 0,
                    ImageUrl = "https://spaceholder.cc/256x256?id=8"
                },
                new Course
                {
                    Title = "7 - Words and Phrases",
                    Description = "Retail Therapy",
                    ReviewsWords = 16,
                    DifficultWords = 2,
                    ImageUrl = "https://spaceholder.cc/256x256?id=9"
                },
                new Course
                {
                    Title = "6 - Words and Phrases",
                    Description = "Getting Fed",
                    ReviewsWords = 15,
                    DifficultWords = 1,
                    ImageUrl = "https://spaceholder.cc/256x256?id=10"
                },
                new Course
                {
                    Title = "5 - Words and Phrases",
                    Description = "Cracking Kanji",
                    ReviewsWords = 6,
                    DifficultWords = 1,
                    ImageUrl = "https://spaceholder.cc/256x256?id=11"
                },
                new Course
                {
                    Title = "4 - Words and Phrases",
                    Description = "Lost in Space",
                    ReviewsWords = 7,
                    DifficultWords = 0,
                    ImageUrl = "https://spaceholder.cc/256x256?id=12"
                },
                new Course
                {
                    Title = "3 - Words and Phrases",
                    Description = "Fuel Your Vocab: Places",
                    ReviewsWords = 19,
                    DifficultWords = 2,
                    ImageUrl = "https://spaceholder.cc/256x256?id=13"
                },
                new Course
                {
                    Title = "2 - Words and Phrases",
                    Description = "Cracking Kanji",
                    ReviewsWords = 6,
                    DifficultWords = 1,
                    ImageUrl = "https://spaceholder.cc/256x256?id=14"
                },
                new Course
                {
                    Title = "1 - Words and Phrases",
                    Description = "Phrases: Make the Laugh",
                    ReviewsWords = 13,
                    DifficultWords = 0,
                    ImageUrl = "https://spaceholder.cc/256x256?id=15"
                }
            };
        }
    }
}
