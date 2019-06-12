using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Crud.Persistence
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllWithIncludes(Expression<Func<TEntity, object>> ColumnProperty);
        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> predicate);
        TEntity FindSingle(Expression<Func<TEntity, bool>> predicate);
        TEntity GetSingle(int Id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void SaveChanges();




    }
}
