using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class DisplayAllQuestionsModel
    {
        public ICollection<Question> Questions { get; set; }

        public DisplayAllQuestionsModel(IEnumerable<Question> questions)
        {
            Questions = new List<Question>(questions);
        }
    }
}
