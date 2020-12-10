func @_eMenka.API.Mappers.VehicleMappers.CountryMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Country$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :8 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :8 :57)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :8 :57)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :10 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :10 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :10 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :10 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :11 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :11 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :12 :19) // new CountryReturnModel              {                  Code = entity.Code,                  Id = entity.Id,                  IsActive = entity.IsActive,                  Name = entity.Name,                  Nationality = entity.Nationality,                  POD = entity.POD              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :14 :23) // Not a variable of known type: entity
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :14 :23) // entity.Code (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :15 :21) // Not a variable of known type: entity
%9 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :15 :21) // entity.Id (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :16 :27) // Not a variable of known type: entity
%11 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :16 :27) // entity.IsActive (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :17 :23) // Not a variable of known type: entity
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :17 :23) // entity.Name (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :18 :30) // Not a variable of known type: entity
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :18 :30) // entity.Nationality (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :19 :22) // Not a variable of known type: entity
%17 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :19 :22) // entity.POD (SimpleMemberAccessExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :12 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.VehicleMappers.CountryMapper.MapModelToEntity$eMenka.API.Models.VehicleModels.CountryModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :23 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :23 :40)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :23 :40)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :25 :19) // new Country              {                  POD = model.POD,                  Code = model.Code,                  Id = model.Id,                  IsActive = model.IsActive,                  Name = model.Name,                  Nationality = model.Nationality              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :27 :22) // Not a variable of known type: model
%3 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :27 :22) // model.POD (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :28 :23) // Not a variable of known type: model
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :28 :23) // model.Code (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :29 :21) // Not a variable of known type: model
%7 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :29 :21) // model.Id (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :30 :27) // Not a variable of known type: model
%9 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :30 :27) // model.IsActive (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :31 :23) // Not a variable of known type: model
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :31 :23) // model.Name (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :32 :30) // Not a variable of known type: model
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :32 :30) // model.Nationality (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CountryMapper.cs" :25 :12)

^1: // ExitBlock
cbde.unreachable

}
