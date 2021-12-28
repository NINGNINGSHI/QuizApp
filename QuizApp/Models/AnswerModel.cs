using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class AnswerModel
    {
        public Guid Id { get; set; }
        public string Desc { get; set; }
        public bool RightAnswer { get; set; }
        public Guid QuestionId { get; set; }

        public AnswerModel(Answer q)
        {
            Id = q.Id;
            Desc = q.Desc;
            RightAnswer = q.RightAnswer;
            QuestionId = q.QuestionId;
        }

        [JsonConstructor]
        public AnswerModel(Guid questionId, string desc, bool rightAnswer)
        {
            QuestionId = questionId;
            Desc = desc;
            RightAnswer = rightAnswer;
        }
    }
}
