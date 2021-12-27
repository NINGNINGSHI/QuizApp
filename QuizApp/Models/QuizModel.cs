using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

/**
 * Pour front
 */
namespace QuizApp
{
    public class QuizModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public StateType State { get; set; }
        public string Password { get; set; }
        public ICollection<Score> ScoreBoard { get; set; }
        public ICollection<Question> Questions { get; set; }
        public int Rate { get; set; }

        public QuizModel(Quiz quiz)
        {
            Id = quiz.Id;
            Title = quiz.Title;
            State = quiz.State;
            Password = quiz.Password;
            ScoreBoard = quiz.ScoreBoard;
            Questions = quiz.Questions;
            Rate = quiz.Rate;
        }

        //quand reçu depuis front, pour créer un nouvel quiz
        [JsonConstructor]
        public QuizModel(string title, /*StateType state, */string password)
           // ICollection<Score> scoreBoard, List<Question> questions, int rate)
        {
            Title = title;
            //State = state;
            Password = password;
            //ScoreBoard = scoreBoard;
            //Questions = questions;
            //Rate = rate;
        }
        
    }
}
