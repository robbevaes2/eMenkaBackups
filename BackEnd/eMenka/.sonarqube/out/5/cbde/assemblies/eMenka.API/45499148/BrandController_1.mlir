// Skipping function GetBrandsByName(none), it contains poisonous unsupported syntaxes

func @_eMenka.API.Controllers.BrandController.PostEntity$eMenka.API.Models.VehicleModels.BrandModel$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :35 :8) {
^entry (%_model : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :36 :49)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :36 :49)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :38 :17) // Identifier from another assembly: ModelState
%2 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :38 :17) // ModelState.IsValid (SimpleMemberAccessExpression)
%3 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :38 :16) // !ModelState.IsValid (LogicalNotExpression)
cond_br %3, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :38 :16)

^1: // JumpBlock
// Entity from another assembly: BadRequest
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :38 :44) // BadRequest() (InvocationExpression)
return %4 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :38 :37)

^2: // JumpBlock
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :40 :24) // Not a variable of known type: _brandMapper
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :40 :54) // Not a variable of known type: model
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :40 :24) // _brandMapper.MapModelToEntity(model) (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: AddColors
%9 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :41 :22) // Not a variable of known type: brand
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :41 :29) // Not a variable of known type: model
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :41 :12) // AddColors(brand, model) (InvocationExpression)
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :43 :12) // Not a variable of known type: _brandRepository
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :43 :33) // Not a variable of known type: brand
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :43 :12) // _brandRepository.Add(brand) (InvocationExpression)
// Entity from another assembly: Ok
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :44 :22) // Not a variable of known type: _brandMapper
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :44 :58) // Not a variable of known type: brand
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :44 :22) // _brandMapper.MapEntityToReturnModel(brand) (InvocationExpression)
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :44 :19) // Ok(_brandMapper.MapEntityToReturnModel(brand)) (InvocationExpression)
return %18 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :44 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Controllers.BrandController.UpdateEntity$eMenka.API.Models.VehicleModels.BrandModel.int$(none, i32) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :47 :8) {
^entry (%_model : none, %_id : i32):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :48 :51)
cbde.store %_model, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :48 :51)
%1 = cbde.alloca i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :48 :80)
cbde.store %_id, %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :48 :80)
br ^0

^0: // BinaryBranchBlock
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :50 :17) // Identifier from another assembly: ModelState
%3 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :50 :17) // ModelState.IsValid (SimpleMemberAccessExpression)
%4 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :50 :16) // !ModelState.IsValid (LogicalNotExpression)
cond_br %4, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :50 :16)

^1: // JumpBlock
// Entity from another assembly: BadRequest
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :50 :44) // BadRequest() (InvocationExpression)
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :50 :37)

^2: // BinaryBranchBlock
%6 = cbde.load %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :52 :16)
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :52 :22) // Not a variable of known type: model
%8 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :52 :22) // model.Id (SimpleMemberAccessExpression)
%9 = cmpi "ne", %6, %8 : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :52 :16)
cond_br %9, ^3, ^4 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :52 :16)

^3: // JumpBlock
// Entity from another assembly: BadRequest
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :53 :34) // "Id van model komt niet overeen met id van query parameter" (StringLiteralExpression)
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :53 :23) // BadRequest("Id van model komt niet overeen met id van query parameter") (InvocationExpression)
return %11 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :53 :16)

^4: // BinaryBranchBlock
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :55 :24) // Not a variable of known type: _brandMapper
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :55 :54) // Not a variable of known type: model
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :55 :24) // _brandMapper.MapModelToEntity(model) (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: AddColors
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :56 :22) // Not a variable of known type: brand
%17 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :56 :29) // Not a variable of known type: model
%18 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :56 :12) // AddColors(brand, model) (InvocationExpression)
%19 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :58 :28) // Not a variable of known type: _brandRepository
%20 = cbde.load %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :58 :52)
%21 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :58 :56) // Not a variable of known type: brand
%22 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :58 :28) // _brandRepository.Update(id, brand) (InvocationExpression)
%23 = cbde.alloca i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :58 :16) // isUpdated
cbde.store %22, %23 : memref<i1> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :58 :16)
%24 = cbde.load %23 : memref<i1> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :60 :17)
%25 = cbde.unknown : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :60 :16) // !isUpdated (LogicalNotExpression)
cond_br %25, ^5, ^6 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :60 :16)

^5: // JumpBlock
// Entity from another assembly: NotFound
%26 = cbde.load %1 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :61 :61)
%27 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :61 :32) // $"Geen merk gevonden met id {id}" (InterpolatedStringExpression)
%28 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :61 :23) // NotFound($"Geen merk gevonden met id {id}") (InvocationExpression)
return %28 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :61 :16)

^6: // JumpBlock
// Entity from another assembly: Ok
%29 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :63 :19) // Ok() (InvocationExpression)
return %29 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :63 :12)

^7: // ExitBlock
cbde.unreachable

}
func @_eMenka.API.Controllers.BrandController.AddColors$eMenka.Domain.Classes.Brand.eMenka.API.Models.VehicleModels.BrandModel$(none, none) -> () loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :66 :8) {
^entry (%_brand : none, %_brandModel : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :66 :31)
cbde.store %_brand, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :66 :31)
%1 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :66 :44)
cbde.store %_brandModel, %1 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :66 :44)
br ^0

^0: // SimpleBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: AddExteriorColors
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :68 :30) // Not a variable of known type: brand
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :68 :37) // Not a variable of known type: brandModel
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :68 :12) // AddExteriorColors(brand, brandModel) (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: AddInteriorColors
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :70 :30) // Not a variable of known type: brand
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :70 :37) // Not a variable of known type: brandModel
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.API\\Controllers\\BrandController.cs" :70 :12) // AddInteriorColors(brand, brandModel) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function AddInteriorColors(none, none), it contains poisonous unsupported syntaxes

// Skipping function AddExteriorColors(none, none), it contains poisonous unsupported syntaxes

