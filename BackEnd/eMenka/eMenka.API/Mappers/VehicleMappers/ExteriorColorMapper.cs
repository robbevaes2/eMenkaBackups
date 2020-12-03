using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class ExteriorColorMapper
    {
        public ExteriorColorReturnModel MapExteriorColorEntity(ExteriorColor exteriorColor)
        {
            if (exteriorColor == null)
                return null;
            return new ExteriorColorReturnModel
            {
                Code = exteriorColor.Code,
                Id = exteriorColor.Id,
                Name = exteriorColor.Name
            };
        }
    }
}