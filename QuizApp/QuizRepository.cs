using System;
using System.Xml.Linq;

public class QuizRepository : IQuizRepository, IDisposable
{
    private AppDbContext context;
    private bool disposed = false;
    public QuizRepository(AppDbContext context)
	{
        this.context = context;
	}

    public void DeleteQuiz()
    {
    }


    public Quiz GetQuizById()
    {
        throw new NotImplementedException();
    }

    public Guid GetQuizId()
    {
        throw new NotImplementedException();
    }

    public string GetQuizScore()
    {
        throw new NotImplementedException();
    }

    public string GetQuizState()
    {
        throw new NotImplementedException();
    }

    public void ModifyQuizScore()
    {
        throw new NotImplementedException();
    }

    public void ModifyQuizState()
    {
        throw new NotImplementedException();
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
