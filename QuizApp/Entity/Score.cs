using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace QuizApp.Entity
{
    [Table("score")]
    public class Score : EntityWithId
    {
        public string Pseudo { get; set; }
        public int Value { get; set; }
        public Guid QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }

        public Score(string pseudo, int value)
        {
            Pseudo = pseudo;
            Value = value;
        }

        public Score(Guid quizId, string pseudo, int value)
        {
            QuizId = quizId;
            Pseudo = pseudo;
            Value = value;
        }
    }


}
