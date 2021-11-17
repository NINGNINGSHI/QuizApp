using System;
using System.Linq;

namespace QuizApp
{
    public class QuizRepository : CRUDRepository<Quiz>, IQuizRepository
    {

        public QuizRepository(AppDbContext context) : base(context)
        {

        }   

        public int GetQuizScore()
        {
            throw new NotImplementedException();
        }

        public string GetQuizState()
        {
            throw new NotImplementedException();
        }

        public string GetQuizTitle()
        {
            throw new NotImplementedException();
        }
    }
}
