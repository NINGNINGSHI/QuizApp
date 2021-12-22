using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Entity
{
    [Table("answer")]
    public class Answer : EntityWithId
    {
        public string Desc { get; set; }
        public bool RightAnswer { get; set; }
        public Question Question { get; set; }
        public Answer(string desc, bool rightAnswer)
        {
            Desc = desc;
            RightAnswer = rightAnswer;
        }
    }

}
