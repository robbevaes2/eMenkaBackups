using eMenka.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace eMenka.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly EfenkaContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(EfenkaContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            var entities = _dbSet.ToList();
            return entities;
        }

        public virtual TEntity GetById(int id)
        {
            var entity = _dbSet.Find(id);
            return entity;
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> statement)
        {
            var entities = _dbSet.Where(statement).ToList();

            return entities;
        }

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            Save();
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
            Save();
        }

        public virtual bool Update(int id, TEntity entity)
        {
            var originalEntity = _dbSet.Find(id);
            if (originalEntity == null) return false;

            _context.Entry(originalEntity).CurrentValues.SetValues(entity);
            Save();

            return true;
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}