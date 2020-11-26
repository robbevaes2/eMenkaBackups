using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class CategoryMapper : IMapper<Category, CategoryModel, CategoryReturnModel>
    {
        public CategoryReturnModel MapEntityToReturnModel(Category entity)
        {
            if (entity == null)
                return null;
            return new CategoryReturnModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public Category MapModelToEntity(CategoryModel model)
        {
            return new Category
            {
                Name = model.Name,
                Id = model.Id
            };
        }
    }
}
