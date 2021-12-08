using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp
{
    public class QuizModel
    {
        private Guid Id;
        private string Title;
        public QuizModel(Quiz quiz)
        {
            quiz.Id = Id;
            quiz.Title = Title;
        }
        
    }
}
