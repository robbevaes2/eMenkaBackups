func @_eMenka.API.Mappers.RecordMappers.RecordMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Record$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :20 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :20 :56)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :20 :56)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :22 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :22 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :22 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :22 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :23 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :23 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :24 :19) // new RecordReturnModel              {                  FuelCard = _fuelCardMapper.MapEntityToReturnModel(entity.FuelCard),                  Id = entity.Id,                  Term = entity.Term,                  Usage = entity.Usage,                  EndDate = entity.EndDate,                  StartDate = entity.StartDate,                  Corporation = _coporationMapper.MapEntityToReturnModel(entity.Corporation),                  CostAllocation = _costAllocationMapper.MapEntityToReturnModel(entity.CostAllocation)              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :26 :27) // Not a variable of known type: _fuelCardMapper
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :26 :66) // Not a variable of known type: entity
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :26 :66) // entity.FuelCard (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :26 :27) // _fuelCardMapper.MapEntityToReturnModel(entity.FuelCard) (InvocationExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :27 :21) // Not a variable of known type: entity
%11 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :27 :21) // entity.Id (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :28 :23) // Not a variable of known type: entity
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :28 :23) // entity.Term (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :29 :24) // Not a variable of known type: entity
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :29 :24) // entity.Usage (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :30 :26) // Not a variable of known type: entity
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :30 :26) // entity.EndDate (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :31 :28) // Not a variable of known type: entity
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :31 :28) // entity.StartDate (SimpleMemberAccessExpression)
%20 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :32 :30) // Not a variable of known type: _coporationMapper
%21 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :32 :71) // Not a variable of known type: entity
%22 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :32 :71) // entity.Corporation (SimpleMemberAccessExpression)
%23 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :32 :30) // _coporationMapper.MapEntityToReturnModel(entity.Corporation) (InvocationExpression)
%24 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :33 :33) // Not a variable of known type: _costAllocationMapper
%25 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :33 :78) // Not a variable of known type: entity
%26 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :33 :78) // entity.CostAllocation (SimpleMemberAccessExpression)
%27 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :33 :33) // _costAllocationMapper.MapEntityToReturnModel(entity.CostAllocation) (InvocationExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :24 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.RecordMappers.RecordMapper.MapModelToEntity$eMenka.API.Models.RecordModels.RecordModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :37 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :37 :39)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :37 :39)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :39 :19) // new Record              {                  Usage = model.Usage,                  CorporationId = model.CorporationId,                  CostAllocationId = model.CostAllocationId,                  EndDate = model.EndDate,                  FuelCardId = (int)model.FuelCardId,                  Id = model.Id,                  StartDate = model.StartDate,                  Term = model.Term              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :41 :24) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :41 :24) // model.Usage (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :42 :32) // Not a variable of known type: model
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :42 :32) // model.CorporationId (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :43 :35) // Not a variable of known type: model
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :43 :35) // model.CostAllocationId (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :44 :26) // Not a variable of known type: model
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :44 :26) // model.EndDate (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :45 :34) // Not a variable of known type: model
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :45 :34) // model.FuelCardId (SimpleMemberAccessExpression)
%12 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :45 :29) // (int)model.FuelCardId (CastExpression)
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :46 :21) // Not a variable of known type: model
%14 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :46 :21) // model.Id (SimpleMemberAccessExpression)
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :47 :28) // Not a variable of known type: model
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :47 :28) // model.StartDate (SimpleMemberAccessExpression)
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :48 :23) // Not a variable of known type: model
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :48 :23) // model.Term (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\RecordMapper.cs" :39 :12)

^1: // ExitBlock
cbde.unreachable

}
