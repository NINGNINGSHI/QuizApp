using QuizApp.Entity;
using System;
using System.Linq;

namespace QuizApp.Repositories
{
    public interface IScoreRepository : ICRUDRepository<Score>
    {
        IQueryable<Score> GetScoreByQuizId(Guid quizId);
    }
}
