using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace QuizApp.Entity
{
    [Table("answer")]
    public class Answer : EntityWithId
    {
        public string Desc { get; set; }
        public bool RightAnswer { get; set; }
        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public Answer(string desc, bool rightAnswer)
        {
            Desc = desc;
            RightAnswer = rightAnswer;
        }

        public Answer(Guid questionId, string desc, bool rightAnswer)
        {
            QuestionId = questionId;
            Desc = desc;
            RightAnswer = rightAnswer;
        }
    }

}
