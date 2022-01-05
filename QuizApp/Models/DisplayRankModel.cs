using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class DisplayRankModel
    {
        public Guid Id { get; set; }
        public string Pseudo { get; set; }
        public int Value { get; set; }

        public DisplayRankModel(Score score)
        {
            Id = score.Id;
            Pseudo = score.Pseudo;
            Value = score.Value;
        }
    }
}
