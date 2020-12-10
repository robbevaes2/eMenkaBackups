func @_eMenka.Data.Repositories.GenericRepository$TEntity$.GetAll$$() -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :20 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :22 :27) // Not a variable of known type: _dbSet
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :22 :27) // _dbSet.ToList() (InvocationExpression)
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :23 :19) // Not a variable of known type: entities
return %3 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :23 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_eMenka.Data.Repositories.GenericRepository$TEntity$.GetById$int$(i32) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :26 :8) {
^entry (%_id : i32):
%0 = cbde.alloca i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :26 :39)
cbde.store %_id, %0 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :26 :39)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :28 :25) // Not a variable of known type: _dbSet
%2 = cbde.load %0 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :28 :37)
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :28 :25) // _dbSet.Find(id) (InvocationExpression)
%5 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :29 :19) // Not a variable of known type: entity
return %5 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :29 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_eMenka.Data.Repositories.GenericRepository$TEntity$.Find$System.Linq.Expressions.Expression$System.Func$TEntity.bool$$$(none) -> none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :32 :8) {
^entry (%_statement : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :32 :49)
cbde.store %_statement, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :32 :49)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :34 :27) // Not a variable of known type: _dbSet
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :34 :40) // Not a variable of known type: statement
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :34 :27) // _dbSet.Where(statement) (InvocationExpression)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :34 :27) // _dbSet.Where(statement).ToList() (InvocationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :36 :19) // Not a variable of known type: entities
return %6 : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :36 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_eMenka.Data.Repositories.GenericRepository$TEntity$.Add$TEntity$(none) -> () loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :39 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :39 :32)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :39 :32)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :41 :12) // Not a variable of known type: _dbSet
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :41 :23) // Not a variable of known type: entity
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :41 :12) // _dbSet.Add(entity) (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Save
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :42 :12) // Save() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_eMenka.Data.Repositories.GenericRepository$TEntity$.Remove$TEntity$(none) -> () loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :45 :8) {
^entry (%_entity : none):
%0 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :45 :27)
cbde.store %_entity, %0 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :45 :27)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :47 :12) // Not a variable of known type: _dbSet
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :47 :26) // Not a variable of known type: entity
%3 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :47 :12) // _dbSet.Remove(entity) (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Save
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :48 :12) // Save() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_eMenka.Data.Repositories.GenericRepository$TEntity$.Update$int.TEntity$(i32, none) -> i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :51 :8) {
^entry (%_id : i32, %_entity : none):
%0 = cbde.alloca i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :51 :35)
cbde.store %_id, %0 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :51 :35)
%1 = cbde.alloca none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :51 :43)
cbde.store %_entity, %1 : memref<none> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :51 :43)
br ^0

^0: // BinaryBranchBlock
%2 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :53 :33) // Not a variable of known type: _dbSet
%3 = cbde.load %0 : memref<i32> loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :53 :45)
%4 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :53 :33) // _dbSet.Find(id) (InvocationExpression)
%6 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :54 :16) // Not a variable of known type: originalEntity
%7 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :54 :34) // null (NullLiteralExpression)
%8 = cbde.unknown : i1  loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :54 :16) // comparison of unknown type: originalEntity == null
cond_br %8, ^1, ^2 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :54 :16)

^1: // JumpBlock
%9 = constant 0 : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :54 :47) // false
return %9 : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :54 :40)

^2: // JumpBlock
%10 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :56 :12) // Not a variable of known type: _context
%11 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :56 :27) // Not a variable of known type: originalEntity
%12 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :56 :12) // _context.Entry(originalEntity) (InvocationExpression)
%13 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :56 :12) // _context.Entry(originalEntity).CurrentValues (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :56 :67) // Not a variable of known type: entity
%15 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :56 :12) // _context.Entry(originalEntity).CurrentValues.SetValues(entity) (InvocationExpression)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Save
%16 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :57 :12) // Save() (InvocationExpression)
%17 = constant 1 : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :59 :19) // true
return %17 : i1 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :59 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_eMenka.Data.Repositories.GenericRepository$TEntity$.Save$$() -> () loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :63 :8) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :65 :12) // Not a variable of known type: _context
%1 = cbde.unknown : i32 loc("D:\\pxl\\workspace_project\\emenka20\\eMenka\\BackEnd\\eMenka\\eMenka.Data\\Repositories\\GenericRepository.cs" :65 :12) // _context.SaveChanges() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
