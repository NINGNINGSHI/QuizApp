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
        = new List<Answer>();
        public Quiz Quiz { get; set; }
        public Question(string desc, ICollection<Answer> answers)
        {
            Answers = answers;
        }

        private Question(string desc)
        {
            Desc = desc;
        }

    }
}
