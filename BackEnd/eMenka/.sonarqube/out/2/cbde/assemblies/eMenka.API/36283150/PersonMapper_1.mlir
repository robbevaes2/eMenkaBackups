func @_eMenka.API.Mappers.FuelCardMappers.PersonMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Person$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :8 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :8 :56)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :8 :56)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :10 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :10 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :10 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :10 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :11 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :11 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :12 :19) // new PersonReturnModel              {                  Title = entity.Title,                  BirthDate = entity.BirthDate,                  StartDateDriversLicense = entity.StartDateDriversLicense,                  Picture = entity.Picture,                  Lastname = entity.Lastname,                  Language = entity.Language,                  Id = entity.Id,                  Gender = entity.Gender,                  Firstname = entity.Firstname,                  EndDateDriversLicense = entity.EndDateDriversLicense,                  DriversLicenseNumber = entity.DriversLicenseNumber,                  DriversLicenseType = entity.DriversLicenseType              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :14 :24) // Not a variable of known type: entity
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :14 :24) // entity.Title (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :15 :28) // Not a variable of known type: entity
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :15 :28) // entity.BirthDate (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :16 :42) // Not a variable of known type: entity
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :16 :42) // entity.StartDateDriversLicense (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :17 :26) // Not a variable of known type: entity
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :17 :26) // entity.Picture (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :18 :27) // Not a variable of known type: entity
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :18 :27) // entity.Lastname (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :19 :27) // Not a variable of known type: entity
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :19 :27) // entity.Language (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :20 :21) // Not a variable of known type: entity
%19 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :20 :21) // entity.Id (SimpleMemberAccessExpression)
%20 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :21 :25) // Not a variable of known type: entity
%21 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :21 :25) // entity.Gender (SimpleMemberAccessExpression)
%22 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :22 :28) // Not a variable of known type: entity
%23 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :22 :28) // entity.Firstname (SimpleMemberAccessExpression)
%24 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :23 :40) // Not a variable of known type: entity
%25 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :23 :40) // entity.EndDateDriversLicense (SimpleMemberAccessExpression)
%26 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :24 :39) // Not a variable of known type: entity
%27 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :24 :39) // entity.DriversLicenseNumber (SimpleMemberAccessExpression)
%28 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :25 :37) // Not a variable of known type: entity
%29 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :25 :37) // entity.DriversLicenseType (SimpleMemberAccessExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :12 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.FuelCardMappers.PersonMapper.MapModelToEntity$eMenka.API.Models.FuelCardModels.PersonModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :29 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :29 :39)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :29 :39)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :31 :19) // new Person              {                  BirthDate = model.BirthDate,                  DriversLicenseNumber = model.DriversLicenseNumber,                  DriversLicenseType = model.DriversLicenseType,                  EndDateDriversLicense = model.EndDateDriversLicense,                  Firstname = model.Firstname,                  Gender = model.Gender,                  Id = model.Id,                  Language = model.Language,                  Lastname = model.Lastname,                  Picture = model.Picture,                  StartDateDriversLicense = model.StartDateDriversLicense,                  Title = model.Title              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :33 :28) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :33 :28) // model.BirthDate (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :34 :39) // Not a variable of known type: model
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :34 :39) // model.DriversLicenseNumber (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :35 :37) // Not a variable of known type: model
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :35 :37) // model.DriversLicenseType (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :36 :40) // Not a variable of known type: model
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :36 :40) // model.EndDateDriversLicense (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :37 :28) // Not a variable of known type: model
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :37 :28) // model.Firstname (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :38 :25) // Not a variable of known type: model
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :38 :25) // model.Gender (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :39 :21) // Not a variable of known type: model
%15 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :39 :21) // model.Id (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :40 :27) // Not a variable of known type: model
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :40 :27) // model.Language (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :41 :27) // Not a variable of known type: model
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :41 :27) // model.Lastname (SimpleMemberAccessExpression)
%20 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :42 :26) // Not a variable of known type: model
%21 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :42 :26) // model.Picture (SimpleMemberAccessExpression)
%22 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :43 :42) // Not a variable of known type: model
%23 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :43 :42) // model.StartDateDriversLicense (SimpleMemberAccessExpression)
%24 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :44 :24) // Not a variable of known type: model
%25 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :44 :24) // model.Title (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\PersonMapper.cs" :31 :12)

^1: // ExitBlock
cbde.unreachable

}
