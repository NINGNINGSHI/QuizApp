﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace QuizApp.Entity
{
    [Table("question")]
    public class Question : EntityWithId
    {
        public string Desc { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public Guid QuizId { get; set; }
        [JsonIgnore]
        public virtual Quiz Quiz { get; set; }

        //Pour créer une question
        public Question(Guid quizId, string desc, ICollection<Answer> answers)
        {
            QuizId = quizId;
            Desc = desc;
            Answers = answers;
        }

        //Pour modifier une question
        public Question(Guid id, Guid quizId, string desc, ICollection<Answer> answers)
        {
            Id = id;
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
