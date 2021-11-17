﻿using System;

namespace QuizApp
{
    public class Quiz : EntityWithId
    {
        public string Title { get; set; }
        public StateType State;
        public string Password { get; set; }
        public int Score { get; set; }

    }
}
