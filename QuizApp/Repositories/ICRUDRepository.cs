using System;
using System.Linq;

/**
 *  Permettra les opérations basiques CRUD sur n’importe quelle entité 
*/
namespace QuizApp
{
    public interface ICRUDRepository<T>
    {
        T GetById(Guid id);
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
    }
}

