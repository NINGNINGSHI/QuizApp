using System;
using System.Linq;

namespace QuizApp
{
	public interface IQuizRepository : ICRUDRepository<Quiz>
	{
		IQueryable<Quiz> GetByStateType(StateType type);
	}
}
