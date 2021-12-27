using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Repositories
{
    public class QuestionRepository : CRUDRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<Question> GetAllQuestionsByQuizId(Guid quizId)
        {
            return GetAll().Where(q => q.QuizId == quizId);
        }
    }
}
