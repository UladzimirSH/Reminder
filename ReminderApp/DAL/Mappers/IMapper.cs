namespace DAL.Mappers {
    public interface IMapper<TModel, TEntity>
        where TModel : class
        where TEntity : class {
        TModel ToModel(TEntity model);
        TEntity ToEntity(TModel entity);
    }
}
