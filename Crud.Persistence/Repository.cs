using Crud.Entitities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Crud.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class,IEntity
    {
        private readonly CrudDbContext context;

        public Repository(CrudDbContext context)
        {
            this.context = context;
        }
        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).AsEnumerable();
        }

        public TEntity FindSingle(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().AsEnumerable();
        }

        public IEnumerable<TEntity> GetAllWithIncludes(Expression<Func<TEntity, object>> ColumnProperty)
        {
            return context.Set<TEntity>().Include(ColumnProperty).AsEnumerable();
        }

        public TEntity GetSingle(int Id)
        {
            return context.Set<TEntity>().SingleOrDefault(e => e.Id == Id);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
        }
    }
}
