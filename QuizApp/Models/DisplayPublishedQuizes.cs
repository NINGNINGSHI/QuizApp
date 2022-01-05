using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class DisplayPublishedQuizes
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Rate { get; set; }

        public DisplayPublishedQuizes(Quiz quiz)
        {
            Id = quiz.Id;
            Rate = quiz.Rate;
            Title = quiz.Title;
        }
    }
}
