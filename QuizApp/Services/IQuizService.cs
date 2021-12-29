using System;
using System.Collections.Generic;

namespace QuizApp.Services
{
    public interface IQuizService : ICRUDService<Quiz>
    {
        IEnumerable<Quiz> GetByStateType(StateType type);

        void PublishQuiz(Guid quizId);
        bool CheckPassword(Guid quizId, string password);
        bool IsQuizTitleExist(string title);
    }
}
