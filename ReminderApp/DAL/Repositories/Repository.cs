using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DAL.Repositories.Declarations;
using Models;

namespace DAL.Repositories {
	public class Repository<TModel> : IRepository<TModel> where TModel : ModelBase {
		protected readonly DbContext Context;

		public Repository(DbContext context) {
			Context = context;
		}

		public TModel Get(int id) {
			return Context.Set<TModel>().Find(id);
		}

		public IEnumerable<TModel> GetAll() {
			return Context.Set<TModel>().ToList();
		}

		public IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate) {
			return Context.Set<TModel>().Where(predicate);
		}

		public void Add(TModel entity) {

			Context.Set<TModel>().Add(entity);
		}

		public void AddRange(IEnumerable<TModel> entities) {
			Context.Set<TModel>().AddRange(entities);
		}

		public void Remove(TModel entity) {
			Context.Set<TModel>().Remove(entity);
		}

		public void RemoveRange(IEnumerable<TModel> entities) {
			Context.Set<TModel>().RemoveRange(entities);
		}

	    public void Commit() {
	        Context.SaveChanges();
	    }
	}
}
