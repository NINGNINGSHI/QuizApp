using QuizApp.Entity;
using System;
using System.Linq;

namespace QuizApp.Repositories
{
    public class ScoreRepository : CRUDRepository<Score>, IScoreRepository
    {
        public ScoreRepository(AppDbContext context) : base(context)
        {

        }

        public IQueryable<Score> GetScoreByQuizId(Guid quizId)
        {
            return GetAll().Where(s => s.QuizId == quizId);
        }
    }
}
