using System;

namespace QuizApp
{
    public class Quiz : EntityWithId
    {
        public String State { get; set; }
        public String Password { get; set; }
        public int Score { get; set; }

    }
}
