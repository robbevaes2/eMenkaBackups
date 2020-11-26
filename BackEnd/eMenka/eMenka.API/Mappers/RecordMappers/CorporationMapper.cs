using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.RecordMappers
{
    public class CorporationMapper : IMapper<Corporation, CorporationModel, CorporationReturnModel>
    {
        private CompanyMapper _companyMapper;

        public CorporationMapper()
        {
            _companyMapper = new CompanyMapper();
        }
        public CorporationReturnModel MapEntityToReturnModel(Corporation entity)
        {
            if (entity == null)
                return null;
            return new CorporationReturnModel
            {
                Abbreviation = entity.Abbreviation,
                Company = _companyMapper.MapEntityToReturnModel(entity.Company),
                EndDate = entity.EndDate,
                Id = entity.Id,
                Name = entity.Name,
                StartDate = entity.StartDate
            };
        }

        public Corporation MapModelToEntity(CorporationModel model)
        {
            return new Corporation
            {
                Abbreviation = model.Abbreviation,
                CompanyId = (int)model.CompanyId,
                EndDate = model.EndDate,
                Name = model.Name,
                Id = model.Id,
                StartDate = model.StartDate
            };
        }
    }
}
