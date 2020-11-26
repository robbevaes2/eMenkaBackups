using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.RecordMappers
{
    public class CompanyMapper : IMapper<Company, CompanyModel, CompanyReturnModel>
    {
        public CompanyReturnModel MapEntityToReturnModel(Company entity)
        {
            if (entity == null)
                return null;
            return new CompanyReturnModel
            {
                Name = entity.Name,
                AccountNumber = entity.AccountNumber,
                Description = entity.Description,
                Id = entity.Id,
                IsActive = entity.IsActive,
                IsInternal = entity.IsInternal,
                NonActiveRemark = entity.NonActiveRemark,
                Reference = entity.Reference,
                VAT = entity.VAT
            };
        }

        public Company MapModelToEntity(CompanyModel model)
        {
            return new Company
            {
                AccountNumber = model.AccountNumber,
                Description = model.Description,
                Id = model.Id,
                IsActive = model.IsActive,
                IsInternal = model.IsInternal,
                Name = model.Name,
                NonActiveRemark = model.NonActiveRemark,
                Reference = model.Reference,
                VAT = model.VAT
            };
        }
    }
}
