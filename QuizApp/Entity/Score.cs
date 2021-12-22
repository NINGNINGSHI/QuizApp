using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Entity
{
    [Table("score")]
    public class Score : EntityWithId
    {
        public string Pseudo { get; set; }
        public int Value { get; set; }
        public Quiz Quiz { get; set; }
        public Score(string pseudo, int value)
        {
            Pseudo = pseudo;
            Value = value;
        }
    }


}
