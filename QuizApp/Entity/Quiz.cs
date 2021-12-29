using QuizApp.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public Quiz(string title, string password, string salt)
        {
            Title = title;
            State = StateType.Draft;
            Password = password;
            Salt = salt;
            Rate = 0;
        }
    }
}
public enum StateType
{
    Draft = 0,
    Published = 1
}