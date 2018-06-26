namespace Mapper {
    interface IMapper<TModel, TEntity>
        where TModel : class
        where TEntity : class {
        TEntity ToModel(TModel model);
        TModel ToEntity(TEntity entity);
    }
}
