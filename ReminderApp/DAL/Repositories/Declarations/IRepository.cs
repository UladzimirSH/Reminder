using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL.Repositories.Declarations {
    public interface IRepository<TEntity> where TEntity : class {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entit);
        void RemoveRange(IEnumerable<TEntity> entities);

        void Commit();
    }
}
