using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace QuizApp
{
    public class QuizRepository : CRUDRepository<Quiz>, IQuizRepository
    {
        public QuizRepository(AppDbContext context) : base(context)
        {
        }   
        
        public IQueryable<Quiz> GetByStateType(StateType type)
        {
            return GetAll().Where(s => s.State == type);
        }
    }
}
