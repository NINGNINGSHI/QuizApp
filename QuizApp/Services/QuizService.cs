using QuizApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApp.Services
{
    public class QuizService : CRUDService<Quiz>, IQuizService
    {
        private IQuizRepository _Repository;

        public QuizService(IQuizRepository repository) : base(repository)
        {
            _Repository = repository;
        }

        public IEnumerable<Quiz> GetByStateType(StateType type)
        {
            return _Repository.GetByStateType(type);
        }

        public void PublishQuiz(Guid quizId)
        {
            Quiz quiz = _Repository.GetById(quizId);
            quiz.State = StateType.Published;
            _Repository.Update(quiz);
        }

        public bool CheckPassword(Guid quizId, string password)
        {
            return PasswordUtil.ConfirmPassword(password,
                _Repository.GetById(quizId).Salt,
                _Repository.GetById(quizId).Password);
        }

        public bool IsQuizTitleExist(string title)
        {
            return _Repository.GetAll().Where(t => t.Title.Equals(title)).Count() != 0;
        }

        public void UpdateRate(Guid quizId, int rate)
        {
            Quiz quiz = _Repository.GetById(quizId);
            quiz.Rate = rate;
            _Repository.Update(quiz);
        }
    }
}
