using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMenka.API.Mappers
{
    public interface IMapper<TEntity, in TModel, out TReturnModel>
    {
        TReturnModel MapEntityToReturnModel(TEntity entity);
        TEntity MapModelToEntity(TModel model);
    }
}
