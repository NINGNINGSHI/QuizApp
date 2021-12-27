using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public interface IQuizService : ICRUDService<Quiz>
    {
        public IEnumerable<Quiz> GetByStateType(StateType type);

        public void PublishQuiz(Guid quizId);
    }
}
