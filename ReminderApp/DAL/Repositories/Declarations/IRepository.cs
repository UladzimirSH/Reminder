using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL.Repositories.Declarations {
    public interface IRepository<TModel> where TModel : class {
        TModel Get(int id);
        IEnumerable<TModel> GetAll();
        IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate);

        void Add(TModel entity);
        void AddRange(IEnumerable<TModel> entities);

        void Remove(TModel entit);
        void RemoveRange(IEnumerable<TModel> entities);
        void RemoveRange(IEnumerable<int> ids);

        void Commit();
    }
}
