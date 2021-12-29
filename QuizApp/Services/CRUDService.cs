using System;
using System.Collections.Generic;

namespace QuizApp.Services
{
    public class CRUDService<T> : ICRUDService<T> where T : EntityWithId
    {
        private ICRUDRepository<T> _Repository;

        public CRUDService(ICRUDRepository<T> _repository)
        {
            _Repository = _repository;
        }

        public T Create(T entity)
        {
            return _Repository.Create(entity);
        }

        public void Delete(T entity)
        {
            _Repository.Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _Repository.GetAll();
        }

        public T GetById(Guid id)
        {
            return _Repository.GetById(id);
        }

        public T Update(T entity)
        {
            return _Repository.Update(entity);
        }
    }
}
