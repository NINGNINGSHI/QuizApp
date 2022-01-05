using QuizApp.Entity;
using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Utils
{
    public class Mappers
    {
        public static ICollection<Answer> ConvertAnswerModelsToEntity
            (ICollection<AnswerModel> model)
        {
            ICollection<Answer> answers = new List<Answer>();
            foreach(AnswerModel m in model)
            {
                answers.Add(new Answer(m.Desc, m.RightAnswer));
            }
            return answers;
        }
    }
}
