func @_eMenka.API.Mappers.VehicleMappers.CategoryMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Category$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :8 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :8 :58)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :8 :58)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :10 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :10 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :10 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :10 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :11 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :11 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :12 :19) // new CategoryReturnModel              {                  Id = entity.Id,                  Name = entity.Name              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :14 :21) // Not a variable of known type: entity
%7 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :14 :21) // entity.Id (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :15 :23) // Not a variable of known type: entity
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :15 :23) // entity.Name (SimpleMemberAccessExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :12 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.VehicleMappers.CategoryMapper.MapModelToEntity$eMenka.API.Models.VehicleModels.CategoryModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :19 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :19 :41)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :19 :41)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :21 :19) // new Category              {                  Name = model.Name,                  Id = model.Id              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :23 :23) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :23 :23) // model.Name (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :24 :21) // Not a variable of known type: model
%5 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :24 :21) // model.Id (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\CategoryMapper.cs" :21 :12)

^1: // ExitBlock
cbde.unreachable

}
