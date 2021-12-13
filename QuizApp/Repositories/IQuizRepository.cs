using System;
using System.Linq;

/**
 * Gérer l’interaction entre votre application et votre base de données pour les Quiz 
*/
namespace QuizApp
{

	public interface IQuizRepository : ICRUDRepository<Quiz>
	{
		//IQueryable<Quiz> GetByStateType(StateType type);
	}
}
