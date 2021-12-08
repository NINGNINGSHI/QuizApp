using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApp
{
    public class CRUDRepository<T> : ICRUDRepository<T> where T : EntityWithId
    {
        AppDbContext _context;

        public CRUDRepository(AppDbContext ctx)
        {
            _context = ctx;
        }

        public T Create(T entity)
        {
            var toRet = _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return toRet.Entity;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}

