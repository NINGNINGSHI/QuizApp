using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Repositories
{
    public interface IQuestionRepository : ICRUDRepository<Question>
    {
        IQueryable<Question> GetAllQuestionsByQuizId(Guid quizId);
    }
}
