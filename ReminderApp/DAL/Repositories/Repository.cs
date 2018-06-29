using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DAL.Mappers;
using DAL.Repositories.Declarations;
using Domain;
using Domain.Contexts;
using Domain.Entities;
using Models;

namespace DAL.Repositories {
	public class Repository<TModel, TEntity> : IRepository<TModel>
	    where TModel : ModelBase
        where TEntity : EntityBase{

		protected readonly DbContext Context;
	    private readonly IMapper<TModel, TEntity> _mapper;

		public Repository(IMapper<TModel, TEntity> mapper) {
			Context = new MainContext();
		    _mapper = mapper;
		}

		public TModel Get(int id) {
            var result =  Context.Set<TEntity>().Find(id);
		    return _mapper.ToModel(result);
		}

		public IEnumerable<TModel> GetAll() {
		    var result = Context.Set<TEntity>().ToList();
		    return result.Select(r => _mapper.ToModel(r));
		}

		public IEnumerable<TModel> Find(Expression<Func<TModel, bool>> predicate) {
			return new List<TModel>();  // Context.Set<TEntity>().Where(predicate);
		}

		public void Add(TModel entity) {
			Context.Set<TEntity>().Add(_mapper.ToEntity(entity));
		}

		public void AddRange(IEnumerable<TModel> entities) {
			Context.Set<TEntity>().AddRange(entities.Select(e => _mapper.ToEntity(e)));
		}

		public void Remove(TModel entity) {
			Context.Set<TEntity>().Remove(_mapper.ToEntity(entity));
		}

		public void RemoveRange(IEnumerable<TModel> entities) {
			Context.Set<TEntity>().RemoveRange(entities.Select(e => _mapper.ToEntity(e)));
		}

	    public void RemoveRange(IEnumerable<int> ids) {
	        Context.Set<TEntity>().RemoveRange(Context.Set<TEntity>().Where(c => ids.Contains(c.Id)));
	    }

        public void Commit() {
	        Context.SaveChanges();
	    }	
	}
}
