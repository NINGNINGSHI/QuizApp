using Microsoft.EntityFrameworkCore;
using QuizApp.Entity;
using System;
using System.Linq;

namespace QuizApp.Repositories
{
    public class QuestionRepository : CRUDRepository<Question>, IQuestionRepository
    {
        AppDbContext _context;
        public QuestionRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Question> GetAllQuestionsByQuizId(Guid quizId)
        {
            return GetAll().Include(q => q.Answers).Where(q => q.QuizId == quizId);
        }

    }
}
