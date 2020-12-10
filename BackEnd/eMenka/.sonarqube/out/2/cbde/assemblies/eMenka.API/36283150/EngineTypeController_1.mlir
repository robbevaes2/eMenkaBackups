// Skipping function GetEngineTypesByBrandId(i32), it contains poisonous unsupported syntaxes

// Skipping function GetEngineTypeByName(none), it contains poisonous unsupported syntaxes

func @_eMenka.API.Controllers.EngineTypeController.PostEntity$eMenka.API.Models.VehicleModels.EngineTypeModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :44 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :44 :49)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :44 :49)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :46 :16) // Not a variable of known type: _brandRepository
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :46 :46) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :46 :46) // model.BrandId (SimpleMemberAccessExpression)
%4 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :46 :41) // (int)model.BrandId (CastExpression)
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :46 :16) // _brandRepository.GetById((int)model.BrandId) (InvocationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :46 :64) // null (NullLiteralExpression)
%7 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :46 :16) // comparison of unknown type: _brandRepository.GetById((int)model.BrandId) == null
cond_br %7, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :46 :16)

^1: // JumpBlock
// Entity from another assembly: NotFound
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :47 :47) // Not a variable of known type: model
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :47 :47) // model.BrandId (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :47 :32) // $"Merk met id {model.BrandId} niet gevonden" (InterpolatedStringExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :47 :23) // NotFound($"Merk met id {model.BrandId} niet gevonden") (InvocationExpression)
return %11 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :47 :16)

^2: // JumpBlock
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :49 :19) // base (BaseExpression)
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :49 :35) // Not a variable of known type: model
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :49 :19) // base.PostEntity(model) (InvocationExpression)
return %14 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :49 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Controllers.EngineTypeController.UpdateEntity$eMenka.API.Models.VehicleModels.EngineTypeModel.int$(none, i32) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :52 :8) {
^entry (%_model : none, %_id : i32):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :52 :51)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :52 :51)
%1 = cbde.alloca i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :52 :74)
cbde.store %_id, %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :52 :74)
br ^0

^0: // BinaryBranchBlock
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :54 :16) // Not a variable of known type: _brandRepository
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :54 :46) // Not a variable of known type: model
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :54 :46) // model.BrandId (SimpleMemberAccessExpression)
%5 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :54 :41) // (int)model.BrandId (CastExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :54 :16) // _brandRepository.GetById((int)model.BrandId) (InvocationExpression)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :54 :64) // null (NullLiteralExpression)
%8 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :54 :16) // comparison of unknown type: _brandRepository.GetById((int)model.BrandId) == null
cond_br %8, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :54 :16)

^1: // JumpBlock
// Entity from another assembly: NotFound
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :55 :47) // Not a variable of known type: model
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :55 :47) // model.BrandId (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :55 :32) // $"Merk met id {model.BrandId} niet gevonden" (InterpolatedStringExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :55 :23) // NotFound($"Merk met id {model.BrandId} niet gevonden") (InvocationExpression)
return %12 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :55 :16)

^2: // JumpBlock
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :57 :19) // base (BaseExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :57 :37) // Not a variable of known type: model
%15 = cbde.load %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :57 :44)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :57 :19) // base.UpdateEntity(model, id) (InvocationExpression)
return %16 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\EngineTypeController.cs" :57 :12)

^3: // ExitBlock
cbde.unreachable

}
