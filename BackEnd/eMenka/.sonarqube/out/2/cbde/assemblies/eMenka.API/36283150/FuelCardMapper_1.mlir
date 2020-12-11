func @_eMenka.API.Mappers.FuelCardMappers.FuelCardMapper.MapEntityToReturnModel$eMenka.Domain.Classes.FuelCard$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :37 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :37 :58)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :37 :58)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :39 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :39 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :39 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :39 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :40 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :40 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :41 :19) // new FuelCardReturnModel              {                  Driver = _driverMapper.MapEntityToReturnModel(entity.Driver),                  EndDate = entity.EndDate,                  StartDate = entity.StartDate,                  Company = entity.Company,                  Id = entity.Id,                  BlockingDate = entity.BlockingDate,                  BlockingReason = entity.BlockingReason,                  IsBlocked = entity.IsBlocked,                  PinCode = entity.PinCode,                  Number = entity.Number,                  Vehicle = MapVehicleEntity(entity.Vehicle)              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :43 :25) // Not a variable of known type: _driverMapper
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :43 :62) // Not a variable of known type: entity
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :43 :62) // entity.Driver (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :43 :25) // _driverMapper.MapEntityToReturnModel(entity.Driver) (InvocationExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :44 :26) // Not a variable of known type: entity
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :44 :26) // entity.EndDate (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :45 :28) // Not a variable of known type: entity
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :45 :28) // entity.StartDate (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :46 :26) // Not a variable of known type: entity
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :46 :26) // entity.Company (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :47 :21) // Not a variable of known type: entity
%17 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :47 :21) // entity.Id (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :48 :31) // Not a variable of known type: entity
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :48 :31) // entity.BlockingDate (SimpleMemberAccessExpression)
%20 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :49 :33) // Not a variable of known type: entity
%21 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :49 :33) // entity.BlockingReason (SimpleMemberAccessExpression)
%22 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :50 :28) // Not a variable of known type: entity
%23 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :50 :28) // entity.IsBlocked (SimpleMemberAccessExpression)
%24 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :51 :26) // Not a variable of known type: entity
%25 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :51 :26) // entity.PinCode (SimpleMemberAccessExpression)
%26 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :52 :25) // Not a variable of known type: entity
%27 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :52 :25) // entity.Number (SimpleMemberAccessExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: MapVehicleEntity
%28 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :53 :43) // Not a variable of known type: entity
%29 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :53 :43) // entity.Vehicle (SimpleMemberAccessExpression)
%30 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :53 :26) // MapVehicleEntity(entity.Vehicle) (InvocationExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :41 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.FuelCardMappers.FuelCardMapper.MapModelToEntity$eMenka.API.Models.FuelCardModels.FuelCardModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :57 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :57 :41)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :57 :41)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :59 :19) // new FuelCard              {                  DriverId = (int)model.DriverId,                  EndDate = model.EndDate,                  Id = model.Id,                  StartDate = model.StartDate,                  BlockingDate = model.BlockingDate,                  BlockingReason = model.BlockingReason,                  IsBlocked = model.IsBlocked,                  PinCode = model.PinCode,                  Number = model.Number,                  VehicleId = model.VehicleId,                  CompanyId = model.CompanyId              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :61 :32) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :61 :32) // model.DriverId (SimpleMemberAccessExpression)
%4 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :61 :27) // (int)model.DriverId (CastExpression)
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :62 :26) // Not a variable of known type: model
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :62 :26) // model.EndDate (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :63 :21) // Not a variable of known type: model
%8 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :63 :21) // model.Id (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :64 :28) // Not a variable of known type: model
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :64 :28) // model.StartDate (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :65 :31) // Not a variable of known type: model
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :65 :31) // model.BlockingDate (SimpleMemberAccessExpression)
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :66 :33) // Not a variable of known type: model
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :66 :33) // model.BlockingReason (SimpleMemberAccessExpression)
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :67 :28) // Not a variable of known type: model
%16 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :67 :28) // model.IsBlocked (SimpleMemberAccessExpression)
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :68 :26) // Not a variable of known type: model
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :68 :26) // model.PinCode (SimpleMemberAccessExpression)
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :69 :25) // Not a variable of known type: model
%20 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :69 :25) // model.Number (SimpleMemberAccessExpression)
%21 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :70 :28) // Not a variable of known type: model
%22 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :70 :28) // model.VehicleId (SimpleMemberAccessExpression)
%23 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :71 :28) // Not a variable of known type: model
%24 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :71 :28) // model.CompanyId (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :59 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.FuelCardMappers.FuelCardMapper.MapVehicleEntity$eMenka.Domain.Classes.Vehicle$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :75 :8) {
^entry (%_vehicle : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :75 :52)
cbde.store %_vehicle, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :75 :52)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :77 :16) // Not a variable of known type: vehicle
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :77 :27) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :77 :16) // comparison of unknown type: vehicle == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :77 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :78 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :78 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :79 :19) // new VehicleReturnModel              {                  Id = vehicle.Id,                  Brand = _brandMapper.MapEntityToReturnModel(vehicle.Brand),                  FuelType = _fuelTypeMapper.MapEntityToReturnModel(vehicle.FuelType),                  EngineType = _engineTypeMapper.MapEntityToReturnModel(vehicle.EngineType),                  DoorType = _doorTypeMapper.MapEntityToReturnModel(vehicle.DoorType),                  Emission = vehicle.Emission,                  FiscalHP = vehicle.FiscalHP,                  IsActive = vehicle.IsActive,                  Volume = vehicle.Volume,                  Model = _modelMapper.MapEntityToReturnModel(vehicle.Model),                  Category = _categoryMapper.MapEntityToReturnModel(vehicle.Category),                  LicensePlate = vehicle.LicensePlate,                  Chassis = vehicle.Chassis,                  AverageFuel = vehicle.AverageFuel,                  EndDateDelivery = vehicle.EndDateDelivery,                  EngineCapacity = vehicle.EngineCapacity,                  EnginePower = vehicle.EnginePower,                  Serie = _serieMapper.MapEntityToReturnModel(vehicle.Series),                  BuildYear = vehicle.BuildYear,                  Country = _countryMapper.MapEntityToReturnModel(vehicle.Country),                  Kilometers = vehicle.Kilometers,                  RegistrationDate = vehicle.RegistrationDate,                  ExteriorColor = _exteriorColorMapper.MapExteriorColorEntity(vehicle.ExteriorColor),                  InteriorColor = _interiorColorMapper.MapInteriorColorEntity(vehicle.InteriorColor)              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :81 :21) // Not a variable of known type: vehicle
%7 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :81 :21) // vehicle.Id (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :82 :24) // Not a variable of known type: _brandMapper
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :82 :60) // Not a variable of known type: vehicle
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :82 :60) // vehicle.Brand (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :82 :24) // _brandMapper.MapEntityToReturnModel(vehicle.Brand) (InvocationExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :83 :27) // Not a variable of known type: _fuelTypeMapper
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :83 :66) // Not a variable of known type: vehicle
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :83 :66) // vehicle.FuelType (SimpleMemberAccessExpression)
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :83 :27) // _fuelTypeMapper.MapEntityToReturnModel(vehicle.FuelType) (InvocationExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :84 :29) // Not a variable of known type: _engineTypeMapper
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :84 :70) // Not a variable of known type: vehicle
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :84 :70) // vehicle.EngineType (SimpleMemberAccessExpression)
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :84 :29) // _engineTypeMapper.MapEntityToReturnModel(vehicle.EngineType) (InvocationExpression)
%20 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :85 :27) // Not a variable of known type: _doorTypeMapper
%21 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :85 :66) // Not a variable of known type: vehicle
%22 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :85 :66) // vehicle.DoorType (SimpleMemberAccessExpression)
%23 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :85 :27) // _doorTypeMapper.MapEntityToReturnModel(vehicle.DoorType) (InvocationExpression)
%24 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :86 :27) // Not a variable of known type: vehicle
%25 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :86 :27) // vehicle.Emission (SimpleMemberAccessExpression)
%26 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :87 :27) // Not a variable of known type: vehicle
%27 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :87 :27) // vehicle.FiscalHP (SimpleMemberAccessExpression)
%28 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :88 :27) // Not a variable of known type: vehicle
%29 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :88 :27) // vehicle.IsActive (SimpleMemberAccessExpression)
%30 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :89 :25) // Not a variable of known type: vehicle
%31 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :89 :25) // vehicle.Volume (SimpleMemberAccessExpression)
%32 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :90 :24) // Not a variable of known type: _modelMapper
%33 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :90 :60) // Not a variable of known type: vehicle
%34 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :90 :60) // vehicle.Model (SimpleMemberAccessExpression)
%35 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :90 :24) // _modelMapper.MapEntityToReturnModel(vehicle.Model) (InvocationExpression)
%36 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :91 :27) // Not a variable of known type: _categoryMapper
%37 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :91 :66) // Not a variable of known type: vehicle
%38 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :91 :66) // vehicle.Category (SimpleMemberAccessExpression)
%39 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :91 :27) // _categoryMapper.MapEntityToReturnModel(vehicle.Category) (InvocationExpression)
%40 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :92 :31) // Not a variable of known type: vehicle
%41 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :92 :31) // vehicle.LicensePlate (SimpleMemberAccessExpression)
%42 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :93 :26) // Not a variable of known type: vehicle
%43 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :93 :26) // vehicle.Chassis (SimpleMemberAccessExpression)
%44 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :94 :30) // Not a variable of known type: vehicle
%45 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :94 :30) // vehicle.AverageFuel (SimpleMemberAccessExpression)
%46 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :95 :34) // Not a variable of known type: vehicle
%47 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :95 :34) // vehicle.EndDateDelivery (SimpleMemberAccessExpression)
%48 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :96 :33) // Not a variable of known type: vehicle
%49 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :96 :33) // vehicle.EngineCapacity (SimpleMemberAccessExpression)
%50 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :97 :30) // Not a variable of known type: vehicle
%51 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :97 :30) // vehicle.EnginePower (SimpleMemberAccessExpression)
%52 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :98 :24) // Not a variable of known type: _serieMapper
%53 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :98 :60) // Not a variable of known type: vehicle
%54 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :98 :60) // vehicle.Series (SimpleMemberAccessExpression)
%55 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :98 :24) // _serieMapper.MapEntityToReturnModel(vehicle.Series) (InvocationExpression)
%56 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :99 :28) // Not a variable of known type: vehicle
%57 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :99 :28) // vehicle.BuildYear (SimpleMemberAccessExpression)
%58 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :100 :26) // Not a variable of known type: _countryMapper
%59 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :100 :64) // Not a variable of known type: vehicle
%60 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :100 :64) // vehicle.Country (SimpleMemberAccessExpression)
%61 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :100 :26) // _countryMapper.MapEntityToReturnModel(vehicle.Country) (InvocationExpression)
%62 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :101 :29) // Not a variable of known type: vehicle
%63 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :101 :29) // vehicle.Kilometers (SimpleMemberAccessExpression)
%64 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :102 :35) // Not a variable of known type: vehicle
%65 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :102 :35) // vehicle.RegistrationDate (SimpleMemberAccessExpression)
%66 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :103 :32) // Not a variable of known type: _exteriorColorMapper
%67 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :103 :76) // Not a variable of known type: vehicle
%68 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :103 :76) // vehicle.ExteriorColor (SimpleMemberAccessExpression)
%69 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :103 :32) // _exteriorColorMapper.MapExteriorColorEntity(vehicle.ExteriorColor) (InvocationExpression)
%70 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :104 :32) // Not a variable of known type: _interiorColorMapper
%71 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :104 :76) // Not a variable of known type: vehicle
%72 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :104 :76) // vehicle.InteriorColor (SimpleMemberAccessExpression)
%73 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :104 :32) // _interiorColorMapper.MapInteriorColorEntity(vehicle.InteriorColor) (InvocationExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\FuelCardMapper.cs" :79 :12)

^3: // ExitBlock
cbde.unreachable

}
