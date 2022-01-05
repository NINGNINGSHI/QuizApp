using QuizApp.Entity;
using System;
using System.Collections.Generic;

namespace QuizApp.Services
{
    public interface IQuestionService : ICRUDService<Question>
    {
        IEnumerable<Question> GetAllQuestionsByQuizId(Guid quizId);

        void UpdateQuestionWithAnswers(Question question);
    }
}
