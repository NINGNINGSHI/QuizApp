using System;

namespace QuizApp
{
	public interface IQuizRepository : ICRUDRepository<Quiz>
	{
		string GetQuizState();
		string GetQuizTitle();
		int GetQuizScore();
	}
}
