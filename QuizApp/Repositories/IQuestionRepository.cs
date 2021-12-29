using QuizApp.Entity;
using System;
using System.Linq;

namespace QuizApp.Repositories
{
    public interface IQuestionRepository : ICRUDRepository<Question>
    {
        IQueryable<Question> GetAllQuestionsByQuizId(Guid quizId);
    }
}
