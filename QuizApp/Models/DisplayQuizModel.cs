using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class DisplayQuizModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public StateType State { get; set; }
        public string Password { get; set; }
        public int Rate { get; set; }

        public DisplayQuizModel(Quiz quiz)
        {
            Id = quiz.Id;
            Title = quiz.Title;
            State = quiz.State;
            Password = quiz.Password;
            Rate = quiz.Rate;
        }
    }
}
