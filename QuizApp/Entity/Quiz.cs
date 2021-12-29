using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace QuizApp
{
    [Table("quiz")]
    public class Quiz : EntityWithId
    {
        [Required]
        public string Title { get; set; }
        public StateType State { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Salt { get; set; }
        public ICollection<Score> ScoreBoard { get; set; }
        public ICollection<Question> Questions { get; set; }
        public int Rate { get; set; }

        //new Quiz
        public Quiz(string title, /*StateType state,*/ string password, string salt)
        {
            Title = title;
            State = StateType.Draft;
            Password = password;
            Salt = salt;
            Rate = 0;
        }
       
        /*
        //Quiz already exist
        public Quiz(string title, StateType state, string password, ICollection<Score> scoreBoard, 
            ICollection<Question> questions, int rate) //: this(title, state, password)
        {
            Title = title;
            State = state;
            Password = password;
            ScoreBoard = scoreBoard;
            Questions = questions;
            Rate = rate;
        }
        */
    }
}
public enum StateType
{
    Draft = 0,
    Published = 1
}