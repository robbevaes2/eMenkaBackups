func @_eMenka.API.Mappers.RecordMappers.CostAllocationMapper.MapEntityToReturnModel$eMenka.Domain.Classes.CostAllocation$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :8 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :8 :64)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :8 :64)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :10 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :10 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :10 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :10 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :11 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :11 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :12 :19) // new CostAllocationReturnModel              {                  Abbreviation = entity.Abbreviation,                  EndDate = entity.EndDate,                  Id = entity.Id,                  Name = entity.Name,                  StartDate = entity.StartDate              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :14 :31) // Not a variable of known type: entity
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :14 :31) // entity.Abbreviation (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :15 :26) // Not a variable of known type: entity
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :15 :26) // entity.EndDate (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :16 :21) // Not a variable of known type: entity
%11 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :16 :21) // entity.Id (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :17 :23) // Not a variable of known type: entity
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :17 :23) // entity.Name (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :18 :28) // Not a variable of known type: entity
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :18 :28) // entity.StartDate (SimpleMemberAccessExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :12 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.RecordMappers.CostAllocationMapper.MapModelToEntity$eMenka.API.Models.RecordModels.CostAllocationModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :22 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :22 :47)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :22 :47)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :24 :19) // new CostAllocation              {                  Abbreviation = model.Abbreviation,                  Id = model.Id,                  Name = model.Name,                  StartDate = model.StartDate,                  EndDate = model.EndDate              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :26 :31) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :26 :31) // model.Abbreviation (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :27 :21) // Not a variable of known type: model
%5 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :27 :21) // model.Id (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :28 :23) // Not a variable of known type: model
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :28 :23) // model.Name (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :29 :28) // Not a variable of known type: model
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :29 :28) // model.StartDate (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :30 :26) // Not a variable of known type: model
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :30 :26) // model.EndDate (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CostAllocationMapper.cs" :24 :12)

^1: // ExitBlock
cbde.unreachable

}
