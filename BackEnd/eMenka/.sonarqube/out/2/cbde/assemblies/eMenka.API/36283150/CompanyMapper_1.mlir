func @_eMenka.API.Mappers.RecordMappers.CompanyMapper.MapEntityToReturnModel$eMenka.Domain.Classes.Company$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :8 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :8 :57)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :8 :57)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :10 :16) // Not a variable of known type: entity
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :10 :26) // null (NullLiteralExpression)
%3 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :10 :16) // comparison of unknown type: entity == null
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :10 :16)

^1: // JumpBlock
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :11 :23) // null (NullLiteralExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :11 :16)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :12 :19) // new CompanyReturnModel              {                  Name = entity.Name,                  AccountNumber = entity.AccountNumber,                  Description = entity.Description,                  Id = entity.Id,                  IsActive = entity.IsActive,                  IsInternal = entity.IsInternal,                  NonActiveRemark = entity.NonActiveRemark,                  Reference = entity.Reference,                  VAT = entity.VAT              } (ObjectCreationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :14 :23) // Not a variable of known type: entity
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :14 :23) // entity.Name (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :15 :32) // Not a variable of known type: entity
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :15 :32) // entity.AccountNumber (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :16 :30) // Not a variable of known type: entity
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :16 :30) // entity.Description (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :17 :21) // Not a variable of known type: entity
%13 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :17 :21) // entity.Id (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :18 :27) // Not a variable of known type: entity
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :18 :27) // entity.IsActive (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :19 :29) // Not a variable of known type: entity
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :19 :29) // entity.IsInternal (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :20 :34) // Not a variable of known type: entity
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :20 :34) // entity.NonActiveRemark (SimpleMemberAccessExpression)
%20 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :21 :28) // Not a variable of known type: entity
%21 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :21 :28) // entity.Reference (SimpleMemberAccessExpression)
%22 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :22 :22) // Not a variable of known type: entity
%23 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :22 :22) // entity.VAT (SimpleMemberAccessExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :12 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Mappers.RecordMappers.CompanyMapper.MapModelToEntity$eMenka.API.Models.RecordModels.CompanyModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :26 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :26 :40)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :26 :40)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :28 :19) // new Company              {                  AccountNumber = model.AccountNumber,                  Description = model.Description,                  Id = model.Id,                  IsActive = model.IsActive,                  IsInternal = model.IsInternal,                  Name = model.Name,                  NonActiveRemark = model.NonActiveRemark,                  Reference = model.Reference,                  VAT = model.VAT              } (ObjectCreationExpression)
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :30 :32) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :30 :32) // model.AccountNumber (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :31 :30) // Not a variable of known type: model
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :31 :30) // model.Description (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :32 :21) // Not a variable of known type: model
%7 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :32 :21) // model.Id (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :33 :27) // Not a variable of known type: model
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :33 :27) // model.IsActive (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :34 :29) // Not a variable of known type: model
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :34 :29) // model.IsInternal (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :35 :23) // Not a variable of known type: model
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :35 :23) // model.Name (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :36 :34) // Not a variable of known type: model
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :36 :34) // model.NonActiveRemark (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :37 :28) // Not a variable of known type: model
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :37 :28) // model.Reference (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :38 :22) // Not a variable of known type: model
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :38 :22) // model.VAT (SimpleMemberAccessExpression)
return %1 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Mappers\\RecordMappers\\CompanyMapper.cs" :28 :12)

^1: // ExitBlock
cbde.unreachable

}
