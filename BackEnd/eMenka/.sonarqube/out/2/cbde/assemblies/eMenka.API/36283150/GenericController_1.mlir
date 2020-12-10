func @_eMenka.API.Controllers.GenericController$TEntity.TModel.TReturnModel$.GetAllEntities$$() -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :28 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :31 :27) // Not a variable of known type: _genericRepository
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :31 :27) // _genericRepository.GetAll() (InvocationExpression)
// Entity from another assembly: Ok
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :33 :22) // Not a variable of known type: entities
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :33 :38) // Not a variable of known type: _mapper
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :33 :22) // entities.Select(_mapper.MapEntityToReturnModel) (InvocationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :33 :22) // entities.Select(_mapper.MapEntityToReturnModel).ToList() (InvocationExpression)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :33 :19) // Ok(entities.Select(_mapper.MapEntityToReturnModel).ToList()) (InvocationExpression)
return %7 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :33 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Controllers.GenericController$TEntity.TModel.TReturnModel$.GetEntityById$int$(i32) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :36 :8) {
^entry (%_id : i32):
%0 = cbde.alloca i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :37 :51)
cbde.store %_id, %0 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :37 :51)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :39 :25) // Not a variable of known type: _genericRepository
%2 = cbde.load %0 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :39 :52)
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :39 :25) // _genericRepository.GetById(id) (InvocationExpression)
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :40 :16) // Not a variable of known type: entity
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :40 :26) // null (NullLiteralExpression)
%7 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :40 :16) // comparison of unknown type: entity == null
cond_br %7, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :40 :16)

^1: // JumpBlock
// Entity from another assembly: NotFound
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :41 :40) // typeof(TEntity) (TypeOfExpression)
%9 = cbde.load %0 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :41 :74)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :41 :32) // $"Geen {typeof(TEntity)} gevonden met id {id}" (InterpolatedStringExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :41 :23) // NotFound($"Geen {typeof(TEntity)} gevonden met id {id}") (InvocationExpression)
return %11 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :41 :16)

^2: // JumpBlock
// Entity from another assembly: Ok
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :43 :22) // Not a variable of known type: _mapper
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :43 :53) // Not a variable of known type: entity
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :43 :22) // _mapper.MapEntityToReturnModel(entity) (InvocationExpression)
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :43 :19) // Ok(_mapper.MapEntityToReturnModel(entity)) (InvocationExpression)
return %15 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :43 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Controllers.GenericController$TEntity.TModel.TReturnModel$.PostEntity$TModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :46 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :47 :48)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :47 :48)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :49 :17) // Identifier from another assembly: ModelState
%2 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :49 :17) // ModelState.IsValid (SimpleMemberAccessExpression)
%3 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :49 :16) // !ModelState.IsValid (LogicalNotExpression)
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :49 :16)

^1: // JumpBlock
// Entity from another assembly: BadRequest
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :49 :44) // BadRequest() (InvocationExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :49 :37)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :51 :25) // Not a variable of known type: _mapper
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :51 :50) // Not a variable of known type: model
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :51 :25) // _mapper.MapModelToEntity(model) (InvocationExpression)
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :53 :12) // Not a variable of known type: _genericRepository
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :53 :35) // Not a variable of known type: entity
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :53 :12) // _genericRepository.Add(entity) (InvocationExpression)
// Entity from another assembly: Ok
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :55 :22) // Not a variable of known type: _mapper
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :55 :53) // Not a variable of known type: entity
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :55 :22) // _mapper.MapEntityToReturnModel(entity) (InvocationExpression)
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :55 :19) // Ok(_mapper.MapEntityToReturnModel(entity)) (InvocationExpression)
return %15 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :55 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Controllers.GenericController$TEntity.TModel.TReturnModel$.UpdateEntity$TModel.int$(none, i32) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :58 :8) {
^entry (%_model : none, %_id : i32):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :59 :50)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :59 :50)
%1 = cbde.alloca i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :59 :75)
cbde.store %_id, %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :59 :75)
br ^0

