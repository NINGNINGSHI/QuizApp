using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Entity
{
    [Table("question")]
    public class Question : EntityWithId
    {
        public string Desc { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public Guid QuizId { get; set; }

        public Question(string desc, ICollection<Answer> answers)
        {
            Desc = desc;
            Answers = answers;
        }

        public Question(Guid quizId, string desc, ICollection<Answer> answers)
        {
            QuizId = quizId;
            Desc = desc;
            Answers = answers;
        }

        /**
         * EF CONSTRUCTOR
         */
        private Question(string desc)
        {
            Desc = desc;
        }
    }
}
