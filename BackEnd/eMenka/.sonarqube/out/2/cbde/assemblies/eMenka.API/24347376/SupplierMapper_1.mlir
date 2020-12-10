func @_eMenka.API.Mappers.SupplierMappers.SupplierMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Supplier$(none) -> none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :12 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :12 :58)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :12 :58)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :14 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :14 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :14 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :14 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :15 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :15 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :17 :19) // new SupplierReturnModel              {                  Name = entity.Name,                  Active = entity.Active,                  Id = entity.Id,                  Internal = entity.Internal,                  Types = entity.Types              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :19 :23) // Not a variable of known type: entity
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :19 :23) // entity.Name (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :20 :25) // Not a variable of known type: entity
%9 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :20 :25) // entity.Active (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :21 :21) // Not a variable of known type: entity
%11 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :21 :21) // entity.Id (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :22 :27) // Not a variable of known type: entity
%13 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :22 :27) // entity.Internal (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :23 :24) // Not a variable of known type: entity
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :23 :24) // entity.Types (SimpleMemberAccessExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :17 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.SupplierMappers.SupplierMapper.MapModelToEntity$eMenka.API.Models.SupplierModels.SupplierModel$(none) -> none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :27 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :27 :41)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :27 :41)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :29 :19) // new Supplier              {                  Name = model.Name,                  Active = model.Active,                  Id = model.Id,                  Internal = model.Internal,                  Types = model.Types              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :31 :23) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :31 :23) // model.Name (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :32 :25) // Not a variable of known type: model
%5 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :32 :25) // model.Active (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :33 :21) // Not a variable of known type: model
%7 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :33 :21) // model.Id (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :34 :27) // Not a variable of known type: model
%9 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :34 :27) // model.Internal (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :35 :24) // Not a variable of known type: model
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :35 :24) // model.Types (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\eMenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\SupplierMappers\\SupplierMapper.cs" :29 :12)

^1: // ExitBlock
cbde.unreachable

}
