func @_eMenka.API.Mappers.VehicleMappers.VehicleMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Vehicle$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :37 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :37 :57)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :37 :57)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :39 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :39 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :39 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :39 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :40 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :40 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :41 :19) // new VehicleReturnModel              {                  Id = entity.Id,                  Brand = _brandMapper.MapEntityToReturnModel(entity.Brand),                  FuelType = _fuelTypeMapper.MapEntityToReturnModel(entity.FuelType),                  EngineType = _engineTypeMapper.MapEntityToReturnModel(entity.EngineType),                  DoorType = _doorTypeMapper.MapEntityToReturnModel(entity.DoorType),                  Emission = entity.Emission,                  FiscalHP = entity.FiscalHP,                  IsActive = entity.IsActive,                  Volume = entity.Volume,                  Model = _modelMapper.MapEntityToReturnModel(entity.Model),                  FuelCard = MapFuelCardEntity(entity.FuelCard),                  Category = _categoryMapper.MapEntityToReturnModel(entity.Category),                  LicensePlate = entity.LicensePlate,                  Chassis = entity.Chassis,                  AverageFuel = entity.AverageFuel,                  EndDateDelivery = entity.EndDateDelivery,                  EngineCapacity = entity.EngineCapacity,                  EnginePower = entity.EnginePower,                  Serie = _serieMapper.MapEntityToReturnModel(entity.Series),                  BuildYear = entity.BuildYear,                  Country = _countryMapper.MapEntityToReturnModel(entity.Country),                  Kilometers = entity.Kilometers,                  RegistrationDate = entity.RegistrationDate,                  ExteriorColor = _exteriorColorMapper.MapExteriorColorEntity(entity.ExteriorColor),                  InteriorColor = _interiorColorMapper.MapInteriorColorEntity(entity.InteriorColor)              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :43 :21) // Not a variable of known type: entity
%7 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :43 :21) // entity.Id (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :44 :24) // Not a variable of known type: _brandMapper
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :44 :60) // Not a variable of known type: entity
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :44 :60) // entity.Brand (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :44 :24) // _brandMapper.MapEntityToReturnModel(entity.Brand) (InvocationExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :45 :27) // Not a variable of known type: _fuelTypeMapper
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :45 :66) // Not a variable of known type: entity
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :45 :66) // entity.FuelType (SimpleMemberAccessExpression)
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :45 :27) // _fuelTypeMapper.MapEntityToReturnModel(entity.FuelType) (InvocationExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :46 :29) // Not a variable of known type: _engineTypeMapper
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :46 :70) // Not a variable of known type: entity
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :46 :70) // entity.EngineType (SimpleMemberAccessExpression)
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :46 :29) // _engineTypeMapper.MapEntityToReturnModel(entity.EngineType) (InvocationExpression)
%20 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :47 :27) // Not a variable of known type: _doorTypeMapper
%21 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :47 :66) // Not a variable of known type: entity
%22 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :47 :66) // entity.DoorType (SimpleMemberAccessExpression)
%23 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :47 :27) // _doorTypeMapper.MapEntityToReturnModel(entity.DoorType) (InvocationExpression)
%24 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :48 :27) // Not a variable of known type: entity
%25 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :48 :27) // entity.Emission (SimpleMemberAccessExpression)
%26 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :49 :27) // Not a variable of known type: entity
%27 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :49 :27) // entity.FiscalHP (SimpleMemberAccessExpression)
%28 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :50 :27) // Not a variable of known type: entity
%29 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :50 :27) // entity.IsActive (SimpleMemberAccessExpression)
%30 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :51 :25) // Not a variable of known type: entity
%31 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :51 :25) // entity.Volume (SimpleMemberAccessExpression)
%32 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :52 :24) // Not a variable of known type: _modelMapper
%33 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :52 :60) // Not a variable of known type: entity
%34 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :52 :60) // entity.Model (SimpleMemberAccessExpression)
%35 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :52 :24) // _modelMapper.MapEntityToReturnModel(entity.Model) (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: MapFuelCardEntity
%36 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :53 :45) // Not a variable of known type: entity
%37 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :53 :45) // entity.FuelCard (SimpleMemberAccessExpression)
%38 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :53 :27) // MapFuelCardEntity(entity.FuelCard) (InvocationExpression)
%39 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :54 :27) // Not a variable of known type: _categoryMapper
%40 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :54 :66) // Not a variable of known type: entity
%41 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :54 :66) // entity.Category (SimpleMemberAccessExpression)
%42 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :54 :27) // _categoryMapper.MapEntityToReturnModel(entity.Category) (InvocationExpression)
%43 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :55 :31) // Not a variable of known type: entity
%44 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :55 :31) // entity.LicensePlate (SimpleMemberAccessExpression)
%45 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :56 :26) // Not a variable of known type: entity
%46 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :56 :26) // entity.Chassis (SimpleMemberAccessExpression)
%47 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :57 :30) // Not a variable of known type: entity
%48 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :57 :30) // entity.AverageFuel (SimpleMemberAccessExpression)
%49 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :58 :34) // Not a variable of known type: entity
%50 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :58 :34) // entity.EndDateDelivery (SimpleMemberAccessExpression)
%51 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :59 :33) // Not a variable of known type: entity
%52 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :59 :33) // entity.EngineCapacity (SimpleMemberAccessExpression)
%53 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :60 :30) // Not a variable of known type: entity
%54 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :60 :30) // entity.EnginePower (SimpleMemberAccessExpression)
%55 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :61 :24) // Not a variable of known type: _serieMapper
%56 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :61 :60) // Not a variable of known type: entity
%57 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :61 :60) // entity.Series (SimpleMemberAccessExpression)
%58 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :61 :24) // _serieMapper.MapEntityToReturnModel(entity.Series) (InvocationExpression)
%59 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :62 :28) // Not a variable of known type: entity
%60 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :62 :28) // entity.BuildYear (SimpleMemberAccessExpression)
%61 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :63 :26) // Not a variable of known type: _countryMapper
%62 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :63 :64) // Not a variable of known type: entity
%63 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :63 :64) // entity.Country (SimpleMemberAccessExpression)
%64 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :63 :26) // _countryMapper.MapEntityToReturnModel(entity.Country) (InvocationExpression)
%65 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :64 :29) // Not a variable of known type: entity
%66 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :64 :29) // entity.Kilometers (SimpleMemberAccessExpression)
%67 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :65 :35) // Not a variable of known type: entity
%68 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :65 :35) // entity.RegistrationDate (SimpleMemberAccessExpression)
%69 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :66 :32) // Not a variable of known type: _exteriorColorMapper
%70 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :66 :76) // Not a variable of known type: entity
%71 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :66 :76) // entity.ExteriorColor (SimpleMemberAccessExpression)
%72 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :66 :32) // _exteriorColorMapper.MapExteriorColorEntity(entity.ExteriorColor) (InvocationExpression)
%73 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :67 :32) // Not a variable of known type: _interiorColorMapper
%74 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :67 :76) // Not a variable of known type: entity
%75 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :67 :76) // entity.InteriorColor (SimpleMemberAccessExpression)
%76 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :67 :32) // _interiorColorMapper.MapInteriorColorEntity(entity.InteriorColor) (InvocationExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :41 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.VehicleMappers.VehicleMapper.MapModelToEntity$eMenka.API.Models.VehicleModels.VehicleModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :71 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :71 :40)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :71 :40)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :73 :19) // new Vehicle              {                  Id = model.Id,                  EngineTypeId = (int)model.EngineTypeId,                  BrandId = (int)model.BrandId,                  DoorTypeId = (int)model.DoorTypeId,                  Emission = (int)model.Emission,                  FiscalHP = (int)model.FiscalHP,                  FuelTypeId = (int)model.FuelTypeId,                  IsActive = model.IsActive,                  ModelId = (int)model.ModelId,                  Volume = (int)model.Volume,                  LicensePlate = model.LicensePlate,                  FuelCardId = model.FuelCardId,                  SeriesId = (int)model.SeriesId,                  Chassis = model.Chassis,                  AverageFuel = model.AverageFuel,                  EndDateDelivery = model.EndDateDelivery,                  EngineCapacity = model.EngineCapacity,                  EnginePower = model.EnginePower,                  CountryId = model.CountryId,                  BuildYear = model.BuildYear,                  CategoryId = model.CategoryId,                  Kilometers = model.Kilometers,                  RegistrationDate = model.RegistrationDate,                  ExteriorColorId = model.ExteriorColorId,                  InteriorColorId = model.InteriorColorId              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :75 :21) // Not a variable of known type: model
%3 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :75 :21) // model.Id (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :76 :36) // Not a variable of known type: model
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :76 :36) // model.EngineTypeId (SimpleMemberAccessExpression)
%6 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :76 :31) // (int)model.EngineTypeId (CastExpression)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :77 :31) // Not a variable of known type: model
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :77 :31) // model.BrandId (SimpleMemberAccessExpression)
%9 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :77 :26) // (int)model.BrandId (CastExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :78 :34) // Not a variable of known type: model
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :78 :34) // model.DoorTypeId (SimpleMemberAccessExpression)
%12 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :78 :29) // (int)model.DoorTypeId (CastExpression)
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :79 :32) // Not a variable of known type: model
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :79 :32) // model.Emission (SimpleMemberAccessExpression)
%15 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :79 :27) // (int)model.Emission (CastExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :80 :32) // Not a variable of known type: model
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :80 :32) // model.FiscalHP (SimpleMemberAccessExpression)
%18 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :80 :27) // (int)model.FiscalHP (CastExpression)
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :81 :34) // Not a variable of known type: model
%20 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :81 :34) // model.FuelTypeId (SimpleMemberAccessExpression)
%21 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :81 :29) // (int)model.FuelTypeId (CastExpression)
%22 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :82 :27) // Not a variable of known type: model
%23 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :82 :27) // model.IsActive (SimpleMemberAccessExpression)
%24 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :83 :31) // Not a variable of known type: model
%25 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :83 :31) // model.ModelId (SimpleMemberAccessExpression)
%26 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :83 :26) // (int)model.ModelId (CastExpression)
%27 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :84 :30) // Not a variable of known type: model
%28 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :84 :30) // model.Volume (SimpleMemberAccessExpression)
%29 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :84 :25) // (int)model.Volume (CastExpression)
%30 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :85 :31) // Not a variable of known type: model
%31 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :85 :31) // model.LicensePlate (SimpleMemberAccessExpression)
%32 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :86 :29) // Not a variable of known type: model
%33 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :86 :29) // model.FuelCardId (SimpleMemberAccessExpression)
%34 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :87 :32) // Not a variable of known type: model
%35 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :87 :32) // model.SeriesId (SimpleMemberAccessExpression)
%36 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :87 :27) // (int)model.SeriesId (CastExpression)
%37 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :88 :26) // Not a variable of known type: model
%38 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :88 :26) // model.Chassis (SimpleMemberAccessExpression)
%39 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :89 :30) // Not a variable of known type: model
%40 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :89 :30) // model.AverageFuel (SimpleMemberAccessExpression)
%41 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :90 :34) // Not a variable of known type: model
%42 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :90 :34) // model.EndDateDelivery (SimpleMemberAccessExpression)
%43 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :91 :33) // Not a variable of known type: model
%44 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :91 :33) // model.EngineCapacity (SimpleMemberAccessExpression)
%45 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :92 :30) // Not a variable of known type: model
%46 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :92 :30) // model.EnginePower (SimpleMemberAccessExpression)
%47 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :93 :28) // Not a variable of known type: model
%48 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :93 :28) // model.CountryId (SimpleMemberAccessExpression)
%49 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :94 :28) // Not a variable of known type: model
%50 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :94 :28) // model.BuildYear (SimpleMemberAccessExpression)
%51 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :95 :29) // Not a variable of known type: model
%52 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :95 :29) // model.CategoryId (SimpleMemberAccessExpression)
%53 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :96 :29) // Not a variable of known type: model
%54 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :96 :29) // model.Kilometers (SimpleMemberAccessExpression)
%55 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :97 :35) // Not a variable of known type: model
%56 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :97 :35) // model.RegistrationDate (SimpleMemberAccessExpression)
%57 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :98 :34) // Not a variable of known type: model
%58 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :98 :34) // model.ExteriorColorId (SimpleMemberAccessExpression)
%59 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :99 :34) // Not a variable of known type: model
%60 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :99 :34) // model.InteriorColorId (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :73 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.VehicleMappers.VehicleMapper.MapFuelCardEntity$eMenka.Domain.Classes.FuelCard$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :103 :8) {
^entry (%_fuelCard : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :103 :54)
cbde.store %_fuelCard, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :103 :54)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :105 :16) // Not a variable of known type: fuelCard
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :105 :28) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :105 :16) // comparison of unknown type: fuelCard == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :105 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :106 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :106 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :107 :19) // new FuelCardReturnModel              {                  Driver = _driverMapper.MapEntityToReturnModel(fuelCard.Driver),                  EndDate = fuelCard.EndDate,                  StartDate = fuelCard.StartDate,                  Id = fuelCard.Id,                  BlockingDate = fuelCard.BlockingDate,                  BlockingReason = fuelCard.BlockingReason,                  IsBlocked = fuelCard.IsBlocked,                  PinCode = fuelCard.PinCode,                  Number = fuelCard.Number              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :109 :25) // Not a variable of known type: _driverMapper
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :109 :62) // Not a variable of known type: fuelCard
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :109 :62) // fuelCard.Driver (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :109 :25) // _driverMapper.MapEntityToReturnModel(fuelCard.Driver) (InvocationExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :110 :26) // Not a variable of known type: fuelCard
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :110 :26) // fuelCard.EndDate (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :111 :28) // Not a variable of known type: fuelCard
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :111 :28) // fuelCard.StartDate (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :112 :21) // Not a variable of known type: fuelCard
%15 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :112 :21) // fuelCard.Id (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :113 :31) // Not a variable of known type: fuelCard
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :113 :31) // fuelCard.BlockingDate (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :114 :33) // Not a variable of known type: fuelCard
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :114 :33) // fuelCard.BlockingReason (SimpleMemberAccessExpression)
%20 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :115 :28) // Not a variable of known type: fuelCard
%21 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :115 :28) // fuelCard.IsBlocked (SimpleMemberAccessExpression)
%22 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :116 :26) // Not a variable of known type: fuelCard
%23 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :116 :26) // fuelCard.PinCode (SimpleMemberAccessExpression)
%24 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :117 :25) // Not a variable of known type: fuelCard
%25 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :117 :25) // fuelCard.Number (SimpleMemberAccessExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\VehicleMapper.cs" :107 :12)

^3: // ExitBlock
cbde.unreachable

}
