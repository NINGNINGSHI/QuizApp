using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Repositories
{
    public interface IScoreRepository : ICRUDRepository<Score>
    {
        IQueryable<Score> GetScoreByQuizId(Guid quizId);
    }
}
