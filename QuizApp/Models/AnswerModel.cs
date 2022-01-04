using Newtonsoft.Json;
using QuizApp.Entity;
using System;

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
        public AnswerModel(string desc, bool rightAnswer)
        {
            Desc = desc;
            RightAnswer = rightAnswer;
        }
        
    }
}
