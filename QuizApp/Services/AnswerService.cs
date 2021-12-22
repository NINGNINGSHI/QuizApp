using QuizApp.Entity;
using QuizApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Services
{
    public class AnswerService : CRUDService<Answer>, IAnswerService
    {
        private IAnswerRepository _Repository;
        public AnswerService(IAnswerRepository repository) : base(repository)
        {
            _Repository = repository;
        }
    }
}
