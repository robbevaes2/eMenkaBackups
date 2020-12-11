func @_eMenka.API.Mappers.VehicleMappers.SerieMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Series$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :15 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :15 :55)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :15 :55)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :17 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :17 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :17 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :17 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :18 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :18 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :19 :19) // new SerieReturnModel              {                  Brand = _brandMapper.MapEntityToReturnModel(entity.Brand),                  Name = entity.Name,                  Id = entity.Id              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :21 :24) // Not a variable of known type: _brandMapper
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :21 :60) // Not a variable of known type: entity
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :21 :60) // entity.Brand (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :21 :24) // _brandMapper.MapEntityToReturnModel(entity.Brand) (InvocationExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :22 :23) // Not a variable of known type: entity
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :22 :23) // entity.Name (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :23 :21) // Not a variable of known type: entity
%13 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :23 :21) // entity.Id (SimpleMemberAccessExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :19 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.VehicleMappers.SerieMapper.MapModelToEntity$eMenka.API.Models.VehicleModels.SerieModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :27 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :27 :39)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :27 :39)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :29 :19) // new Series              {                  BrandId = (int)model.BrandId,                  Id = model.Id,                  Name = model.Name              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :31 :31) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :31 :31) // model.BrandId (SimpleMemberAccessExpression)
%4 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :31 :26) // (int)model.BrandId (CastExpression)
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :32 :21) // Not a variable of known type: model
%6 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :32 :21) // model.Id (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :33 :23) // Not a variable of known type: model
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :33 :23) // model.Name (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\VehicleMappers\\SerieMapper.cs" :29 :12)

^1: // ExitBlock
cbde.unreachable

}
