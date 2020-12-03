namespace eMenka.API.Mappers
{
    public interface IMapper<TEntity, in TModel, out TReturnModel>
    {
        TReturnModel MapEntityToReturnModel(TEntity entity);
        TEntity MapModelToEntity(TModel model);
    }
}