using Microsoft.EntityFrameworkCore;
using QuizApp.Entity;
using QuizApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void UpdateQuestionWithAnswers(Question question)
        {
            var q = _Repository.GetAll().Include(x => x.Answers)
                .FirstOrDefault(x => x.Id == question.Id);           
            q.Answers.Clear();
            foreach(Answer a in question.Answers) {
                q.Answers.Add(a);
            }
            q.Desc = question.Desc;
            Update(q);
        }
    }
}
