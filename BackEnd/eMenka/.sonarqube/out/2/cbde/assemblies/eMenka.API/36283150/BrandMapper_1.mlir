func @_eMenka.API.Mappers.VehicleMappers.BrandMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Brand$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :18 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :18 :55)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :18 :55)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :20 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :20 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :20 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :20 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :21 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :21 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :22 :19) // new BrandReturnModel              {                  Name = entity.Name,                  Id = entity.Id,                  ExteriorColors = entity.ExteriorColors.Select(_exteriorColorMapper.MapExteriorColorEntity).ToList(),                  InteriorColors = entity.InteriorColors.Select(_interiorColorMapper.MapInteriorColorEntity).ToList()              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :24 :23) // Not a variable of known type: entity
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :24 :23) // entity.Name (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :25 :21) // Not a variable of known type: entity
%9 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :25 :21) // entity.Id (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :26 :33) // Not a variable of known type: entity
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :26 :33) // entity.ExteriorColors (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :26 :62) // Not a variable of known type: _exteriorColorMapper
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :26 :33) // entity.ExteriorColors.Select(_exteriorColorMapper.MapExteriorColorEntity) (InvocationExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :26 :33) // entity.ExteriorColors.Select(_exteriorColorMapper.MapExteriorColorEntity).ToList() (InvocationExpression)
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :27 :33) // Not a variable of known type: entity
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :27 :33) // entity.InteriorColors (SimpleMemberAccessExpression)
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :27 :62) // Not a variable of known type: _interiorColorMapper
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :27 :33) // entity.InteriorColors.Select(_interiorColorMapper.MapInteriorColorEntity) (InvocationExpression)
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :27 :33) // entity.InteriorColors.Select(_interiorColorMapper.MapInteriorColorEntity).ToList() (InvocationExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :22 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.VehicleMappers.BrandMapper.MapModelToEntity$eMenka.API.Models.VehicleModels.BrandModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :31 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :31 :38)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :31 :38)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :33 :19) // new Brand              {                  Id = model.Id,                  Name = model.Name              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :35 :21) // Not a variable of known type: model
%3 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :35 :21) // model.Id (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :36 :23) // Not a variable of known type: model
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :36 :23) // model.Name (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\BrandMapper.cs" :33 :12)

^1: // ExitBlock
cbde.unreachable

}
