using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuizApp.Entity
{
    [Table("answer")]
    public class Answer : EntityWithId
    {
        public string Desc { get; set; }
        public bool RightAnswer { get; set; }
        public Guid QuestionId { get; set; }
        [JsonIgnore]
        public Question Question{ get; set; }

        [JsonConstructor]
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
