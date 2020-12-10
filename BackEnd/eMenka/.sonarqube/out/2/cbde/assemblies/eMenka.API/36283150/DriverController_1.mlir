func @_eMenka.API.Controllers.DriverController.GetAllAvailableDrivers$$() -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :26 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :29 :27) // Not a variable of known type: _driverRepository
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :29 :27) // _driverRepository.GetAllAvailableDrivers() (InvocationExpression)
// Entity from another assembly: Ok
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :30 :22) // Not a variable of known type: entities
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :30 :38) // Not a variable of known type: _driverMapper
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :30 :22) // entities.Select(_driverMapper.MapEntityToReturnModel) (InvocationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :30 :19) // Ok(entities.Select(_driverMapper.MapEntityToReturnModel)) (InvocationExpression)
return %6 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :30 :12)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function GetDriverByEndDate(i32), it contains poisonous unsupported syntaxes

func @_eMenka.API.Controllers.DriverController.PostEntity$eMenka.API.Models.FuelCardModels.DriverModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :41 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :41 :49)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :41 :49)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :43 :16) // Not a variable of known type: _personRepository
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :43 :47) // Not a variable of known type: model
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :43 :47) // model.PersonId (SimpleMemberAccessExpression)
%4 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :43 :42) // (int)model.PersonId (CastExpression)
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :43 :16) // _personRepository.GetById((int)model.PersonId) (InvocationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :43 :66) // null (NullLiteralExpression)
%7 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :43 :16) // comparison of unknown type: _personRepository.GetById((int)model.PersonId) == null
cond_br %7, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :43 :16)

^1: // JumpBlock
// Entity from another assembly: NotFound
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :44 :50) // Not a variable of known type: model
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :44 :50) // model.PersonId (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :44 :32) // $"Persoon met id {model.PersonId} niet gevonden" (InterpolatedStringExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :44 :23) // NotFound($"Persoon met id {model.PersonId} niet gevonden") (InvocationExpression)
return %11 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :44 :16)

^2: // JumpBlock
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :46 :19) // base (BaseExpression)
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :46 :35) // Not a variable of known type: model
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :46 :19) // base.PostEntity(model) (InvocationExpression)
return %14 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :46 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Controllers.DriverController.UpdateEntity$eMenka.API.Models.FuelCardModels.DriverModel.int$(none, i32) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :49 :8) {
^entry (%_model : none, %_id : i32):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :49 :51)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :49 :51)
%1 = cbde.alloca i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :49 :70)
cbde.store %_id, %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :49 :70)
br ^0

^0: // BinaryBranchBlock
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :51 :16) // Not a variable of known type: _personRepository
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :51 :47) // Not a variable of known type: model
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :51 :47) // model.PersonId (SimpleMemberAccessExpression)
%5 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :51 :42) // (int)model.PersonId (CastExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :51 :16) // _personRepository.GetById((int)model.PersonId) (InvocationExpression)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :51 :66) // null (NullLiteralExpression)
%8 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :51 :16) // comparison of unknown type: _personRepository.GetById((int)model.PersonId) == null
cond_br %8, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :51 :16)

^1: // JumpBlock
// Entity from another assembly: NotFound
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :52 :50) // Not a variable of known type: model
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :52 :50) // model.PersonId (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :52 :32) // $"Persoon met id {model.PersonId} niet gevonden" (InterpolatedStringExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :52 :23) // NotFound($"Persoon met id {model.PersonId} niet gevonden") (InvocationExpression)
return %12 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :52 :16)

^2: // JumpBlock
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :54 :19) // base (BaseExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :54 :37) // Not a variable of known type: model
%15 = cbde.load %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :54 :44)
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :54 :19) // base.UpdateEntity(model, id) (InvocationExpression)
return %16 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\DriverController.cs" :54 :12)

^3: // ExitBlock
cbde.unreachable

}
