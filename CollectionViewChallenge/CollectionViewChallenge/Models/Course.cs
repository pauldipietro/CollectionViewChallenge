using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewChallenge.Models
{
    public class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ReviewsWords { get; set; }
        public int DifficultWords { get; set; }
        public string ImageUrl { get; set; }
    }
}
