using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using NeohAutorizador.ApplicationCore.Interfaces.Repository;
using NeohAutorizador.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NeohAutorizador.Infrastructure.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly NeohAutorizadorContext _dbContext;
        protected IDbContextTransaction _contextTransaction;
        protected BaseRepository(NeohAutorizadorContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual TEntity Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }
        public virtual void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicado)
        {
            return _dbContext.Set<TEntity>().Where(predicado).AsEnumerable();
        }
        public virtual TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsEnumerable();
        }
        public virtual void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
        public virtual void BeginTransaction()
        {
            _contextTransaction = _dbContext.Database.BeginTransaction();
        }
        public virtual void Commit()
        {
            _contextTransaction.Commit();
        }
        public virtual void Rollback()
        {
            _contextTransaction.Rollback();
        }
        public virtual void Detached(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Detached;
        }
    }
}
