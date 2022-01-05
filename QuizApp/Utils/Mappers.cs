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

        public static ICollection<AnswerModel> ConvertEntityToAnswerModels
        (ICollection<Answer> model)
        {
            ICollection<AnswerModel> answers = new List<AnswerModel>();
            foreach (Answer m in model)
            {
                answers.Add(new AnswerModel(m.Desc, m.RightAnswer));
            }
            return answers;
        }


        public static ICollection<CreateQuestionModel> ConvertQuestionEntityToModels
            (IEnumerable<Question> questions)
        {
            ICollection<CreateQuestionModel> res = new List<CreateQuestionModel>();
            foreach (Question q in questions)
            {
                res.Add(new CreateQuestionModel(q.QuizId, q.Desc,
                    ConvertEntityToAnswerModels(q.Answers)));
            }
            return res;
        }
    }
}
