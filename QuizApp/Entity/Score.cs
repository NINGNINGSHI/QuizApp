using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuizApp.Entity
{
    [Table("score")]
    public class Score : EntityWithId
    {
        [Required]
        public string Pseudo { get; set; }
        [Required]
        public int Value { get; set; }
        [Required]
        public Guid QuizId { get; set; }
        [JsonIgnore]
        public Quiz Quiz { get; set; }

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
