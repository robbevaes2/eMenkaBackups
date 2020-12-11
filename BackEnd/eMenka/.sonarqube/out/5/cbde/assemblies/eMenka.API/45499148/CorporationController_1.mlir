func @_eMenka.API.Controllers.CorporationController.PostEntity$eMenka.API.Models.RecordModels.CorporationModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :20 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :21 :49)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :21 :49)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :23 :16) // Not a variable of known type: _companyRepository
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :23 :48) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :23 :48) // model.CompanyId (SimpleMemberAccessExpression)
%4 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :23 :43) // (int)model.CompanyId (CastExpression)
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :23 :16) // _companyRepository.GetById((int)model.CompanyId) (InvocationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :23 :68) // null (NullLiteralExpression)
%7 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :23 :16) // comparison of unknown type: _companyRepository.GetById((int)model.CompanyId) == null
cond_br %7, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :23 :16)

^1: // JumpBlock
// Entity from another assembly: NotFound
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :24 :50) // Not a variable of known type: model
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :24 :50) // model.CompanyId (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :24 :32) // $"Bedrijf met id {model.CompanyId} niet gevonden" (InterpolatedStringExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :24 :23) // NotFound($"Bedrijf met id {model.CompanyId} niet gevonden") (InvocationExpression)
return %11 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :24 :16)

^2: // JumpBlock
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :26 :19) // base (BaseExpression)
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :26 :35) // Not a variable of known type: model
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :26 :19) // base.PostEntity(model) (InvocationExpression)
return %14 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :26 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Controllers.CorporationController.UpdateEntity$eMenka.API.Models.RecordModels.CorporationModel.int$(none, i32) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :29 :8) {
^entry (%_model : none, %_id : i32):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :29 :51)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :29 :51)
%1 = cbde.alloca i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :29 :75)
cbde.store %_id, %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :29 :75)
br ^0

^0: // BinaryBranchBlock
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :31 :16) // Not a variable of known type: _companyRepository
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :31 :48) // Not a variable of known type: model
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :31 :48) // model.CompanyId (SimpleMemberAccessExpression)
%5 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :31 :43) // (int)model.CompanyId (CastExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :31 :16) // _companyRepository.GetById((int)model.CompanyId) (InvocationExpression)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :31 :68) // null (NullLiteralExpression)
%8 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :31 :16) // comparison of unknown type: _companyRepository.GetById((int)model.CompanyId) == null
cond_br %8, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :31 :16)

^1: // JumpBlock
// Entity from another assembly: NotFound
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :32 :50) // Not a variable of known type: model
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :32 :50) // model.CompanyId (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :32 :32) // $"Bedrijf met id {model.CompanyId} niet gevonden" (InterpolatedStringExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :32 :23) // NotFound($"Bedrijf met id {model.CompanyId} niet gevonden") (InvocationExpression)
return %12 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :32 :16)

^2: // JumpBlock
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :34 :19) // base (BaseExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :34 :37) // Not a variable of known type: model
%15 = cbde.load %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :34 :44)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :34 :19) // base.UpdateEntity(model, id) (InvocationExpression)
return %16 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\CorporationController.cs" :34 :12)

^3: // ExitBlock
cbde.unreachable

}
