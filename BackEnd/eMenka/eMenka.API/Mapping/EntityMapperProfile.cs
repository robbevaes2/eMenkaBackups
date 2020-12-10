using AutoMapper;
using eMenka.API.Models.FuelCardModels;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.API.Models.RecordModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.API.Models.SupplierModels;
using eMenka.API.Models.SupplierModels.ReturnModels;
using eMenka.API.Models.VehicleModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mapping
{
    public class EntityMapperProfile : Profile
    {
        public EntityMapperProfile()
        {
            CreateMap<DriverModel, Driver>();
            CreateMap<FuelCardModel, FuelCard>();
            CreateMap<PersonModel, Person>();
            CreateMap<CompanyModel, Company>();
            CreateMap<CorporationModel, Corporation>();
            CreateMap<CostAllocationModel, CostAllocation>();
            CreateMap<RecordModel, Record>();
            CreateMap<SupplierModel, Supplier>();
            CreateMap<BrandModel, Brand>();
            CreateMap<CategoryModel, Category>();
            CreateMap<CountryModel, Country>();
            CreateMap<DoorTypeModel, DoorType>();
            CreateMap<EngineTypeModel, EngineType>();
            CreateMap<FuelTypeModel, FuelType>();
            CreateMap<ModelModel, Model>();
            CreateMap<SerieModel, Series>();
            CreateMap<VehicleModel, Vehicle>();
        }
    }
}
