using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/**
 *  Gérer la logique métier et les opérations CRUD de vos Quiz 
 */
namespace QuizApp.Services
{
    public interface ICRUDService<T>
    {
        T GetById(Guid id);
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
