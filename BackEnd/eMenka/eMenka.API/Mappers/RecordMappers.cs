using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers
{
    public static class RecordMappers
    {
        public static RecordReturnModel MapRecordEntity(Record record)
        {
            return new RecordReturnModel
            {
                City = record.City,
                Company = MapCompanyEntity(record.Company),
                EndDate = record.EndDate,
                FuelCard = record.FuelCardId, //todo map to fuelcardreturnmodel in future
                Id = record.Id,
                StartDate = record.StartDate,
                Term = record.Term,
                Usage = record.Usage
            };
        }

        public static Record MapRecordModel(RecordModel recordModel)
        {
            return new Record
            {
                Usage = recordModel.Usage,
                City = recordModel.City,
                CompanyId = (int)recordModel.CompanyId,
                EndDate = recordModel.EndDate,
                FuelCardId = 1,
                Id = recordModel.Id,
                StartDate = recordModel.StartDate,
                Term = recordModel.Term
            };
        }

        public static CompanyReturnModel MapCompanyEntity(Company company)
        {
            return new CompanyReturnModel
            {
                Name = company.Name,
                AccountNumber = company.AccountNumber,
                Description = company.Description,
                Id = company.Id,
                IsActive = company.IsActive,
                IsInternal = company.IsInternal,
                NonActiveRemark = company.NonActiveRemark,
                Reference = company.Reference,
                VAT = company.VAT
            };
        }

        public static Company MapCompanyModel(CompanyModel companyModel)
        {
            return new Company
            {
                AccountNumber = companyModel.AccountNumber,
                Description = companyModel.Description,
                Id = companyModel.Id,
                IsActive = companyModel.IsActive,
                IsInternal = companyModel.IsInternal,
                Name = companyModel.Name,
                NonActiveRemark = companyModel.NonActiveRemark,
                Reference = companyModel.Reference,
                VAT = companyModel.VAT
            };
        }
    }
}
