using System;

namespace QuizApp
{
    public class Quiz : EntityWithId
    {
        public string Title { get; set; }
        public StateType State;
        public string Password { get; set; }
        public int Score { get; set; }
        public Quiz(string Title, StateType State, string Password, int Score)
        {
            this.Title = Title;
            this.State = State;
            this.Password = Password;
            this.Score = Score;
        }
    }
}
