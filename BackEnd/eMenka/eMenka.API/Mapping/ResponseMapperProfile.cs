using AutoMapper;
using eMenka.API.Models.FuelCardModels.ReturnModels;
using eMenka.API.Models.RecordModels.ReturnModels;
using eMenka.API.Models.SupplierModels.ReturnModels;
using eMenka.API.Models.VehicleModels.ReturnModels;
using eMenka.Domain.Classes;

namespace eMenka.API.Mapping
{
    public class ResponseMapperProfile : Profile
    {
        public ResponseMapperProfile()
        {
            CreateMap<Driver,DriverReturnModel>().MaxDepth(1);
            CreateMap<FuelCard,FuelCardReturnModel>().MaxDepth(1).PreserveReferences();
            CreateMap<Person,PersonReturnModel>().MaxDepth(1);
            CreateMap<Company,CompanyReturnModel>().MaxDepth(1);
            CreateMap<Corporation,CorporationReturnModel>().MaxDepth(1);
            CreateMap<CostAllocation,CostAllocationReturnModel>().MaxDepth(1);
            CreateMap<Record,RecordReturnModel>().MaxDepth(1);
            CreateMap<Supplier,SupplierReturnModel>().MaxDepth(1);
            CreateMap<Brand, BrandReturnModel>();
            CreateMap<Category, CategoryReturnModel>();
            CreateMap<Country,CountryReturnModel>().MaxDepth(1);
            CreateMap<DoorType,DoorTypeReturnModel>().MaxDepth(1);
            CreateMap<EngineType,EngineTypeReturnModel>().MaxDepth(1);
            CreateMap<ExteriorColor,ExteriorColorReturnModel>().MaxDepth(1);
            CreateMap<FuelType,FuelTypeReturnModel>().MaxDepth(1);
            CreateMap<InteriorColor,InteriorColorReturnModel>().MaxDepth(1);
            CreateMap<Model,ModelReturnModel>().MaxDepth(1);
            CreateMap<Series, SerieReturnModel>();
            CreateMap<Vehicle, VehicleReturnModel>().PreserveReferences();
        }
    }
}
