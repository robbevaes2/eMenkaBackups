func @_eMenka.API.Mappers.FuelCardMappers.DriverMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Driver$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :15 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :15 :56)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :15 :56)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :17 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :17 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :17 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :17 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :18 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :18 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :19 :19) // new DriverReturnModel              {                  EndDate = entity.EndDate,                  StartDate = entity.StartDate,                  Id = entity.Id,                  Person = _personMapper.MapEntityToReturnModel(entity.Person)              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :21 :26) // Not a variable of known type: entity
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :21 :26) // entity.EndDate (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :22 :28) // Not a variable of known type: entity
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :22 :28) // entity.StartDate (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :23 :21) // Not a variable of known type: entity
%11 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :23 :21) // entity.Id (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :24 :25) // Not a variable of known type: _personMapper
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :24 :62) // Not a variable of known type: entity
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :24 :62) // entity.Person (SimpleMemberAccessExpression)
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :24 :25) // _personMapper.MapEntityToReturnModel(entity.Person) (InvocationExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :19 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.FuelCardMappers.DriverMapper.MapModelToEntity$eMenka.API.Models.FuelCardModels.DriverModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :28 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :28 :39)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :28 :39)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :30 :19) // new Driver              {                  Id = model.Id,                  EndDate = model.EndDate,                  PersonId = (int)model.PersonId,                  StartDate = model.StartDate              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :32 :21) // Not a variable of known type: model
%3 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :32 :21) // model.Id (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :33 :26) // Not a variable of known type: model
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :33 :26) // model.EndDate (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :34 :32) // Not a variable of known type: model
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :34 :32) // model.PersonId (SimpleMemberAccessExpression)
%8 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :34 :27) // (int)model.PersonId (CastExpression)
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :35 :28) // Not a variable of known type: model
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :35 :28) // model.StartDate (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\FuelCardMappers\\DriverMapper.cs" :30 :12)

^1: // ExitBlock
cbde.unreachable

}
