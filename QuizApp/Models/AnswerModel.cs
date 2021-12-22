using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class AnswerModel
    {
        public Guid Id { get; set; }
        public string Desc { get; set; }

        public AnswerModel(Answer q)
        {
            Id = q.Id;
            Desc = q.Desc;
        }

        [JsonConstructor]
        public AnswerModel(Guid id, string desc)
        {
            Id = id;
            Desc = desc;
        }
    }
}
