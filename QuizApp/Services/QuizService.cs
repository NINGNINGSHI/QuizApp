using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
