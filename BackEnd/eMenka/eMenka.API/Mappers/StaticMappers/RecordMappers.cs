using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mappers.StaticMappers
{
    public static class RecordMappers
    {
        public static RecordReturnModel MapRecordEntity(Record record)
        {
            if (record == null)
                return null;
            return new RecordReturnModel
            {
                FuelCard = FuelCardMappers.MapFuelCardEntity(record.FuelCard),
                Id = record.Id,
                Term = record.Term,
                Usage = record.Usage,
                EndDate = record.EndDate,
                StartDate = record.StartDate,
                Corporation = MapCorporationEntity(record.Corporation),
                CostAllocation = MapCostAllocationEntity(record.CostAllocation)
            };
        }

        public static Record MapRecordModel(RecordModel recordModel)
        {
            return new Record
            {
                Usage = recordModel.Usage,
                CorporationId = recordModel.CorporationId,
                CostAllocationId = recordModel.CostAllocationId,
                EndDate = recordModel.EndDate,
                FuelCardId = (int)recordModel.FuelCardId,
                Id = recordModel.Id,
                StartDate = recordModel.StartDate,
                Term = recordModel.Term
            };
        }

        public static CorporationReturnModel MapCorporationEntity(Corporation corporation)
        {
            if (corporation == null)
                return null;
            return new CorporationReturnModel
            {
                Abbreviation = corporation.Abbreviation,
                Company = MapCompanyEntity(corporation.Company),
                EndDate = corporation.EndDate,
                Id = corporation.Id,
                Name = corporation.Name,
                StartDate = corporation.StartDate
            };
        }

        public static Corporation MapCorporationModel(CorporationModel corporationModel)
        {
            return new Corporation
            {
                Abbreviation = corporationModel.Abbreviation,
                CompanyId = (int)corporationModel.CompanyId,
                EndDate = corporationModel.EndDate,
                Name = corporationModel.Name,
                Id = corporationModel.Id,
                StartDate = corporationModel.StartDate
            };
        }

        public static CostAllocationReturnModel MapCostAllocationEntity(CostAllocation costAllocation)
        {
            if (costAllocation == null)
                return null;
            return new CostAllocationReturnModel
            {
                Abbreviation = costAllocation.Abbreviation,
                EndDate = costAllocation.EndDate,
                Id = costAllocation.Id,
                Name = costAllocation.Name,
                StartDate = costAllocation.StartDate
            };
        }

        public static CostAllocation MapCostAllocationModel(CostAllocationModel costAllocationModel)
        {
            return new CostAllocation
            {
                Abbreviation = costAllocationModel.Abbreviation,
                Id = costAllocationModel.Id,
                Name = costAllocationModel.Name,
                StartDate = costAllocationModel.StartDate,
                EndDate = costAllocationModel.EndDate
            };
        }

        public static CompanyReturnModel MapCompanyEntity(Company company)
        {
            if (company == null)
                return null;
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