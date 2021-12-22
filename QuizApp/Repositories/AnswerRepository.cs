using QuizApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Repositories
{
    public class AnswerRepository : CRUDRepository<Answer>, IAnswerRepository
    {
        public AnswerRepository(AppDbContext context) : base(context)
        {

        }
    }
}
