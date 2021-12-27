using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class ScoreModel
    {
        public Guid Id { get; set; }
        public string Pseudo { get; set; }
        public int Value { get; set; }
        public Guid QuizId { get; set; }

        public ScoreModel(Score s)
        {
            Id = s.Id;
            QuizId = s.QuizId;
            Pseudo = s.Pseudo;
            Value = s.Value;
        }

        [JsonConstructor]
        public ScoreModel(Guid quizId, string pseudo, int value)
        {
            QuizId = quizId;
            Pseudo = pseudo;
            Value = value;
        }
    }
}
