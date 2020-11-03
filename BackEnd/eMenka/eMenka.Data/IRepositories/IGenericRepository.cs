using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace eMenka.Data.IRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> statement);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        bool Update(int id, TEntity entity);
        void Save();
    }
}