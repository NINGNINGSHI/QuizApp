using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class DisplayDraftedQuizes
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public DisplayDraftedQuizes(Quiz quiz)
        {
            Id = quiz.Id;
            Title = quiz.Title;
        }
    }
}
