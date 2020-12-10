func @_eMenka.API.Mappers.RecordMappers.CorporationMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Corporation$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :15 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :15 :61)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :15 :61)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :17 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :17 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :17 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :17 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :18 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :18 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :19 :19) // new CorporationReturnModel              {                  Abbreviation = entity.Abbreviation,                  Company = _companyMapper.MapEntityToReturnModel(entity.Company),                  EndDate = entity.EndDate,                  Id = entity.Id,                  Name = entity.Name,                  StartDate = entity.StartDate              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :21 :31) // Not a variable of known type: entity
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :21 :31) // entity.Abbreviation (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :22 :26) // Not a variable of known type: _companyMapper
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :22 :64) // Not a variable of known type: entity
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :22 :64) // entity.Company (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :22 :26) // _companyMapper.MapEntityToReturnModel(entity.Company) (InvocationExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :23 :26) // Not a variable of known type: entity
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :23 :26) // entity.EndDate (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :24 :21) // Not a variable of known type: entity
%15 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :24 :21) // entity.Id (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :25 :23) // Not a variable of known type: entity
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :25 :23) // entity.Name (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :26 :28) // Not a variable of known type: entity
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :26 :28) // entity.StartDate (SimpleMemberAccessExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :19 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.RecordMappers.CorporationMapper.MapModelToEntity$eMenka.API.Models.RecordModels.CorporationModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :30 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :30 :44)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :30 :44)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :32 :19) // new Corporation              {                  Abbreviation = model.Abbreviation,                  CompanyId = (int)model.CompanyId,                  EndDate = model.EndDate,                  Name = model.Name,                  Id = model.Id,                  StartDate = model.StartDate              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :34 :31) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :34 :31) // model.Abbreviation (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :35 :33) // Not a variable of known type: model
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :35 :33) // model.CompanyId (SimpleMemberAccessExpression)
%6 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :35 :28) // (int)model.CompanyId (CastExpression)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :36 :26) // Not a variable of known type: model
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :36 :26) // model.EndDate (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :37 :23) // Not a variable of known type: model
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :37 :23) // model.Name (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :38 :21) // Not a variable of known type: model
%12 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :38 :21) // model.Id (SimpleMemberAccessExpression)
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :39 :28) // Not a variable of known type: model
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :39 :28) // model.StartDate (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CorporationMapper.cs" :32 :12)

^1: // ExitBlock
cbde.unreachable

}
