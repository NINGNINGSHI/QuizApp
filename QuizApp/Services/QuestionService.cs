using QuizApp.Entity;
using QuizApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public class QuestionService : CRUDService<Question>, IQuestionService
    {
        private IQuestionRepository _Repository;
        public QuestionService(IQuestionRepository repository) : base(repository)
        {
            _Repository = repository;
        }
    }
}
