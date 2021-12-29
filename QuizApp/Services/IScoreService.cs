using QuizApp.Entity;
using System;
using System.Collections.Generic;

namespace QuizApp.Services
{
    public interface IScoreService : ICRUDService<Score>
    {
        IEnumerable<Score> GetRankOfQuiz(Guid quizId);
    }
}
