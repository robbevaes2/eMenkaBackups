using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.VehicleMappers
{
    public class InteriorColorMapper
    {
        public InteriorColorReturnModel MapInteriorColorEntity(InteriorColor interiorColor)
        {
            if (interiorColor == null)
                return null;
            return new InteriorColorReturnModel
            {
                Id = interiorColor.Id,
                Code = interiorColor.Code,
                Name = interiorColor.Name
            };
        }
    }
}