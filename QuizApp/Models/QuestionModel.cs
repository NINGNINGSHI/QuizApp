﻿using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class QuestionModel
    {
        public Guid Id { get; set; }
        public string Desc { get; set; }
        public ICollection<Answer> Answers { get; set; }

        public QuestionModel(Question q)
        {
            Id = q.Id;
            Desc = q.Desc;
            Answers = q.Answers;
        }

        [JsonConstructor]
        public QuestionModel(Guid id, string desc, ICollection<Answer> answers)
        {
            Id = id;
            Desc = desc;
            Answers = answers;
        }
    }
}
