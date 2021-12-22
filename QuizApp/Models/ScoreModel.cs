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

        public ScoreModel(Score s)
        {
            Id = s.Id;
            Pseudo = s.Pseudo;
            Value = s.Value;
        }

        [JsonConstructor]
        public ScoreModel(Guid id, string pseudo, int value)
        {
            Id = id;
            Pseudo = pseudo;
            Value = value;
        }
    }
}
