using System;

public interface IQuizRepository : IDisposable
{
	Guid GetQuizId();
	Quiz GetQuizById();
	string GetQuizState();
	string GetQuizScore();
	void DeleteQuiz();
	void ModifyQuizState();
	void ModifyQuizScore();

}
