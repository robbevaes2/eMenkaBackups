func @_eMenka.API.Mappers.VehicleMappers.FuelTypeMapper.MapEntityToReturnModel$eMenka.Domain.Classes.FuelType$(none) -> none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :8 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :8 :58)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :8 :58)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :10 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :10 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :10 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :10 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :11 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :11 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :12 :19) // new FuelTypeReturnModel              {                  Id = entity.Id,                  Code = entity.Code,                  Name = entity.Name              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :14 :21) // Not a variable of known type: entity
%7 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :14 :21) // entity.Id (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :15 :23) // Not a variable of known type: entity
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :15 :23) // entity.Code (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :16 :23) // Not a variable of known type: entity
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :16 :23) // entity.Name (SimpleMemberAccessExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :12 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.VehicleMappers.FuelTypeMapper.MapModelToEntity$eMenka.API.Models.VehicleModels.FuelTypeModel$(none) -> none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :20 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :20 :41)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :20 :41)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :22 :19) // new FuelType              {                  Code = model.Code,                  Id = model.Id,                  Name = model.Name              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :24 :23) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :24 :23) // model.Code (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :25 :21) // Not a variable of known type: model
%5 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :25 :21) // model.Id (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :26 :23) // Not a variable of known type: model
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :26 :23) // model.Name (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\FuelTypeMapper.cs" :22 :12)

^1: // ExitBlock
cbde.unreachable

}
