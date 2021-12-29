using QuizApp.Entity;
using QuizApp.Repositories;
using System;
using System.Collections.Generic;

namespace QuizApp.Services
{
    public class QuestionService : CRUDService<Question>, IQuestionService
    {
        private IQuestionRepository _Repository;
        public QuestionService(IQuestionRepository repository) : base(repository)
        {
            _Repository = repository;
        }

        public IEnumerable<Question> GetAllQuestionsByQuizId(Guid quizId)
        {
            return _Repository.GetAllQuestionsByQuizId(quizId);
        }
    }
}