^0: // BinaryBranchBlock
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :61 :17) // Identifier from another assembly: ModelState
%3 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :61 :17) // ModelState.IsValid (SimpleMemberAccessExpression)
%4 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :61 :16) // !ModelState.IsValid (LogicalNotExpression)
cond_br %4, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :61 :16)

^1: // JumpBlock
// Entity from another assembly: BadRequest
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :61 :44) // BadRequest() (InvocationExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :61 :37)

^2: // BinaryBranchBlock
%6 = cbde.load %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :63 :16)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :63 :22) // Not a variable of known type: model
%8 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :63 :22) // model.Id (SimpleMemberAccessExpression)
%9 = cmpi "ne", %6, %8 : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :63 :16)
cond_br %9, ^3, ^4 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :63 :16)

^3: // JumpBlock
// Entity from another assembly: BadRequest
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :64 :34) // "Id van model komt niet overeen met id van query parameter" (StringLiteralExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :64 :23) // BadRequest("Id van model komt niet overeen met id van query parameter") (InvocationExpression)
return %11 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :64 :16)

^4: // BinaryBranchBlock
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :66 :28) // Not a variable of known type: _genericRepository
%13 = cbde.load %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :66 :54)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :66 :58) // Not a variable of known type: _mapper
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :66 :83) // Not a variable of known type: model
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :66 :58) // _mapper.MapModelToEntity(model) (InvocationExpression)
%17 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :66 :28) // _genericRepository.Update(id, _mapper.MapModelToEntity(model)) (InvocationExpression)
%18 = cbde.alloca i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :66 :16) // isUpdated
cbde.store %17, %18 : memref<i1> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :66 :16)
%19 = cbde.load %18 : memref<i1> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :68 :17)
%20 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :68 :16) // !isUpdated (LogicalNotExpression)
cond_br %20, ^5, ^6 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :68 :16)

^5: // JumpBlock
// Entity from another assembly: NotFound
%21 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :69 :40) // typeof(TEntity) (TypeOfExpression)
%22 = cbde.load %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :69 :74)
%23 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :69 :32) // $"Geen {typeof(TEntity)} gevonden met id {id}" (InterpolatedStringExpression)
%24 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :69 :23) // NotFound($"Geen {typeof(TEntity)} gevonden met id {id}") (InvocationExpression)
return %24 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :69 :16)

^6: // JumpBlock
// Entity from another assembly: Ok
%25 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :71 :19) // Ok() (InvocationExpression)
return %25 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :71 :12)

^7: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Controllers.GenericController$TEntity.TModel.TReturnModel$.DeleteEntity$int$(i32) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :74 :8) {
^entry (%_id : i32):
%0 = cbde.alloca i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :75 :50)
cbde.store %_id, %0 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :75 :50)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :77 :25) // Not a variable of known type: _genericRepository
%2 = cbde.load %0 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :77 :52)
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :77 :25) // _genericRepository.GetById(id) (InvocationExpression)
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :78 :16) // Not a variable of known type: entity
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :78 :26) // null (NullLiteralExpression)
%7 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :78 :16) // comparison of unknown type: entity == null
cond_br %7, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :78 :16)

^1: // JumpBlock
// Entity from another assembly: NotFound
%8 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :79 :40) // typeof(TEntity) (TypeOfExpression)
%9 = cbde.load %0 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :79 :74)
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :79 :32) // $"Geen {typeof(TEntity)} gevonden met id {id}" (InterpolatedStringExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :79 :23) // NotFound($"Geen {typeof(TEntity)} gevonden met id {id}") (InvocationExpression)
return %11 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :79 :16)

^2: // JumpBlock
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :81 :12) // Not a variable of known type: _genericRepository
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :81 :38) // Not a variable of known type: entity
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :81 :12) // _genericRepository.Remove(entity) (InvocationExpression)
// Entity from another assembly: Ok
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :82 :19) // Ok() (InvocationExpression)
return %15 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\GenericController.cs" :82 :12)

^3: // ExitBlock
cbde.unreachable

}
