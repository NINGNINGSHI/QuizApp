using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizApp.Models;

namespace QuizApp.Models
{
    public class DisplayAllQuestionsModel
    {
        public ICollection<DisplayUpdateQuestionModel> Questions { get; set; }

        public DisplayAllQuestionsModel(IEnumerable<DisplayUpdateQuestionModel> questions)
        {
            Questions = new List<DisplayUpdateQuestionModel>(questions);
        }
    }
}
