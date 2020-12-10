// Skipping function GetVehicleByBrandId(i32), it contains poisonous unsupported syntaxes

// Skipping function GetAvailableVehicleByBrandId(i32), it contains poisonous unsupported syntaxes

func @_eMenka.API.Controllers.VehicleController.GetAllAvailableVehicles$$() -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\VehicleController.cs" :70 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\VehicleController.cs" :73 :27) // Not a variable of known type: _vehicleRepository
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\VehicleController.cs" :73 :27) // _vehicleRepository.GetAllAvailableVehicles() (InvocationExpression)
// Entity from another assembly: Ok
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\VehicleController.cs" :74 :22) // Not a variable of known type: vehicles
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\VehicleController.cs" :74 :38) // Not a variable of known type: _vehicleMapper
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\VehicleController.cs" :74 :22) // vehicles.Select(_vehicleMapper.MapEntityToReturnModel) (InvocationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\VehicleController.cs" :74 :22) // vehicles.Select(_vehicleMapper.MapEntityToReturnModel).ToList() (InvocationExpression)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\VehicleController.cs" :74 :19) // Ok(vehicles.Select(_vehicleMapper.MapEntityToReturnModel).ToList()) (InvocationExpression)
return %7 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\VehicleController.cs" :74 :12)

^1: // ExitBlock
cbde.unreachable

}
// Skipping function GetVehiclesByBrandName(none), it contains poisonous unsupported syntaxes

// Skipping function GetVehicleByModelId(i32), it contains poisonous unsupported syntaxes

// Skipping function GetVehicleByStatus(i1), it contains poisonous unsupported syntaxes

// Skipping function GetVehiclesByEndDate(i32), it contains poisonous unsupported syntaxes

// Skipping function PostEntity(none), it contains poisonous unsupported syntaxes

// Skipping function UpdateEntity(none, i32), it contains poisonous unsupported syntaxes

