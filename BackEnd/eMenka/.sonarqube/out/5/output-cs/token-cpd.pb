—?
aD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\BrandController.cs
	namespace		 	
eMenka		
 
.		 
API		 
.		 
Controllers		  
{

 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
BrandController  
:! "
GenericController# 4
<4 5
Brand5 :
,: ;

BrandModel< F
,F G
BrandReturnModelH X
>X Y
{ 
private 
readonly 
BrandMapper $
_brandMapper% 1
;1 2
private 
readonly 
IBrandRepository )
_brandRepository* :
;: ;
private 
readonly $
IExteriorColorRepository 1$
_exteriorColorRepository2 J
;J K
private 
readonly $
IInteriorColorRepository 1$
_interiorColorRepository2 J
;J K
public 
BrandController 
( 
IBrandRepository /
brandRepository0 ?
,? @$
IExteriorColorRepositoryA Y#
exteriorColorRepositoryZ q
,q r$
IInteriorColorRepository $#
interiorColorRepository% <
)< =
:> ?
base@ D
(D E
brandRepositoryE T
,T U
newV Y
BrandMapperZ e
(e f
)f g
)g h
{ 	
_brandRepository 
= 
brandRepository .
;. /$
_exteriorColorRepository $
=% &#
exteriorColorRepository' >
;> ?$
_interiorColorRepository $
=% &#
interiorColorRepository' >
;> ?
_brandMapper 
= 
new 
BrandMapper *
(* +
)+ ,
;, -
} 	
[ 	
HttpGet	 
( 
$str #
)# $
]$ %
public 
IActionResult 
GetBrandsByName ,
(, -
string- 3
	brandName4 =
)= >
{ 	
var 
brands 
= 
_brandRepository )
.) *
Find* .
(. /
brand/ 4
=>5 7
brand8 =
.= >
Name> B
==C E
	brandNameF O
)O P
;P Q
return!! 
Ok!! 
(!! 
brands!! 
.!! 
Select!! #
(!!# $
_brandMapper!!$ 0
.!!0 1"
MapEntityToReturnModel!!1 G
)!!G H
.!!H I
ToList!!I O
(!!O P
)!!P Q
)!!Q R
;!!R S
}"" 	
[$$ 	
HttpPost$$	 
]$$ 
public%% 
override%% 
IActionResult%% %

PostEntity%%& 0
(%%0 1
[%%1 2
FromBody%%2 :
]%%: ;

BrandModel%%< F
model%%G L
)%%L M
{&& 	
if'' 
('' 
!'' 

ModelState'' 
.'' 
IsValid'' #
)''# $
return''% +

BadRequest'', 6
(''6 7
)''7 8
;''8 9
var)) 
brand)) 
=)) 
_brandMapper)) $
.))$ %
MapModelToEntity))% 5
())5 6
model))6 ;
))); <
;))< =
	AddColors** 
(** 
brand** 
,** 
model** "
)**" #
;**# $
_brandRepository,, 
.,, 
Add,,  
(,,  !
brand,,! &
),,& '
;,,' (
return-- 
Ok-- 
(-- 
_brandMapper-- "
.--" #"
MapEntityToReturnModel--# 9
(--9 :
brand--: ?
)--? @
)--@ A
;--A B
}.. 	
[00 	
HttpPut00	 
(00 
$str00 
)00 
]00 
public11 
override11 
IActionResult11 %
UpdateEntity11& 2
(112 3
[113 4
FromBody114 <
]11< =

BrandModel11> H
model11I N
,11N O
int11P S
id11T V
)11V W
{22 	
if33 
(33 
!33 

ModelState33 
.33 
IsValid33 #
)33# $
return33% +

BadRequest33, 6
(336 7
)337 8
;338 9
if55 
(55 
id55 
!=55 
model55 
.55 
Id55 
)55 
return66 

BadRequest66 !
(66! "
$str66" ]
)66] ^
;66^ _
var88 
brand88 
=88 
_brandMapper88 $
.88$ %
MapModelToEntity88% 5
(885 6
model886 ;
)88; <
;88< =
	AddColors99 
(99 
brand99 
,99 
model99 "
)99" #
;99# $
var;; 
	isUpdated;; 
=;; 
_brandRepository;; ,
.;;, -
Update;;- 3
(;;3 4
id;;4 6
,;;6 7
brand;;8 =
);;= >
;;;> ?
if== 
(== 
!== 
	isUpdated== 
)== 
return>> 
NotFound>> 
(>>  
$">>  "&
Geen merk gevonden met id >>" <
{>>< =
id>>= ?
}>>? @
">>@ A
)>>A B
;>>B C
return@@ 
Ok@@ 
(@@ 
)@@ 
;@@ 
}AA 	
privateCC 
voidCC 
	AddColorsCC 
(CC 
BrandCC $
brandCC% *
,CC* +

BrandModelCC, 6

brandModelCC7 A
)CCA B
{DD 	
AddExteriorColorsEE 
(EE 
brandEE #
,EE# $

brandModelEE% /
)EE/ 0
;EE0 1
AddInteriorColorsGG 
(GG 
brandGG #
,GG# $

brandModelGG% /
)GG/ 0
;GG0 1
}HH 	
privateJJ 
voidJJ 
AddInteriorColorsJJ &
(JJ& '
BrandJJ' ,
brandJJ- 2
,JJ2 3

BrandModelJJ4 >

brandModelJJ? I
)JJI J
{KK 	
foreachLL 
(LL 
varLL %
brandModelInteriorColorIdLL 2
inLL3 5

brandModelLL6 @
.LL@ A
InteriorColorIdsLLA Q
)LLQ R
{MM 
varNN 
colorNN 
=NN $
_interiorColorRepositoryNN 4
.NN4 5
GetByIdNN5 <
(NN< =%
brandModelInteriorColorIdNN= V
)NNV W
;NNW X
ifOO 
(OO 
colorOO 
!=OO 
nullOO !
)OO! "
brandPP 
.PP 
InteriorColorsPP (
.PP( )
AddPP) ,
(PP, -
colorPP- 2
)PP2 3
;PP3 4
}QQ 
}RR 	
privateTT 
voidTT 
AddExteriorColorsTT &
(TT& '
BrandTT' ,
brandTT- 2
,TT2 3

BrandModelTT4 >

brandModelTT? I
)TTI J
{UU 	
foreachVV 
(VV 
varVV %
brandModelExteriorColorIdVV 2
inVV3 5

brandModelVV6 @
.VV@ A
ExteriorColorIdsVVA Q
)VVQ R
{WW 
varXX 
colorXX 
=XX $
_exteriorColorRepositoryXX 4
.XX4 5
GetByIdXX5 <
(XX< =%
brandModelExteriorColorIdXX= V
)XXV W
;XXW X
ifYY 
(YY 
colorYY 
!=YY 
nullYY !
)YY! "
brandZZ 
.ZZ 
ExteriorColorsZZ (
.ZZ( )
AddZZ) ,
(ZZ, -
colorZZ- 2
)ZZ2 3
;ZZ3 4
}[[ 
}\\ 	
}]] 
}^^ µ
dD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\CategoryController.cs
	namespace		 	
eMenka		
 
.		 
API		 
.		 
Controllers		  
{

 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
CategoryController #
:$ %
GenericController& 7
<7 8
Category8 @
,@ A
CategoryModelB O
,O P
CategoryReturnModelQ d
>d e
{ 
private 
readonly 
ICategoryRepository ,
_categoryRepository- @
;@ A
private 
readonly 
CategoryMapper '
_categoryMapper( 7
;7 8
public 
CategoryController !
(! "
ICategoryRepository" 5
categoryRepository6 H
)H I
:J K
baseL P
(P Q
categoryRepositoryQ c
,c d
new 
CategoryMapper 
( 
)  
)  !
{ 	
_categoryRepository 
=  !
categoryRepository" 4
;4 5
_categoryMapper 
= 
new !
CategoryMapper" 0
(0 1
)1 2
;2 3
} 	
[ 	
HttpGet	 
( 
$str &
)& '
]' (
public 
IActionResult 
GetCategoryByName .
(. /
string/ 5
categoryName6 B
)B C
{ 	
var 

categories 
= 
_categoryRepository 0
.0 1
Find1 5
(5 6
category6 >
=>? A
categoryB J
.J K
NameK O
==P R
categoryNameS _
)_ `
;` a
return 
Ok 
( 

categories  
.  !
Select! '
(' (
_categoryMapper( 7
.7 8"
MapEntityToReturnModel8 N
)N O
.O P
ToListP V
(V W
)W X
)X Y
;Y Z
} 	
} 
}   ”
cD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\CompanyController.cs
	namespace 	
eMenka
 
. 
API 
. 
Controllers  
{		 
[

 
Route

 

(


 
$str

 
)

 
]

 
public 

class 
CompanyController "
:# $
GenericController% 6
<6 7
Company7 >
,> ?
CompanyModel@ L
,L M
CompanyReturnModelN `
>` a
{ 
public 
CompanyController  
(  !
ICompanyRepository! 3
companyRepository4 E
)E F
:G H
baseI M
(M N
companyRepositoryN _
,_ `
newa d
CompanyMappere r
(r s
)s t
)t u
{ 	
} 	
} 
} …
gD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\CorporationController.cs
	namespace 	
eMenka
 
. 
API 
. 
Controllers  
{		 
[

 
Route

 

(


 
$str

 
)

 
]

 
public 

class !
CorporationController &
:' (
GenericController) :
<: ;
Corporation; F
,F G
CorporationModelH X
,X Y"
CorporationReturnModelZ p
>p q
{ 
private 
readonly 
ICompanyRepository +
_companyRepository, >
;> ?
public !
CorporationController $
($ %"
ICorporationRepository% ;!
corporationRepository< Q
,Q R
ICompanyRepositoryS e
companyRepositoryf w
)w x
: 
base 
( !
corporationRepository (
,( )
new* -
CorporationMapper. ?
(? @
)@ A
)A B
{ 	
_companyRepository 
=  
companyRepository! 2
;2 3
} 	
[ 	
HttpPost	 
] 
public 
override 
IActionResult %

PostEntity& 0
(0 1
[1 2
FromBody2 :
]: ;
CorporationModel< L
modelM R
)R S
{ 	
if 
( 
_companyRepository "
." #
GetById# *
(* +
(+ ,
int, /
)/ 0
model0 5
.5 6
	CompanyId6 ?
)? @
==A C
nullD H
)H I
return 
NotFound 
(  
$"  "
Bedrijf met id " 1
{1 2
model2 7
.7 8
	CompanyId8 A
}A B
 niet gevondenB P
"P Q
)Q R
;R S
return 
base 
. 

PostEntity "
(" #
model# (
)( )
;) *
} 	
public 
override 
IActionResult %
UpdateEntity& 2
(2 3
CorporationModel3 C
modelD I
,I J
intK N
idO Q
)Q R
{ 	
if   
(   
_companyRepository   "
.  " #
GetById  # *
(  * +
(  + ,
int  , /
)  / 0
model  0 5
.  5 6
	CompanyId  6 ?
)  ? @
==  A C
null  D H
)  H I
return!! 
NotFound!! 
(!!  
$"!!  "
Bedrijf met id !!" 1
{!!1 2
model!!2 7
.!!7 8
	CompanyId!!8 A
}!!A B
 niet gevonden!!B P
"!!P Q
)!!Q R
;!!R S
return## 
base## 
.## 
UpdateEntity## $
(##$ %
model##% *
,##* +
id##, .
)##. /
;##/ 0
}$$ 	
}%% 
}&& ô
jD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\CostAllocationController.cs
	namespace 	
eMenka
 
. 
API 
. 
Controllers  
{		 
[

 
Route

 

(


 
$str

 
)

 
]

 
public 

class $
CostAllocationController  
:! "
GenericController# 4
<4 5
CostAllocation5 C
,C D
CostAllocationModelE X
,X Y%
CostAllocationReturnModelZ s
>s t
{ 
public $
CostAllocationController '
(' (%
ICostAllocationRepository( A$
costAllocationRepositoryB Z
)Z [
:\ ]
base^ b
(b c$
costAllocationRepository $
,$ %
new& ) 
CostAllocationMapper* >
(> ?
)? @
)@ A
{ 	
} 	
} 
} ”
cD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\CountryController.cs
	namespace 	
eMenka
 
. 
API 
. 
Controllers  
{		 
[

 
Route

 

(


 
$str

 
)

 
]

 
public 

class 
CountryController "
:# $
GenericController% 6
<6 7
Country7 >
,> ?
CountryModel@ L
,L M
CountryReturnModelN `
>` a
{ 
public 
CountryController  
(  !
ICountryRepository! 3
countryRepository4 E
)E F
:G H
baseI M
(M N
countryRepositoryN _
,_ `
newa d
CountryMappere r
(r s
)s t
)t u
{ 	
} 	
} 
} ≥
dD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\DoorTypeController.cs
	namespace		 	
eMenka		
 
.		 
API		 
.		 
Controllers		  
{

 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
DoorTypeController #
:$ %
GenericController& 7
<7 8
DoorType8 @
,@ A
DoorTypeModelB O
,O P
DoorTypeReturnModelQ d
>d e
{ 
private 
readonly 
IDoorTypeRepository ,
_doorTypeRepository- @
;@ A
private 
readonly 
DoorTypeMapper '
_doortypeMapper( 7
;7 8
public 
DoorTypeController !
(! "
IDoorTypeRepository" 5
doorTypeRepository6 H
)H I
:J K
baseL P
(P Q
doorTypeRepositoryQ c
,c d
new 
DoorTypeMapper 
( 
)  
)  !
{ 	
_doorTypeRepository 
=  !
doorTypeRepository" 4
;4 5
_doortypeMapper 
= 
new !
DoorTypeMapper" 0
(0 1
)1 2
;2 3
} 	
[ 	
HttpGet	 
( 
$str &
)& '
]' (
public 
IActionResult 
GetDoorTypeByName .
(. /
string/ 5
doorTypeName6 B
)B C
{ 	
var 
	doorTypes 
= 
_doorTypeRepository /
./ 0
Find0 4
(4 5
doorType5 =
=>> @
doorTypeA I
.I J
NameJ N
==O Q
doorTypeNameR ^
)^ _
;_ `
return 
Ok 
( 
	doorTypes 
.  
Select  &
(& '
_doortypeMapper' 6
.6 7"
MapEntityToReturnModel7 M
)M N
.N O
ToListO U
(U V
)V W
)W X
;X Y
} 	
} 
}   £*
bD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\DriverController.cs
	namespace

 	
eMenka


 
.

 
API

 
.

 
Controllers

  
{ 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
DriverController !
:" #
GenericController$ 5
<5 6
Driver6 <
,< =
DriverModel> I
,I J
DriverReturnModelK \
>\ ]
{ 
private 
readonly 
IPersonRepository *
_personRepository+ <
;< =
private 
readonly 
IDriverRepository *
_driverRepository+ <
;< =
private 
readonly 
DriverMapper %
_driverMapper& 3
;3 4
public 
DriverController 
(  
IDriverRepository  1
driverRepository2 B
,B C
IPersonRepositoryD U
personRepositoryV f
)f g
:h i
basej n
(n o
driverRepository 
, 
new !
DriverMapper" .
(. /
)/ 0
)0 1
{ 	
_personRepository 
= 
personRepository  0
;0 1
_driverRepository 
= 
driverRepository  0
;0 1
_driverMapper 
= 
new 
DriverMapper  ,
(, -
)- .
;. /
} 	
[ 	
HttpGet	 
( 
$str 
) 
] 
public 
IActionResult "
GetAllAvailableDrivers 3
(3 4
)4 5
{ 	
var 
entities 
= 
_driverRepository ,
., -"
GetAllAvailableDrivers- C
(C D
)D E
;E F
return 
Ok 
( 
entities 
. 
Select %
(% &
_driverMapper& 3
.3 4"
MapEntityToReturnModel4 J
)J K
)K L
;L M
}   	
["" 	
HttpGet""	 
("" 
$str"" "
)""" #
]""# $
public## 
IActionResult## 
GetDriverByEndDate## /
(##/ 0
int##0 3
range##4 9
)##9 :
{$$ 	
var%% 
drivers%% 
=%% 
_driverRepository%% +
.%%+ ,
Find%%, 0
(%%0 1
v%%1 2
=>%%3 5
v%%6 7
.%%7 8
EndDate%%8 ?
>=%%@ B
DateTime%%C K
.%%K L
Now%%L O
.%%O P
Date%%P T
&&%%U W
v%%X Y
.%%Y Z
EndDate%%Z a
<=%%b d
DateTime%%e m
.%%m n
Now%%n q
.%%q r
Date%%r v
.%%v w
AddDays%%w ~
(%%~ 
range	%% Ñ
)
%%Ñ Ö
)
%%Ö Ü
;
%%Ü á
return'' 
Ok'' 
('' 
drivers'' 
.'' 
Select'' $
(''$ %
_driverMapper''% 2
.''2 3"
MapEntityToReturnModel''3 I
)''I J
.''J K
ToList''K Q
(''Q R
)''R S
)''S T
;''T U
}(( 	
public** 
override** 
IActionResult** %

PostEntity**& 0
(**0 1
DriverModel**1 <
model**= B
)**B C
{++ 	
if,, 
(,, 
_personRepository,, !
.,,! "
GetById,," )
(,,) *
(,,* +
int,,+ .
),,. /
model,,/ 4
.,,4 5
PersonId,,5 =
),,= >
==,,? A
null,,B F
),,F G
return-- 
NotFound-- 
(--  
$"--  "
Persoon met id --" 1
{--1 2
model--2 7
.--7 8
PersonId--8 @
}--@ A
 niet gevonden--A O
"--O P
)--P Q
;--Q R
return// 
base// 
.// 

PostEntity// "
(//" #
model//# (
)//( )
;//) *
}00 	
public22 
override22 
IActionResult22 %
UpdateEntity22& 2
(222 3
DriverModel223 >
model22? D
,22D E
int22F I
id22J L
)22L M
{33 	
if44 
(44 
_personRepository44 !
.44! "
GetById44" )
(44) *
(44* +
int44+ .
)44. /
model44/ 4
.444 5
PersonId445 =
)44= >
==44? A
null44B F
)44F G
return55 
NotFound55 
(55  
$"55  "
Persoon met id 55" 1
{551 2
model552 7
.557 8
PersonId558 @
}55@ A
 niet gevonden55A O
"55O P
)55P Q
;55Q R
return77 
base77 
.77 
UpdateEntity77 $
(77$ %
model77% *
,77* +
id77, .
)77. /
;77/ 0
}88 	
}99 
}:: ¯-
fD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\EngineTypeController.cs
	namespace		 	
eMenka		
 
.		 
API		 
.		 
Controllers		  
{

 
[ 
Route 

(
 
$str 
) 
] 
public 

class  
EngineTypeController %
:& '
GenericController( 9
<9 :

EngineType: D
,D E
EngineTypeModelF U
,U V!
EngineTypeReturnModelW l
>l m
{ 
private 
readonly 
IBrandRepository )
_brandRepository* :
;: ;
private 
readonly !
IEngineTypeRepository .!
_engineTypeRepository/ D
;D E
private 
readonly 
EngineTypeMapper )
_engineTypeMapper* ;
;; <
public  
EngineTypeController #
(# $!
IEngineTypeRepository$ 9 
engineTypeRepository: N
,N O
IBrandRepositoryP `
brandRepositorya p
)p q
:r s
base 
(  
engineTypeRepository %
,% &
new' *
EngineTypeMapper+ ;
(; <
)< =
)= >
{ 	!
_engineTypeRepository !
=" # 
engineTypeRepository$ 8
;8 9
_brandRepository 
= 
brandRepository .
;. /
_engineTypeMapper 
= 
new  #
EngineTypeMapper$ 4
(4 5
)5 6
;6 7
} 	
[ 	
HttpGet	 
( 
$str "
)" #
]# $
public 
IActionResult #
GetEngineTypesByBrandId 4
(4 5
int5 8
brandId9 @
)@ A
{ 	
if 
( 
_brandRepository  
.  !
GetById! (
(( )
brandId) 0
)0 1
==2 4
null5 9
)9 :
return 
NotFound 
(  
$"  "
Merk met id " .
{. /
brandId/ 6
}6 7
 niet gevonden7 E
"E F
)F G
;G H
var   
engineTypes   
=   !
_engineTypeRepository   3
.  3 4
Find  4 8
(  8 9
	motorType  9 B
=>  C E
	motorType  F O
.  O P
Brand  P U
.  U V
Id  V X
==  Y [
brandId  \ c
)  c d
;  d e
return"" 
Ok"" 
("" 
engineTypes"" !
.""! "
Select""" (
(""( )
_engineTypeMapper"") :
."": ;"
MapEntityToReturnModel""; Q
)""Q R
.""R S
ToList""S Y
(""Y Z
)""Z [
)""[ \
;""\ ]
}## 	
[%% 	
HttpGet%%	 
(%% 
$str%% #
)%%# $
]%%$ %
public&& 
IActionResult&& 
GetEngineTypeByName&& 0
(&&0 1
string&&1 7
engineTypeName&&8 F
)&&F G
{'' 	
var(( 
engineTypes(( 
=(( !
_engineTypeRepository(( 3
.((3 4
Find((4 8
(((8 9

engineType((9 C
=>((D F

engineType((G Q
.((Q R
Name((R V
==((W Y
engineTypeName((Z h
)((h i
;((i j
return** 
Ok** 
(** 
engineTypes** !
.**! "
Select**" (
(**( )
_engineTypeMapper**) :
.**: ;"
MapEntityToReturnModel**; Q
)**Q R
.**R S
ToList**S Y
(**Y Z
)**Z [
)**[ \
;**\ ]
}++ 	
public-- 
override-- 
IActionResult-- %

PostEntity--& 0
(--0 1
EngineTypeModel--1 @
model--A F
)--F G
{.. 	
if// 
(// 
_brandRepository//  
.//  !
GetById//! (
(//( )
(//) *
int//* -
)//- .
model//. 3
.//3 4
BrandId//4 ;
)//; <
==//= ?
null//@ D
)//D E
return00 
NotFound00 
(00  
$"00  "
Merk met id 00" .
{00. /
model00/ 4
.004 5
BrandId005 <
}00< =
 niet gevonden00= K
"00K L
)00L M
;00M N
return22 
base22 
.22 

PostEntity22 "
(22" #
model22# (
)22( )
;22) *
}33 	
public55 
override55 
IActionResult55 %
UpdateEntity55& 2
(552 3
EngineTypeModel553 B
model55C H
,55H I
int55J M
id55N P
)55P Q
{66 	
if77 
(77 
_brandRepository77  
.77  !
GetById77! (
(77( )
(77) *
int77* -
)77- .
model77. 3
.773 4
BrandId774 ;
)77; <
==77= ?
null77@ D
)77D E
return88 
NotFound88 
(88  
$"88  "
Merk met id 88" .
{88. /
model88/ 4
.884 5
BrandId885 <
}88< =
 niet gevonden88= K
"88K L
)88L M
;88M N
return:: 
base:: 
.:: 
UpdateEntity:: $
(::$ %
model::% *
,::* +
id::, .
)::. /
;::/ 0
};; 	
}<< 
}== œW
dD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\FuelCardController.cs
	namespace

 	
eMenka


 
.

 
API

 
.

 
Controllers

  
{ 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
FuelCardController #
:$ %
GenericController& 7
<7 8
FuelCard8 @
,@ A
FuelCardModelB O
,O P
FuelCardReturnModelQ d
>d e
{ 
private 
readonly 
IDriverRepository *
_driverRepository+ <
;< =
private 
readonly 
IFuelCardRepository ,
_fuelCardRepository- @
;@ A
private 
readonly 
IVehicleRepository +
_vehicleRepository, >
;> ?
private 
readonly 
ICompanyRepository +
_companyRepository, >
;> ?
private 
readonly 
FuelCardMapper '
_fuelCardMapper( 7
;7 8
public 
FuelCardController !
(! "
IFuelCardRepository" 5
fuelCardRepository6 H
,H I
IDriverRepositoryJ [
driverRepository\ l
,l m
ICompanyRepository	n Ä
companyRepository
Å í
,
í ì
IVehicleRepository 
vehicleRepository 0
)0 1
:2 3
base4 8
(8 9
fuelCardRepository9 K
,K L
newM P
FuelCardMapperQ _
(_ `
)` a
)a b
{ 	
_fuelCardRepository 
=  !
fuelCardRepository" 4
;4 5
_driverRepository 
= 
driverRepository  0
;0 1
_vehicleRepository 
=  
vehicleRepository! 2
;2 3
_companyRepository 
=  
companyRepository! 2
;2 3
_fuelCardMapper 
= 
new !
FuelCardMapper" 0
(0 1
)1 2
;2 3
} 	
[ 	
HttpGet	 
( 
$str "
)" #
]# $
public   
IActionResult    
GetFuelcardByEndDate   1
(  1 2
int  2 5
range  6 ;
)  ; <
{!! 	
var"" 
	fuelcards"" 
="" 
_fuelCardRepository"" /
.""/ 0
Find""0 4
(""4 5
v""5 6
=>""7 9
v"": ;
.""; <
EndDate""< C
>=""D F
DateTime""G O
.""O P
Now""P S
.""S T
Date""T X
&&""Y [
v""\ ]
.""] ^
EndDate""^ e
<=""f h
DateTime""i q
.""q r
Now""r u
.""u v
Date""v z
.""z {
AddDays	""{ Ç
(
""Ç É
range
""É à
)
""à â
)
""â ä
;
""ä ã
return$$ 
Ok$$ 
($$ 
	fuelcards$$ 
.$$  
Select$$  &
($$& '
_fuelCardMapper$$' 6
.$$6 7"
MapEntityToReturnModel$$7 M
)$$M N
.$$N O
ToList$$O U
($$U V
)$$V W
)$$W X
;$$X Y
}%% 	
public'' 
override'' 
IActionResult'' %

PostEntity''& 0
(''0 1
FuelCardModel''1 >
model''? D
)''D E
{(( 	
if)) 
()) 
!)) 

ModelState)) 
.)) 
IsValid)) #
)))# $
return))% +

BadRequest)), 6
())6 7
)))7 8
;))8 9
var++ 
driver++ 
=++ 
_driverRepository++ *
.++* +
GetById+++ 2
(++2 3
(++3 4
int++4 7
)++7 8
model++8 =
.++= >
DriverId++> F
)++F G
;++G H
if-- 
(-- 
driver-- 
==-- 
null-- 
)-- 
return.. 
NotFound.. 
(..  
$"..  "
Bestuurder met id .." 4
{..4 5
model..5 :
...: ;
DriverId..; C
}..C D
 niet gevonden..D R
"..R S
)..S T
;..T U
if00 
(00 
_fuelCardRepository00 #
.00# $
Find00$ (
(00( )
r00) *
=>00+ -
r00. /
.00/ 0
Driver000 6
.006 7
Id007 9
==00: <
model00= B
.00B C
DriverId00C K
)00K L
.00L M
FirstOrDefault00M [
(00[ \
)00\ ]
!=00^ `
null00a e
)00e f
return11 

BadRequest11 !
(11! "
$"11" $,
 Een tankkaart met bestuurder id 11$ D
{11D E
model11E J
.11J K
DriverId11K S
}11S T
 bestaat al11T _
"11_ `
)11` a
;11a b
var33 
vehicle33 
=33 
_vehicleRepository33 ,
.33, -
GetById33- 4
(334 5
(335 6
int336 9
)339 :
model33: ?
.33? @
	VehicleId33@ I
)33I J
;33J K
if55 
(55 
vehicle55 
==55 
null55 
)55  
return66 
NotFound66 
(66  
$"66  "
Voertuig met id 66" 2
{662 3
model663 8
.668 9
	VehicleId669 B
}66B C
 niet gevonden66C Q
"66Q R
)66R S
;66S T
if88 
(88 
_fuelCardRepository88 #
.88# $
Find88$ (
(88( )
r88) *
=>88+ -
r88. /
.88/ 0
Vehicle880 7
.887 8
Id888 :
==88; =
model88> C
.88C D
	VehicleId88D M
)88M N
.88N O
FirstOrDefault88O ]
(88] ^
)88^ _
!=88` b
null88c g
)88g h
return99 

BadRequest99 !
(99! "
$"99" $*
Een tankkaart met voertuig id 99$ B
{99B C
model99C H
.99H I
	VehicleId99I R
}99R S
 bestaat al99S ^
"99^ _
)99_ `
;99` a
var;; 
company;; 
=;; 
_companyRepository;; ,
.;;, -
GetById;;- 4
(;;4 5
(;;5 6
int;;6 9
);;9 :
model;;: ?
.;;? @
	CompanyId;;@ I
);;I J
;;;J K
if== 
(== 
company== 
==== 
null== 
)==  
return>> 
NotFound>> 
(>>  
$">>  "
Bedrijf met id >>" 1
{>>1 2
model>>2 7
.>>7 8
	CompanyId>>8 A
}>>A B
 niet gevonden>>B P
">>P Q
)>>Q R
;>>R S
var@@ 
entity@@ 
=@@ 
_fuelCardMapper@@ (
.@@( )
MapModelToEntity@@) 9
(@@9 :
model@@: ?
)@@? @
;@@@ A
_fuelCardRepositoryBB 
.BB  
AddBB  #
(BB# $
entityBB$ *
)BB* +
;BB+ ,
vehicleDD 
.DD 

FuelCardIdDD 
=DD  
entityDD! '
.DD' (
IdDD( *
;DD* +
driverEE 
.EE 

FuelCardIdEE 
=EE 
entityEE  &
.EE& '
IdEE' )
;EE) *
_vehicleRepositoryFF 
.FF 
UpdateFF %
(FF% &
vehicleFF& -
.FF- .
IdFF. 0
,FF0 1
vehicleFF2 9
)FF9 :
;FF: ;
returnHH 
OkHH 
(HH 
_fuelCardMapperHH %
.HH% &"
MapEntityToReturnModelHH& <
(HH< =
entityHH= C
)HHC D
)HHD E
;HHE F
}II 	
publicKK 
overrideKK 
IActionResultKK %
UpdateEntityKK& 2
(KK2 3
FuelCardModelKK3 @
modelKKA F
,KKF G
intKKH K
idKKL N
)KKN O
{LL 	
ifMM 
(MM 
_driverRepositoryMM !
.MM! "
GetByIdMM" )
(MM) *
(MM* +
intMM+ .
)MM. /
modelMM/ 4
.MM4 5
DriverIdMM5 =
)MM= >
==MM? A
nullMMB F
)MMF G
returnNN 
NotFoundNN 
(NN  
$"NN  "
Bestuurder met id NN" 4
{NN4 5
modelNN5 :
.NN: ;
DriverIdNN; C
}NNC D
 niet gevondenNND R
"NNR S
)NNS T
;NNT U
ifPP 
(PP 
_fuelCardRepositoryPP #
.PP# $
FindPP$ (
(PP( )
rPP) *
=>PP+ -
rPP. /
.PP/ 0
DriverPP0 6
.PP6 7
IdPP7 9
==PP: <
modelPP= B
.PPB C
DriverIdPPC K
)PPK L
.PPL M
FirstOrDefaultPPM [
(PP[ \
)PP\ ]
!=PP^ `
nullPPa e
)PPe f
returnQQ 

BadRequestQQ !
(QQ! "
$"QQ" $,
 Een tankkaart met bestuurder id QQ$ D
{QQD E
modelQQE J
.QQJ K
DriverIdQQK S
}QQS T
 bestaat alQQT _
"QQ_ `
)QQ` a
;QQa b
ifSS 
(SS 
_vehicleRepositorySS "
.SS" #
GetByIdSS# *
(SS* +
(SS+ ,
intSS, /
)SS/ 0
modelSS0 5
.SS5 6
	VehicleIdSS6 ?
)SS? @
==SSA C
nullSSD H
)SSH I
returnTT 
NotFoundTT 
(TT  
$"TT  "
Voertuig met id TT" 2
{TT2 3
modelTT3 8
.TT8 9
	VehicleIdTT9 B
}TTB C
 niet gevondenTTC Q
"TTQ R
)TTR S
;TTS T
ifVV 
(VV 
_fuelCardRepositoryVV #
.VV# $
FindVV$ (
(VV( )
rVV) *
=>VV+ -
rVV. /
.VV/ 0
VehicleVV0 7
.VV7 8
IdVV8 :
==VV; =
modelVV> C
.VVC D
	VehicleIdVVD M
)VVM N
.VVN O
FirstOrDefaultVVO ]
(VV] ^
)VV^ _
!=VV` b
nullVVc g
)VVg h
returnWW 

BadRequestWW !
(WW! "
$"WW" $*
Een tankkaart met voertuig id WW$ B
{WWB C
modelWWC H
.WWH I
	VehicleIdWWI R
}WWR S
 bestaat alWWS ^
"WW^ _
)WW_ `
;WW` a
returnYY 
baseYY 
.YY 
UpdateEntityYY $
(YY$ %
modelYY% *
,YY* +
idYY, .
)YY. /
;YY/ 0
}ZZ 	
}[[ 
}\\ ›
dD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\FuelTypeController.cs
	namespace 	
eMenka
 
. 
API 
. 
Controllers  
{		 
[

 
Route

 

(


 
$str

 
)

 
]

 
public 

class 
FuelTypeController #
:$ %
GenericController& 7
<7 8
FuelType8 @
,@ A
FuelTypeModelB O
,O P
FuelTypeReturnModelQ d
>d e
{ 
public 
FuelTypeController !
(! "
IFuelTypeRepository" 5
fuelTypeRepository6 H
)H I
:J K
baseL P
(P Q
fuelTypeRepositoryQ c
,c d
new 
FuelTypeMapper 
( 
)  
)  !
{ 	
} 	
} 
} “:
cD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\GenericController.cs
	namespace 	
eMenka
 
. 
API 
. 
Controllers  
{		 
[

 
ApiController

 
]

 
[ 

EnableCors 
( 
$str (
)( )
]) *
public 

abstract 
class 
GenericController +
<+ ,
TEntity, 3
,3 4
TModel5 ;
,; <
TReturnModel= I
>I J
:K L
ControllerBaseM [
where 
TEntity 
: 
class 
where #
TModel$ *
:+ ,

IModelBase- 7
{ 
private 
readonly 
IGenericRepository +
<+ ,
TEntity, 3
>3 4
_genericRepository5 G
;G H
private 
readonly 
IMapper  
<  !
TEntity! (
,( )
TModel* 0
,0 1
TReturnModel2 >
>> ?
_mapper@ G
;G H
	protected 
GenericController #
(# $
)$ %
{ 	
} 	
	protected 
GenericController #
(# $
IGenericRepository$ 6
<6 7
TEntity7 >
>> ?
genericRepository@ Q
,Q R
IMapper 
< 
TEntity 
, 
TModel #
,# $
TReturnModel% 1
>1 2
mapper3 9
)9 :
:; <
this= A
(A B
)B C
{ 	
_genericRepository 
=  
genericRepository! 2
;2 3
_mapper 
= 
mapper 
; 
} 	
[ 	
HttpGet	 
] 
public 
virtual 
IActionResult $
GetAllEntities% 3
(3 4
)4 5
{ 	
var   
entities   
=   
_genericRepository   -
.  - .
GetAll  . 4
(  4 5
)  5 6
;  6 7
return"" 
Ok"" 
("" 
entities"" 
."" 
Select"" %
(""% &
_mapper""& -
.""- ."
MapEntityToReturnModel"". D
)""D E
.""E F
ToList""F L
(""L M
)""M N
)""N O
;""O P
}## 	
[%% 	
HttpGet%%	 
(%% 
$str%% 
)%% 
]%% 
public&& 
virtual&& 
IActionResult&& $
GetEntityById&&% 2
(&&2 3
int&&3 6
id&&7 9
)&&9 :
{'' 	
var(( 
entity(( 
=(( 
_genericRepository(( +
.((+ ,
GetById((, 3
(((3 4
id((4 6
)((6 7
;((7 8
if)) 
()) 
entity)) 
==)) 
null)) 
))) 
return** 
NotFound** 
(**  
$"**  "
Geen **" '
{**' (
typeof**( .
(**. /
TEntity**/ 6
)**6 7
}**7 8
 gevonden met id **8 I
{**I J
id**J L
}**L M
"**M N
)**N O
;**O P
return,, 
Ok,, 
(,, 
_mapper,, 
.,, "
MapEntityToReturnModel,, 4
(,,4 5
entity,,5 ;
),,; <
),,< =
;,,= >
}-- 	
[// 	
HttpPost//	 
]// 
public00 
virtual00 
IActionResult00 $

PostEntity00% /
(00/ 0
[000 1
FromBody001 9
]009 :
TModel00; A
model00B G
)00G H
{11 	
if22 
(22 
!22 

ModelState22 
.22 
IsValid22 #
)22# $
return22% +

BadRequest22, 6
(226 7
)227 8
;228 9
var44 
entity44 
=44 
_mapper44  
.44  !
MapModelToEntity44! 1
(441 2
model442 7
)447 8
;448 9
_genericRepository66 
.66 
Add66 "
(66" #
entity66# )
)66) *
;66* +
return88 
Ok88 
(88 
_mapper88 
.88 "
MapEntityToReturnModel88 4
(884 5
entity885 ;
)88; <
)88< =
;88= >
}99 	
[;; 	
HttpPut;;	 
(;; 
$str;; 
);; 
];; 
public<< 
virtual<< 
IActionResult<< $
UpdateEntity<<% 1
(<<1 2
[<<2 3
FromBody<<3 ;
]<<; <
TModel<<= C
model<<D I
,<<I J
int<<K N
id<<O Q
)<<Q R
{== 	
if>> 
(>> 
!>> 

ModelState>> 
.>> 
IsValid>> #
)>># $
return>>% +

BadRequest>>, 6
(>>6 7
)>>7 8
;>>8 9
if@@ 
(@@ 
id@@ 
!=@@ 
model@@ 
.@@ 
Id@@ 
)@@ 
returnAA 

BadRequestAA !
(AA! "
$strAA" ]
)AA] ^
;AA^ _
varCC 
	isUpdatedCC 
=CC 
_genericRepositoryCC .
.CC. /
UpdateCC/ 5
(CC5 6
idCC6 8
,CC8 9
_mapperCC: A
.CCA B
MapModelToEntityCCB R
(CCR S
modelCCS X
)CCX Y
)CCY Z
;CCZ [
ifEE 
(EE 
!EE 
	isUpdatedEE 
)EE 
returnFF 
NotFoundFF 
(FF  
$"FF  "
Geen FF" '
{FF' (
typeofFF( .
(FF. /
TEntityFF/ 6
)FF6 7
}FF7 8
 gevonden met id FF8 I
{FFI J
idFFJ L
}FFL M
"FFM N
)FFN O
;FFO P
returnHH 
OkHH 
(HH 
)HH 
;HH 
}II 	
[KK 	

HttpDeleteKK	 
(KK 
$strKK 
)KK 
]KK 
publicLL 
virtualLL 
IActionResultLL $
DeleteEntityLL% 1
(LL1 2
intLL2 5
idLL6 8
)LL8 9
{MM 	
varNN 
entityNN 
=NN 
_genericRepositoryNN +
.NN+ ,
GetByIdNN, 3
(NN3 4
idNN4 6
)NN6 7
;NN7 8
ifOO 
(OO 
entityOO 
==OO 
nullOO 
)OO 
returnPP 
NotFoundPP 
(PP  
$"PP  "
Geen PP" '
{PP' (
typeofPP( .
(PP. /
TEntityPP/ 6
)PP6 7
}PP7 8
 gevonden met id PP8 I
{PPI J
idPPJ L
}PPL M
"PPM N
)PPN O
;PPO P
_genericRepositoryRR 
.RR 
RemoveRR %
(RR% &
entityRR& ,
)RR, -
;RR- .
returnSS 
OkSS 
(SS 
)SS 
;SS 
}TT 	
}UU 
}VV Ÿ%
aD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\ModelController.cs
	namespace		 	
eMenka		
 
.		 
API		 
.		 
Controllers		  
{

 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
ModelController  
:! "
GenericController# 4
<4 5
Model5 :
,: ;

ModelModel< F
,F G
ModelReturnModelH X
>X Y
{ 
private 
readonly 
IBrandRepository )
_brandRepository* :
;: ;
private 
readonly 
ModelMapper $
_modelMapper% 1
;1 2
private 
readonly 
IModelRepository )
_modelRepository* :
;: ;
public 
ModelController 
( 
IModelRepository /
modelRepository0 ?
,? @
IBrandRepositoryA Q
brandRepositoryR a
)a b
:c d
basee i
(i j
modelRepository 
, 
new  
ModelMapper! ,
(, -
)- .
). /
{ 	
_modelRepository 
= 
modelRepository .
;. /
_brandRepository 
= 
brandRepository .
;. /
_modelMapper 
= 
new 
ModelMapper *
(* +
)+ ,
;, -
} 	
[ 	
HttpGet	 
( 
$str "
)" #
]# $
public 
IActionResult 
GetByBrandId )
() *
int* -
brandId. 5
)5 6
{ 	
if 
( 
_brandRepository  
.  !
GetById! (
(( )
brandId) 0
)0 1
==2 4
null5 9
)9 :
return 
NotFound 
(  
$"  "
Merk met id " .
{. /
brandId/ 6
}6 7
 niet gevonden7 E
"E F
)F G
;G H
var!! 
models!! 
=!! 
_modelRepository!! )
.!!) *
Find!!* .
(!!. /
model!!/ 4
=>!!5 7
model!!8 =
.!!= >
Brand!!> C
.!!C D
Id!!D F
==!!G I
brandId!!J Q
)!!Q R
;!!R S
return## 
Ok## 
(## 
models## 
.## 
Select## #
(### $
_modelMapper##$ 0
.##0 1"
MapEntityToReturnModel##1 G
)##G H
.##H I
ToList##I O
(##O P
)##P Q
)##Q R
;##R S
}$$ 	
public&& 
override&& 
IActionResult&& %

PostEntity&&& 0
(&&0 1

ModelModel&&1 ;
model&&< A
)&&A B
{'' 	
if(( 
((( 
_brandRepository((  
.((  !
GetById((! (
(((( )
((() *
int((* -
)((- .
model((. 3
.((3 4
BrandId((4 ;
)((; <
==((= ?
null((@ D
)((D E
return)) 
NotFound)) 
())  
$"))  "
Merk met id ))" .
{)). /
model))/ 4
.))4 5
BrandId))5 <
}))< =
 niet gevonden))= K
"))K L
)))L M
;))M N
return++ 
base++ 
.++ 

PostEntity++ "
(++" #
model++# (
)++( )
;++) *
},, 	
public.. 
override.. 
IActionResult.. %
UpdateEntity..& 2
(..2 3

ModelModel..3 =
model..> C
,..C D
int..E H
id..I K
)..K L
{// 	
if00 
(00 
_brandRepository00  
.00  !
GetById00! (
(00( )
(00) *
int00* -
)00- .
model00. 3
.003 4
BrandId004 ;
)00; <
==00= ?
null00@ D
)00D E
return11 
NotFound11 
(11  
$"11  "
Merk met id 11" .
{11. /
model11/ 4
.114 5
BrandId115 <
}11< =
 niet gevonden11= K
"11K L
)11L M
;11M N
return33 
base33 
.33 
UpdateEntity33 $
(33$ %
model33% *
,33* +
id33, .
)33. /
;33/ 0
}44 	
}55 
}66 °
bD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\PersonController.cs
	namespace		 	
eMenka		
 
.		 
API		 
.		 
Controllers		  
{

 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
PersonController !
:" #
GenericController$ 5
<5 6
Person6 <
,< =
PersonModel> I
,I J
PersonReturnModelK \
>\ ]
{ 
private 
readonly 
IPersonRepository *
_personRepository+ <
;< =
public 
PersonController 
(  
IPersonRepository  1
personRepository2 B
)B C
:D E
baseF J
(J K
personRepositoryK [
,[ \
new] `
PersonMappera m
(m n
)n o
)o p
{ 	
_personRepository 
= 
personRepository  0
;0 1
} 	
public 
override 
IActionResult %

PostEntity& 0
(0 1
PersonModel1 <
model= B
)B C
{ 	
Person 
person 
= 
_personRepository .
.. /
Find/ 3
(3 4
p4 5
=>6 8
p9 :
.: ; 
DriversLicenseNumber; O
==P R
modelS X
.X Y 
DriversLicenseNumberY m
)m n
.n o
FirstOrDefaulto }
(} ~
)~ 
;	 Ä
if 
( 
person 
!= 
null 
) 
{ 
return 

BadRequest !
(! "
$"" $-
!Een persoon met rijbewijs nummer $ E
{E F
modelF K
.K L 
DriversLicenseNumberL `
}` a
 bestaat ala l
"l m
)m n
;n o
} 
return 
base 
. 

PostEntity "
(" #
model# (
)( )
;) *
} 	
public!! 
override!! 
IActionResult!! %
UpdateEntity!!& 2
(!!2 3
PersonModel!!3 >
model!!? D
,!!D E
int!!F I
id!!J L
)!!L M
{"" 	
Person## 
person## 
=## 
_personRepository## -
.##- .
Find##. 2
(##2 3
p##3 4
=>##5 7
p##8 9
.##9 : 
DriversLicenseNumber##: N
==##O Q
model##R W
.##W X 
DriversLicenseNumber##X l
)##l m
.##m n
FirstOrDefault##n |
(##| }
)##} ~
;##~ 
if%% 
(%% 
person%% 
!=%% 
null%% 
&&%% !
person%%" (
.%%( )
Id%%) +
!=%%, .
model%%/ 4
.%%4 5
Id%%5 7
)%%7 8
{&& 
return'' 

BadRequest'' !
(''! "
$"''" $-
!Een persoon met rijbewijs nummer ''$ E
{''E F
model''F K
.''K L 
DriversLicenseNumber''L `
}''` a
 bestaat al''a l
"''l m
)''m n
;''n o
}(( 
return)) 
base)) 
.)) 
UpdateEntity)) $
())$ %
model))% *
,))* +
id)), .
))). /
;))/ 0
}** 	
}++ 
},, ˆH
bD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\RecordController.cs
	namespace

 	
eMenka


 
.

 
API

 
.

 
Controllers

  
{ 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
RecordController !
:" #
GenericController$ 5
<5 6
Record6 <
,< =
RecordModel> I
,I J
RecordReturnModelK \
>\ ]
{ 
private 
readonly "
ICorporationRepository /"
_corporationRepository0 F
;F G
private 
readonly %
ICostAllocationRepository 2%
_costAllocationRepository3 L
;L M
private 
readonly 
IFuelCardRepository ,
_fuelCardRepository- @
;@ A
private 
readonly 
IRecordRepository *
_recordRepository+ <
;< =
private 
readonly 
RecordMapper %
_recordMapper& 3
;3 4
public 
RecordController 
(  
IRecordRepository  1
recordRepository2 B
,B C
IFuelCardRepositoryD W
fuelCardRepositoryX j
,j k"
ICorporationRepository "!
corporationRepository# 8
,8 9%
ICostAllocationRepository: S$
costAllocationRepositoryT l
)l m
:n o
basep t
(t u
recordRepository 
, 
new !
RecordMapper" .
(. /
)/ 0
)0 1
{ 	
_recordRepository 
= 
recordRepository  0
;0 1
_fuelCardRepository 
=  !
fuelCardRepository" 4
;4 5"
_corporationRepository "
=# $!
corporationRepository% :
;: ;%
_costAllocationRepository %
=& '$
costAllocationRepository( @
;@ A
_recordMapper 
= 
new 
RecordMapper  ,
(, -
)- .
;. /
} 	
[   	
HttpGet  	 
(   
$str   "
)  " #
]  # $
public!! 
IActionResult!! 
GetRecordByEndDate!! /
(!!/ 0
int!!0 3
range!!4 9
)!!9 :
{"" 	
var## 
records## 
=## 
_recordRepository## +
.##+ ,
Find##, 0
(##0 1
v##1 2
=>##3 5
v##6 7
.##7 8
EndDate##8 ?
>=##@ B
DateTime##C K
.##K L
Now##L O
.##O P
Date##P T
&&##U W
v##X Y
.##Y Z
EndDate##Z a
<=##b d
DateTime##e m
.##m n
Now##n q
.##q r
Date##r v
.##v w
AddDays##w ~
(##~ 
range	## Ñ
)
##Ñ Ö
)
##Ö Ü
;
##Ü á
return%% 
Ok%% 
(%% 
records%% 
.%% 
Select%% $
(%%$ %
_recordMapper%%% 2
.%%2 3"
MapEntityToReturnModel%%3 I
)%%I J
.%%J K
ToList%%K Q
(%%Q R
)%%R S
)%%S T
;%%T U
}&& 	
public(( 
override(( 
IActionResult(( %

PostEntity((& 0
(((0 1
RecordModel((1 <
model((= B
)((B C
{)) 	
if** 
(** 
_fuelCardRepository** #
.**# $
GetById**$ +
(**+ ,
(**, -
int**- 0
)**0 1
model**1 6
.**6 7

FuelCardId**7 A
)**A B
==**C E
null**F J
)**J K
return++ 
NotFound++ 
(++  
$"++  "
Tankkaart met id ++" 3
{++3 4
model++4 9
.++9 :

FuelCardId++: D
}++D E
 niet gevonden++E S
"++S T
)++T U
;++U V
if-- 
(-- "
_corporationRepository-- &
.--& '
GetById--' .
(--. /
(--/ 0
int--0 3
)--3 4
model--4 9
.--9 :
CorporationId--: G
)--G H
==--I K
null--L P
)--P Q
return.. 
NotFound.. 
(..  
$"..  " 
Vennootschap met id .." 6
{..6 7
model..7 <
...< =
CorporationId..= J
}..J K
 niet gevonden..K Y
"..Y Z
)..Z [
;..[ \
if00 
(00 %
_costAllocationRepository00 )
.00) *
GetById00* 1
(001 2
(002 3
int003 6
)006 7
model007 <
.00< =
CostAllocationId00= M
)00M N
==00O Q
null00R V
)00V W
return11 
NotFound11 
(11  
$"11  "$
Kosten allocatie met id 11" :
{11: ;
model11; @
.11@ A
CostAllocationId11A Q
}11Q R
 niet gevonden11R `
"11` a
)11a b
;11b c
if33 
(33 
_recordRepository33 !
.33! "
Find33" &
(33& '
r33' (
=>33) +
r33, -
.33- .
FuelCard33. 6
.336 7
Id337 9
==33: <
model33= B
.33B C

FuelCardId33C M
)33M N
.33N O
FirstOrDefault33O ]
(33] ^
)33^ _
!=33` b
null33c g
)33g h
return44 

BadRequest44 !
(44! "
$"44" $)
Een dossier met tankkaart id 44$ A
{44A B
model44B G
.44G H

FuelCardId44H R
}44R S
 bestaat al44S ^
"44^ _
)44_ `
;44` a
return66 
base66 
.66 

PostEntity66 "
(66" #
model66# (
)66( )
;66) *
}77 	
public99 
override99 
IActionResult99 %
UpdateEntity99& 2
(992 3
RecordModel993 >
model99? D
,99D E
int99F I
id99J L
)99L M
{:: 	
if;; 
(;; 
_fuelCardRepository;; #
.;;# $
GetById;;$ +
(;;+ ,
(;;, -
int;;- 0
);;0 1
model;;1 6
.;;6 7

FuelCardId;;7 A
);;A B
==;;C E
null;;F J
);;J K
return<< 
NotFound<< 
(<<  
$"<<  "
Tankkaart met id <<" 3
{<<3 4
model<<4 9
.<<9 :

FuelCardId<<: D
}<<D E
 niet gevonden<<E S
"<<S T
)<<T U
;<<U V
if>> 
(>> "
_corporationRepository>> &
.>>& '
GetById>>' .
(>>. /
(>>/ 0
int>>0 3
)>>3 4
model>>4 9
.>>9 :
CorporationId>>: G
)>>G H
==>>I K
null>>L P
)>>P Q
return?? 
NotFound?? 
(??  
$"??  " 
Vennootschap met id ??" 6
{??6 7
model??7 <
.??< =
CorporationId??= J
}??J K
 niet gevonden??K Y
"??Y Z
)??Z [
;??[ \
ifAA 
(AA %
_costAllocationRepositoryAA )
.AA) *
GetByIdAA* 1
(AA1 2
(AA2 3
intAA3 6
)AA6 7
modelAA7 <
.AA< =
CostAllocationIdAA= M
)AAM N
==AAO Q
nullAAR V
)AAV W
returnBB 
NotFoundBB 
(BB  
$"BB  "$
Kosten allocatie met id BB" :
{BB: ;
modelBB; @
.BB@ A
CostAllocationIdBBA Q
}BBQ R
 niet gevondenBBR `
"BB` a
)BBa b
;BBb c
varDD 
recordDD 
=DD 
_recordRepositoryDD *
.DD* +
FindDD+ /
(DD/ 0
rDD0 1
=>DD2 4
rDD5 6
.DD6 7
FuelCardDD7 ?
.DD? @
IdDD@ B
==DDC E
modelDDF K
.DDK L

FuelCardIdDDL V
)DDV W
.DDW X
FirstOrDefaultDDX f
(DDf g
)DDg h
;DDh i
ifFF 
(FF 
recordFF 
!=FF 
nullFF 
&&FF !
recordFF" (
.FF( )
IdFF) +
!=FF, .
modelFF/ 4
.FF4 5
IdFF5 7
)FF7 8
returnGG 

BadRequestGG !
(GG! "
$"GG" $)
Een dossier met tankkaart id GG$ A
{GGA B
modelGGB G
.GGG H

FuelCardIdGGH R
}GGR S
 bestaat alGGS ^
"GG^ _
)GG_ `
;GG` a
returnII 
baseII 
.II 
UpdateEntityII $
(II$ %
modelII% *
,II* +
idII, .
)II. /
;II/ 0
}JJ 	
}KK 
}LL »,
aD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\SerieController.cs
	namespace		 	
eMenka		
 
.		 
API		 
.		 
Controllers		  
{

 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
SerieController  
:! "
GenericController# 4
<4 5
Series5 ;
,; <

SerieModel= G
,G H
SerieReturnModelI Y
>Y Z
{ 
private 
readonly 
IBrandRepository )
_brandRepository* :
;: ;
private 
readonly 
ISerieRepository )
_serieRepository* :
;: ;
private 
readonly 
SerieMapper $
_serieMapper% 1
;1 2
public 
SerieController 
( 
ISerieRepository /
serieRepository0 ?
,? @
IBrandRepositoryA Q
brandRepositoryR a
)a b
:c d
basee i
(i j
serieRepository 
, 
new  
SerieMapper! ,
(, -
)- .
). /
{ 	
_serieRepository 
= 
serieRepository .
;. /
_brandRepository 
= 
brandRepository .
;. /
_serieMapper 
= 
new 
SerieMapper *
(* +
)+ ,
;, -
} 	
[ 	
HttpGet	 
( 
$str "
)" #
]# $
public 
IActionResult 
GetSeriesByBrandId /
(/ 0
int0 3
brandId4 ;
); <
{ 	
if 
( 
_brandRepository  
.  !
GetById! (
(( )
brandId) 0
)0 1
==2 4
null5 9
)9 :
return 
NotFound 
(  
$"  "
Merk met id " .
{. /
brandId/ 6
}6 7
 niet gevonden7 E
"E F
)F G
;G H
var   
series   
=   
_serieRepository   )
.  ) *
Find  * .
(  . /
serie  / 4
=>  5 7
serie  8 =
.  = >
Brand  > C
.  C D
Id  D F
==  G I
brandId  J Q
)  Q R
;  R S
return"" 
Ok"" 
("" 
series"" 
."" 
Select"" #
(""# $
_serieMapper""$ 0
.""0 1"
MapEntityToReturnModel""1 G
)""G H
.""H I
ToList""I O
(""O P
)""P Q
)""Q R
;""R S
}## 	
[%% 	
HttpGet%%	 
(%% 
$str%% #
)%%# $
]%%$ %
public&& 
IActionResult&& 
GetSeriesByName&& ,
(&&, -
string&&- 3
	serieName&&4 =
)&&= >
{'' 	
var(( 
series(( 
=(( 
_serieRepository(( )
.(() *
Find((* .
(((. /
serie((/ 4
=>((5 7
serie((8 =
.((= >
Name((> B
==((C E
	serieName((F O
)((O P
;((P Q
return** 
Ok** 
(** 
series** 
.** 
Select** #
(**# $
_serieMapper**$ 0
.**0 1"
MapEntityToReturnModel**1 G
)**G H
.**H I
ToList**I O
(**O P
)**P Q
)**Q R
;**R S
}++ 	
public-- 
override-- 
IActionResult-- %

PostEntity--& 0
(--0 1

SerieModel--1 ;
model--< A
)--A B
{.. 	
if// 
(// 
_brandRepository//  
.//  !
GetById//! (
(//( )
(//) *
int//* -
)//- .
model//. 3
.//3 4
BrandId//4 ;
)//; <
==//= ?
null//@ D
)//D E
return00 
NotFound00 
(00  
$"00  "
Merk met id 00" .
{00. /
model00/ 4
.004 5
BrandId005 <
}00< =
 niet gevonden00= K
"00K L
)00L M
;00M N
return22 
base22 
.22 

PostEntity22 "
(22" #
model22# (
)22( )
;22) *
}33 	
public55 
override55 
IActionResult55 %
UpdateEntity55& 2
(552 3

SerieModel553 =
model55> C
,55C D
int55E H
id55I K
)55K L
{66 	
if77 
(77 
_brandRepository77  
.77  !
GetById77! (
(77( )
(77) *
int77* -
)77- .
model77. 3
.773 4
BrandId774 ;
)77; <
==77= ?
null77@ D
)77D E
return88 
NotFound88 
(88  
$"88  "
Merk met id 88" .
{88. /
model88/ 4
.884 5
BrandId885 <
}88< =
 niet gevonden88= K
"88K L
)88L M
;88M N
return:: 
base:: 
.:: 
UpdateEntity:: $
(::$ %
model::% *
,::* +
id::, .
)::. /
;::/ 0
};; 	
}<< 
}== ›
dD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\SupplierController.cs
	namespace 	
eMenka
 
. 
API 
. 
Controllers  
{		 
[

 
Route

 

(


 
$str

 
)

 
]

 
public 

class 
SupplierController #
:$ %
GenericController& 7
<7 8
Supplier8 @
,@ A
SupplierModelB O
,O P
SupplierReturnModelQ d
>d e
{ 
public 
SupplierController !
(! "
ISupplierRepository" 5
supplierRepository6 H
)H I
:J K
baseL P
(P Q
supplierRepositoryQ c
,c d
new 
SupplierMapper 
( 
)  
)  !
{ 	
} 	
} 
} Ä¿
cD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Controllers\VehicleController.cs
	namespace 	
eMenka
 
. 
API 
. 
Controllers  
{ 
[ 
Route 

(
 
$str 
) 
] 
public 

class 
VehicleController "
:# $
GenericController% 6
<6 7
Vehicle7 >
,> ?
VehicleModel@ L
,L M
VehicleReturnModelN `
>` a
{ 
private 
readonly 
IBrandRepository )
_brandRepository* :
;: ;
private 
readonly 
ICategoryRepository ,
_categoryRepository- @
;@ A
private 
readonly 
IDoorTypeRepository ,
_doorTypeRepository- @
;@ A
private 
readonly !
IEngineTypeRepository .!
_engineTypeRepository/ D
;D E
private 
readonly 
IFuelCardRepository ,
_fuelCardRepository- @
;@ A
private 
readonly 
IRecordRepository *
_recordRepository+ <
;< =
private 
readonly 
IFuelTypeRepository ,
_fuelTypeRepository- @
;@ A
private 
readonly 
IModelRepository )
_modelRepository* :
;: ;
private 
readonly 
ISerieRepository )
_serieRepository* :
;: ;
private 
readonly 
IVehicleRepository +
_vehicleRepository, >
;> ?
private 
readonly 
VehicleMapper &
_vehicleMapper' 5
;5 6
public 
VehicleController  
(  !
IVehicleRepository! 3
vehicleRepository4 E
,E F
IBrandRepositoryG W
brandRepositoryX g
,g h
IModelRepository 
modelRepository ,
,, -
IFuelTypeRepository. A
fuelTypeRepositoryB T
,T U!
IEngineTypeRepository ! 
engineTypeRepository" 6
,6 7
IDoorTypeRepository8 K
doorTypeRepositoryL ^
,^ _
ICategoryRepository 
categoryRepository  2
,2 3
ISerieRepository4 D
serieRepositoryE T
,T U
IFuelCardRepository   
fuelCardRepository    2
,  2 3
IRecordRepository  4 E
recordRepository  F V
)  V W
:  X Y
base  Z ^
(  ^ _
vehicleRepository  _ p
,  p q
new  r u
VehicleMapper	  v É
(
  É Ñ
)
  Ñ Ö
)
  Ö Ü
{!! 	
_vehicleRepository"" 
=""  
vehicleRepository""! 2
;""2 3
_brandRepository## 
=## 
brandRepository## .
;##. /
_modelRepository$$ 
=$$ 
modelRepository$$ .
;$$. /
_fuelTypeRepository%% 
=%%  !
fuelTypeRepository%%" 4
;%%4 5!
_engineTypeRepository&& !
=&&" # 
engineTypeRepository&&$ 8
;&&8 9
_doorTypeRepository'' 
=''  !
doorTypeRepository''" 4
;''4 5
_categoryRepository(( 
=((  !
categoryRepository((" 4
;((4 5
_fuelCardRepository)) 
=))  !
fuelCardRepository))" 4
;))4 5
_recordRepository** 
=** 
recordRepository**  0
;**0 1
_serieRepository++ 
=++ 
serieRepository++ .
;++. /
_vehicleMapper,, 
=,, 
new,,  
VehicleMapper,,! .
(,,. /
),,/ 0
;,,0 1
}-- 	
[// 	
HttpGet//	 
(// 
$str// "
)//" #
]//# $
public00 
IActionResult00 
GetVehicleByBrandId00 0
(000 1
int001 4
brandId005 <
)00< =
{11 	
if22 
(22 
_brandRepository22  
.22  !
GetById22! (
(22( )
brandId22) 0
)220 1
==222 4
null225 9
)229 :
return33 
NotFound33 
(33  
$"33  "
Merk met id 33" .
{33. /
brandId33/ 6
}336 7
 niet gevonden337 E
"33E F
)33F G
;33G H
var55 
vehicles55 
=55 
_vehicleRepository55 -
.55- .
Find55. 2
(552 3
vehicle553 :
=>55; =
vehicle55> E
.55E F
BrandId55F M
==55N P
brandId55Q X
)55X Y
;55Y Z
return77 
Ok77 
(77 
vehicles77 
.77 
Select77 %
(77% &
_vehicleMapper77& 4
.774 5"
MapEntityToReturnModel775 K
)77K L
.77L M
ToList77M S
(77S T
)77T U
)77U V
;77V W
}88 	
[:: 	
HttpGet::	 
(:: 
$str:: ,
)::, -
]::- .
public;; 
IActionResult;; (
GetAvailableVehicleByBrandId;; 9
(;;9 :
int;;: =
brandId;;> E
);;E F
{<< 	
if== 
(== 
_brandRepository==  
.==  !
GetById==! (
(==( )
brandId==) 0
)==0 1
====2 4
null==5 9
)==9 :
return>> 
NotFound>> 
(>>  
$">>  "
Merk met id >>" .
{>>. /
brandId>>/ 6
}>>6 7
 niet gevonden>>7 E
">>E F
)>>F G
;>>G H
var@@ 
records@@ 
=@@ 
_recordRepository@@ +
.@@+ ,
GetAll@@, 2
(@@2 3
)@@3 4
;@@4 5
varBB 
vehiclesBB 
=BB 
_vehicleRepositoryBB -
.BB- .,
 GetAllAvailableVehiclesByBrandIdBB. N
(BBN O
brandIdBBO V
,BBV W
recordsBBX _
.BB_ `
SelectBB` f
(BBf g
rBBg h
=>BBi k
rBBl m
.BBm n

FuelCardIdBBn x
)BBx y
.BBy z
ToList	BBz Ä
(
BBÄ Å
)
BBÅ Ç
)
BBÇ É
;
BBÉ Ñ
returnDD 
OkDD 
(DD 
vehiclesDD 
.DD 
SelectDD %
(DD% &
_vehicleMapperDD& 4
.DD4 5"
MapEntityToReturnModelDD5 K
)DDK L
.DDL M
ToListDDM S
(DDS T
)DDT U
)DDU V
;DDV W
}EE 	
[GG 	
HttpGetGG	 
(GG 
$strGG 
)GG 
]GG 
publicHH 
IActionResultHH #
GetAllAvailableVehiclesHH 4
(HH4 5
)HH5 6
{II 	
varJJ 
vehiclesJJ 
=JJ 
_vehicleRepositoryJJ -
.JJ- .#
GetAllAvailableVehiclesJJ. E
(JJE F
)JJF G
;JJG H
returnKK 
OkKK 
(KK 
vehiclesKK 
.KK 
SelectKK %
(KK% &
_vehicleMapperKK& 4
.KK4 5"
MapEntityToReturnModelKK5 K
)KKK L
.KKL M
ToListKKM S
(KKS T
)KKT U
)KKU V
;KKV W
}LL 	
[NN 	
HttpGetNN	 
(NN 
$strNN )
)NN) *
]NN* +
publicOO 
IActionResultOO "
GetVehiclesByBrandNameOO 3
(OO3 4
stringOO4 :
	brandNameOO; D
)OOD E
{PP 	
varQQ 
vehiclesQQ 
=QQ 
_vehicleRepositoryQQ -
.QQ- .
FindQQ. 2
(QQ2 3
vehicleQQ3 :
=>QQ; =
vehicleQQ> E
.QQE F
BrandQQF K
.QQK L
NameQQL P
==QQQ S
	brandNameQQT ]
)QQ] ^
;QQ^ _
returnSS 
OkSS 
(SS 
vehiclesSS 
.SS 
SelectSS %
(SS% &
_vehicleMapperSS& 4
.SS4 5"
MapEntityToReturnModelSS5 K
)SSK L
.SSL M
ToListSSM S
(SSS T
)SST U
)SSU V
;SSV W
}TT 	
[VV 	
HttpGetVV	 
(VV 
$strVV "
)VV" #
]VV# $
publicWW 
IActionResultWW 
GetVehicleByModelIdWW 0
(WW0 1
intWW1 4
modelIdWW5 <
)WW< =
{XX 	
ifYY 
(YY 
_modelRepositoryYY  
.YY  !
GetByIdYY! (
(YY( )
modelIdYY) 0
)YY0 1
==YY2 4
nullYY5 9
)YY9 :
returnZZ 
NotFoundZZ 
(ZZ  
$"ZZ  "
Model met id ZZ" /
{ZZ/ 0
modelIdZZ0 7
}ZZ7 8
 niet gevondenZZ8 F
"ZZF G
)ZZG H
;ZZH I
var\\ 
vehicles\\ 
=\\ 
_vehicleRepository\\ -
.\\- .
Find\\. 2
(\\2 3
vehicle\\3 :
=>\\; =
vehicle\\> E
.\\E F
ModelId\\F M
==\\N P
modelId\\Q X
)\\X Y
;\\Y Z
return^^ 
Ok^^ 
(^^ 
vehicles^^ 
.^^ 
Select^^ %
(^^% &
_vehicleMapper^^& 4
.^^4 5"
MapEntityToReturnModel^^5 K
)^^K L
.^^L M
ToList^^M S
(^^S T
)^^T U
)^^U V
;^^V W
}__ 	
[aa 	
HttpGetaa	 
(aa 
$straa &
)aa& '
]aa' (
publicbb 
IActionResultbb 
GetVehicleByStatusbb /
(bb/ 0
boolbb0 4
isActivebb5 =
)bb= >
{cc 	
vardd 
vehiclesdd 
=dd 
_vehicleRepositorydd -
.dd- .
Finddd. 2
(dd2 3
vehicledd3 :
=>dd; =
vehicledd> E
.ddE F
IsActiveddF N
==ddO Q
isActiveddR Z
)ddZ [
;dd[ \
returnff 
Okff 
(ff 
vehiclesff 
.ff 
Selectff %
(ff% &
_vehicleMapperff& 4
.ff4 5"
MapEntityToReturnModelff5 K
)ffK L
.ffL M
ToListffM S
(ffS T
)ffT U
)ffU V
;ffV W
}gg 	
[ii 	
HttpGetii	 
(ii 
$strii "
)ii" #
]ii# $
publicjj 
IActionResultjj  
GetVehiclesByEndDatejj 1
(jj1 2
intjj2 5
rangejj6 ;
)jj; <
{kk 	
varll 
vehiclesll 
=ll 
_vehicleRepositoryll -
.ll- .
Findll. 2
(ll2 3
vll3 4
=>ll5 7
vll8 9
.ll9 :
EndDateDeliveryll: I
>=llJ L
DateTimellM U
.llU V
NowllV Y
.llY Z
DatellZ ^
&&ll_ a
vllb c
.llc d
EndDateDeliverylld s
<=llt v
DateTimellw 
.	ll Ä
Now
llÄ É
.
llÉ Ñ
Date
llÑ à
.
llà â
AddDays
llâ ê
(
llê ë
range
llë ñ
)
llñ ó
)
lló ò
;
llò ô
returnnn 
Oknn 
(nn 
vehiclesnn 
.nn 
Selectnn %
(nn% &
_vehicleMappernn& 4
.nn4 5"
MapEntityToReturnModelnn5 K
)nnK L
.nnL M
ToListnnM S
(nnS T
)nnT U
)nnU V
;nnV W
}oo 	
publicqq 
overrideqq 
IActionResultqq %

PostEntityqq& 0
(qq0 1
VehicleModelqq1 =
modelqq> C
)qqC D
{rr 	
ifss 
(ss 
_brandRepositoryss  
.ss  !
GetByIdss! (
(ss( )
(ss) *
intss* -
)ss- .
modelss. 3
.ss3 4
BrandIdss4 ;
)ss; <
==ss= ?
nullss@ D
)ssD E
returntt 
NotFoundtt 
(tt  
$"tt  "
Merk met id tt" .
{tt. /
modeltt/ 4
.tt4 5
BrandIdtt5 <
}tt< =
 niet gevondentt= K
"ttK L
)ttL M
;ttM N
ifvv 
(vv 
_modelRepositoryvv  
.vv  !
GetByIdvv! (
(vv( )
(vv) *
intvv* -
)vv- .
modelvv. 3
.vv3 4
ModelIdvv4 ;
)vv; <
==vv= ?
nullvv@ D
)vvD E
returnww 
NotFoundww 
(ww  
$"ww  "
Model met id ww" /
{ww/ 0
modelww0 5
.ww5 6
ModelIdww6 =
}ww= >
 niet gevondenww> L
"wwL M
)wwM N
;wwN O
ifyy 
(yy 
_fuelTypeRepositoryyy #
.yy# $
GetByIdyy$ +
(yy+ ,
(yy, -
intyy- 0
)yy0 1
modelyy1 6
.yy6 7

FuelTypeIdyy7 A
)yyA B
==yyC E
nullyyF J
)yyJ K
returnzz 
NotFoundzz 
(zz  
$"zz  "!
Brandstoftype met id zz" 7
{zz7 8
modelzz8 =
.zz= >

FuelTypeIdzz> H
}zzH I
 niet gevondenzzI W
"zzW X
)zzX Y
;zzY Z
if|| 
(|| !
_engineTypeRepository|| %
.||% &
GetById||& -
(||- .
(||. /
int||/ 2
)||2 3
model||3 8
.||8 9
EngineTypeId||9 E
)||E F
==||G I
null||J N
)||N O
return}} 
NotFound}} 
(}}  
$"}}  "
Motortype met id }}" 3
{}}3 4
model}}4 9
.}}9 :
EngineTypeId}}: F
}}}F G
 niet gevonden}}G U
"}}U V
)}}V W
;}}W X
if 
( 
_doorTypeRepository #
.# $
GetById$ +
(+ ,
(, -
int- 0
)0 1
model1 6
.6 7

DoorTypeId7 A
)A B
==C E
nullF J
)J K
return
ÄÄ 
NotFound
ÄÄ 
(
ÄÄ  
$"
ÄÄ  "
Deurtype met id 
ÄÄ" 2
{
ÄÄ2 3
model
ÄÄ3 8
.
ÄÄ8 9

DoorTypeId
ÄÄ9 C
}
ÄÄC D
 niet gevonden
ÄÄD R
"
ÄÄR S
)
ÄÄS T
;
ÄÄT U
if
ÇÇ 
(
ÇÇ !
_categoryRepository
ÇÇ #
.
ÇÇ# $
GetById
ÇÇ$ +
(
ÇÇ+ ,
(
ÇÇ, -
int
ÇÇ- 0
)
ÇÇ0 1
model
ÇÇ1 6
.
ÇÇ6 7

CategoryId
ÇÇ7 A
)
ÇÇA B
==
ÇÇC E
null
ÇÇF J
)
ÇÇJ K
return
ÉÉ 
NotFound
ÉÉ 
(
ÉÉ  
$"
ÉÉ  "
Categorie met id 
ÉÉ" 3
{
ÉÉ3 4
model
ÉÉ4 9
.
ÉÉ9 :

CategoryId
ÉÉ: D
}
ÉÉD E
 niet gevonden
ÉÉE S
"
ÉÉS T
)
ÉÉT U
;
ÉÉU V
if
ÖÖ 
(
ÖÖ 
model
ÖÖ 
.
ÖÖ 

FuelCardId
ÖÖ  
!=
ÖÖ! #
null
ÖÖ$ (
)
ÖÖ( )
{
ÜÜ 
if
áá 
(
áá !
_fuelCardRepository
áá '
.
áá' (
GetById
áá( /
(
áá/ 0
(
áá0 1
int
áá1 4
)
áá4 5
model
áá5 :
.
áá: ;

FuelCardId
áá; E
)
ááE F
==
ááG I
null
ááJ N
)
ááN O
return
àà 
NotFound
àà #
(
àà# $
$"
àà$ &
Tankkaart met id 
àà& 7
{
àà7 8
model
àà8 =
.
àà= >

FuelCardId
àà> H
}
ààH I
 niet gevonden
ààI W
"
ààW X
)
ààX Y
;
ààY Z
if
ãã 
(
ãã  
_vehicleRepository
ãã &
.
ãã& '
Find
ãã' +
(
ãã+ ,
v
ãã, -
=>
ãã. 0
v
ãã1 2
.
ãã2 3
FuelCard
ãã3 ;
.
ãã; <
Id
ãã< >
==
ãã? A
model
ããB G
.
ããG H

FuelCardId
ããH R
)
ããR S
.
ããS T
FirstOrDefault
ããT b
(
ããb c
)
ããc d
!=
ããe g
null
ããh l
)
ããl m
return
åå 

BadRequest
åå %
(
åå% &
$"
åå& (,
Een voertuig met tankkaart id 
åå( F
{
ååF G
model
ååG L
.
ååL M

FuelCardId
ååM W
}
ååW X
 bestaat al
ååX c
"
ååc d
)
ååd e
;
ååe f
}
çç 
if
èè 
(
èè 
_serieRepository
èè  
.
èè  !
GetById
èè! (
(
èè( )
(
èè) *
int
èè* -
)
èè- .
model
èè. 3
.
èè3 4
SeriesId
èè4 <
)
èè< =
==
èè> @
null
èèA E
)
èèE F
return
êê 
NotFound
êê 
(
êê  
$"
êê  "
Serie met id 
êê" /
{
êê/ 0
model
êê0 5
.
êê5 6
SeriesId
êê6 >
}
êê> ?
 niet gevonden
êê? M
"
êêM N
)
êêN O
;
êêO P
return
íí 
base
íí 
.
íí 

PostEntity
íí "
(
íí" #
model
íí# (
)
íí( )
;
íí) *
}
ìì 	
public
ïï 
override
ïï 
IActionResult
ïï %
UpdateEntity
ïï& 2
(
ïï2 3
VehicleModel
ïï3 ?
model
ïï@ E
,
ïïE F
int
ïïG J
id
ïïK M
)
ïïM N
{
ññ 	
if
óó 
(
óó 
_brandRepository
óó  
.
óó  !
GetById
óó! (
(
óó( )
(
óó) *
int
óó* -
)
óó- .
model
óó. 3
.
óó3 4
BrandId
óó4 ;
)
óó; <
==
óó= ?
null
óó@ D
)
óóD E
return
òò 
NotFound
òò 
(
òò  
$"
òò  "
Merk met id 
òò" .
{
òò. /
model
òò/ 4
.
òò4 5
BrandId
òò5 <
}
òò< =
 niet gevonden
òò= K
"
òòK L
)
òòL M
;
òòM N
if
öö 
(
öö 
_modelRepository
öö  
.
öö  !
GetById
öö! (
(
öö( )
(
öö) *
int
öö* -
)
öö- .
model
öö. 3
.
öö3 4
ModelId
öö4 ;
)
öö; <
==
öö= ?
null
öö@ D
)
ööD E
return
õõ 
NotFound
õõ 
(
õõ  
$"
õõ  "
Model met id 
õõ" /
{
õõ/ 0
model
õõ0 5
.
õõ5 6
ModelId
õõ6 =
}
õõ= >
 niet gevonden
õõ> L
"
õõL M
)
õõM N
;
õõN O
if
ùù 
(
ùù !
_fuelTypeRepository
ùù #
.
ùù# $
GetById
ùù$ +
(
ùù+ ,
(
ùù, -
int
ùù- 0
)
ùù0 1
model
ùù1 6
.
ùù6 7

FuelTypeId
ùù7 A
)
ùùA B
==
ùùC E
null
ùùF J
)
ùùJ K
return
ûû 
NotFound
ûû 
(
ûû  
$"
ûû  "#
Brandstoftype met id 
ûû" 7
{
ûû7 8
model
ûû8 =
.
ûû= >

FuelTypeId
ûû> H
}
ûûH I
 niet gevonden
ûûI W
"
ûûW X
)
ûûX Y
;
ûûY Z
if
†† 
(
†† #
_engineTypeRepository
†† %
.
††% &
GetById
††& -
(
††- .
(
††. /
int
††/ 2
)
††2 3
model
††3 8
.
††8 9
EngineTypeId
††9 E
)
††E F
==
††G I
null
††J N
)
††N O
return
°° 
NotFound
°° 
(
°°  
$"
°°  "
Motortype met id 
°°" 3
{
°°3 4
model
°°4 9
.
°°9 :
EngineTypeId
°°: F
}
°°F G
 niet gevonden
°°G U
"
°°U V
)
°°V W
;
°°W X
if
££ 
(
££ !
_doorTypeRepository
££ #
.
££# $
GetById
££$ +
(
££+ ,
(
££, -
int
££- 0
)
££0 1
model
££1 6
.
££6 7

DoorTypeId
££7 A
)
££A B
==
££C E
null
££F J
)
££J K
return
§§ 
NotFound
§§ 
(
§§  
$"
§§  "
Deurtype met id 
§§" 2
{
§§2 3
model
§§3 8
.
§§8 9

DoorTypeId
§§9 C
}
§§C D
 niet gevonden
§§D R
"
§§R S
)
§§S T
;
§§T U
if
¶¶ 
(
¶¶ !
_categoryRepository
¶¶ #
.
¶¶# $
GetById
¶¶$ +
(
¶¶+ ,
(
¶¶, -
int
¶¶- 0
)
¶¶0 1
model
¶¶1 6
.
¶¶6 7

CategoryId
¶¶7 A
)
¶¶A B
==
¶¶C E
null
¶¶F J
)
¶¶J K
return
ßß 
NotFound
ßß 
(
ßß  
$"
ßß  "
Categorie met id 
ßß" 3
{
ßß3 4
model
ßß4 9
.
ßß9 :

CategoryId
ßß: D
}
ßßD E
 niet gevonden
ßßE S
"
ßßS T
)
ßßT U
;
ßßU V
if
©© 
(
©© 
model
©© 
.
©© 

FuelCardId
©©  
!=
©©! #
null
©©$ (
)
©©( )
{
™™ 
if
´´ 
(
´´ !
_fuelCardRepository
´´ '
.
´´' (
GetById
´´( /
(
´´/ 0
(
´´0 1
int
´´1 4
)
´´4 5
model
´´5 :
.
´´: ;

FuelCardId
´´; E
)
´´E F
==
´´G I
null
´´J N
)
´´N O
return
¨¨ 
NotFound
¨¨ #
(
¨¨# $
$"
¨¨$ &
Tankkaart met id 
¨¨& 7
{
¨¨7 8
model
¨¨8 =
.
¨¨= >

FuelCardId
¨¨> H
}
¨¨H I
 niet gevonden
¨¨I W
"
¨¨W X
)
¨¨X Y
;
¨¨Y Z
var
ÆÆ 
vehicle
ÆÆ 
=
ÆÆ  
_vehicleRepository
ÆÆ 0
.
ÆÆ0 1
Find
ÆÆ1 5
(
ÆÆ5 6
v
ÆÆ6 7
=>
ÆÆ8 :
v
ÆÆ; <
.
ÆÆ< =
FuelCard
ÆÆ= E
.
ÆÆE F
Id
ÆÆF H
==
ÆÆI K
model
ÆÆL Q
.
ÆÆQ R

FuelCardId
ÆÆR \
)
ÆÆ\ ]
.
ÆÆ] ^
FirstOrDefault
ÆÆ^ l
(
ÆÆl m
)
ÆÆm n
;
ÆÆn o
if
∞∞ 
(
∞∞ 
vehicle
∞∞ 
!=
∞∞ 
null
∞∞ #
&&
∞∞$ &
vehicle
∞∞' .
.
∞∞. /
Id
∞∞/ 1
!=
∞∞2 4
model
∞∞5 :
.
∞∞: ;
Id
∞∞; =
)
∞∞= >
return
±± 

BadRequest
±± %
(
±±% &
$"
±±& (,
Een voertuig met tankkaart id 
±±( F
{
±±F G
model
±±G L
.
±±L M

FuelCardId
±±M W
}
±±W X
 bestaat al
±±X c
"
±±c d
)
±±d e
;
±±e f
}
≤≤ 
if
¥¥ 
(
¥¥ 
_serieRepository
¥¥  
.
¥¥  !
GetById
¥¥! (
(
¥¥( )
(
¥¥) *
int
¥¥* -
)
¥¥- .
model
¥¥. 3
.
¥¥3 4
SeriesId
¥¥4 <
)
¥¥< =
==
¥¥> @
null
¥¥A E
)
¥¥E F
return
µµ 
NotFound
µµ 
(
µµ  
$"
µµ  "
Serie met id 
µµ" /
{
µµ/ 0
model
µµ0 5
.
µµ5 6
SeriesId
µµ6 >
}
µµ> ?
 niet gevonden
µµ? M
"
µµM N
)
µµN O
;
µµO P
return
∑∑ 
base
∑∑ 
.
∑∑ 
UpdateEntity
∑∑ $
(
∑∑$ %
model
∑∑% *
,
∑∑* +
id
∑∑, .
)
∑∑. /
;
∑∑/ 0
}
∏∏ 	
}
ππ 
}∫∫ £
jD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\FuelCardMappers\DriverMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
FuelCardMappers ,
{ 
public 

class 
DriverMapper 
: 
IMapper  '
<' (
Driver( .
,. /
DriverModel0 ;
,; <
DriverReturnModel= N
>N O
{ 
private		 
readonly		 
PersonMapper		 %
_personMapper		& 3
;		3 4
public 
DriverMapper 
( 
) 
{ 	
_personMapper 
= 
new 
PersonMapper  ,
(, -
)- .
;. /
} 	
public 
DriverReturnModel  "
MapEntityToReturnModel! 7
(7 8
Driver8 >
entity? E
)E F
{ 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
DriverReturnModel (
{ 
EndDate 
= 
entity  
.  !
EndDate! (
,( )
	StartDate 
= 
entity "
." #
	StartDate# ,
,, -
Id 
= 
entity 
. 
Id 
, 
Person 
= 
_personMapper &
.& '"
MapEntityToReturnModel' =
(= >
entity> D
.D E
PersonE K
)K L
} 
; 
} 	
public 
Driver 
MapModelToEntity &
(& '
DriverModel' 2
model3 8
)8 9
{ 	
return 
new 
Driver 
{   
Id!! 
=!! 
model!! 
.!! 
Id!! 
,!! 
EndDate"" 
="" 
model"" 
.""  
EndDate""  '
,""' (
PersonId## 
=## 
(## 
int## 
)##  
model##  %
.##% &
PersonId##& .
,##. /
	StartDate$$ 
=$$ 
model$$ !
.$$! "
	StartDate$$" +
}%% 
;%% 
}&& 	
}'' 
}(( ”U
lD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\FuelCardMappers\FuelCardMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
FuelCardMappers ,
{ 
public		 

class		 
FuelCardMapper		 
:		  !
IMapper		" )
<		) *
FuelCard		* 2
,		2 3
FuelCardModel		4 A
,		A B
FuelCardReturnModel		C V
>		V W
{

 
private 
readonly 
BrandMapper $
_brandMapper% 1
;1 2
private 
readonly 
CategoryMapper '
_categoryMapper( 7
;7 8
private 
readonly 
CountryMapper &
_countryMapper' 5
;5 6
private 
readonly 
DoorTypeMapper '
_doorTypeMapper( 7
;7 8
private 
readonly 
DriverMapper %
_driverMapper& 3
;3 4
private 
readonly 
EngineTypeMapper )
_engineTypeMapper* ;
;; <
private 
readonly 
ExteriorColorMapper , 
_exteriorColorMapper- A
;A B
private 
readonly 
FuelTypeMapper '
_fuelTypeMapper( 7
;7 8
private 
readonly 
InteriorColorMapper , 
_interiorColorMapper- A
;A B
private 
readonly 
ModelMapper $
_modelMapper% 1
;1 2
private 
readonly 
SerieMapper $
_serieMapper% 1
;1 2
public 
FuelCardMapper 
( 
) 
{ 	
_brandMapper 
= 
new 
BrandMapper *
(* +
)+ ,
;, -
_fuelTypeMapper 
= 
new !
FuelTypeMapper" 0
(0 1
)1 2
;2 3
_engineTypeMapper 
= 
new  #
EngineTypeMapper$ 4
(4 5
)5 6
;6 7
_doorTypeMapper 
= 
new !
DoorTypeMapper" 0
(0 1
)1 2
;2 3
_modelMapper 
= 
new 
ModelMapper *
(* +
)+ ,
;, -
_categoryMapper 
= 
new !
CategoryMapper" 0
(0 1
)1 2
;2 3
_serieMapper 
= 
new 
SerieMapper *
(* +
)+ ,
;, -
_countryMapper   
=   
new    
CountryMapper  ! .
(  . /
)  / 0
;  0 1
_driverMapper!! 
=!! 
new!! 
DriverMapper!!  ,
(!!, -
)!!- .
;!!. / 
_exteriorColorMapper""  
=""! "
new""# &
ExteriorColorMapper""' :
("": ;
)""; <
;""< = 
_interiorColorMapper##  
=##! "
new### &
InteriorColorMapper##' :
(##: ;
)##; <
;##< =
}$$ 	
public&& 
FuelCardReturnModel&& ""
MapEntityToReturnModel&&# 9
(&&9 :
FuelCard&&: B
entity&&C I
)&&I J
{'' 	
if(( 
((( 
entity(( 
==(( 
null(( 
)(( 
return)) 
null)) 
;)) 
return** 
new** 
FuelCardReturnModel** *
{++ 
Driver,, 
=,, 
_driverMapper,, &
.,,& '"
MapEntityToReturnModel,,' =
(,,= >
entity,,> D
.,,D E
Driver,,E K
),,K L
,,,L M
EndDate-- 
=-- 
entity--  
.--  !
EndDate--! (
,--( )
	StartDate.. 
=.. 
entity.. "
..." #
	StartDate..# ,
,.., -
Company// 
=// 
entity//  
.//  !
Company//! (
,//( )
Id00 
=00 
entity00 
.00 
Id00 
,00 
BlockingDate11 
=11 
entity11 %
.11% &
BlockingDate11& 2
,112 3
BlockingReason22 
=22  
entity22! '
.22' (
BlockingReason22( 6
,226 7
	IsBlocked33 
=33 
entity33 "
.33" #
	IsBlocked33# ,
,33, -
PinCode44 
=44 
entity44  
.44  !
PinCode44! (
,44( )
Number55 
=55 
entity55 
.55  
Number55  &
,55& '
Vehicle66 
=66 
MapVehicleEntity66 *
(66* +
entity66+ 1
.661 2
Vehicle662 9
)669 :
}77 
;77 
}88 	
public:: 
FuelCard:: 
MapModelToEntity:: (
(::( )
FuelCardModel::) 6
model::7 <
)::< =
{;; 	
return<< 
new<< 
FuelCard<< 
{== 
DriverId>> 
=>> 
(>> 
int>> 
)>>  
model>>  %
.>>% &
DriverId>>& .
,>>. /
EndDate?? 
=?? 
model?? 
.??  
EndDate??  '
,??' (
Id@@ 
=@@ 
model@@ 
.@@ 
Id@@ 
,@@ 
	StartDateAA 
=AA 
modelAA !
.AA! "
	StartDateAA" +
,AA+ ,
BlockingDateBB 
=BB 
modelBB $
.BB$ %
BlockingDateBB% 1
,BB1 2
BlockingReasonCC 
=CC  
modelCC! &
.CC& '
BlockingReasonCC' 5
,CC5 6
	IsBlockedDD 
=DD 
modelDD !
.DD! "
	IsBlockedDD" +
,DD+ ,
PinCodeEE 
=EE 
modelEE 
.EE  
PinCodeEE  '
,EE' (
NumberFF 
=FF 
modelFF 
.FF 
NumberFF %
,FF% &
	VehicleIdGG 
=GG 
modelGG !
.GG! "
	VehicleIdGG" +
,GG+ ,
	CompanyIdHH 
=HH 
modelHH !
.HH! "
	CompanyIdHH" +
}II 
;II 
}JJ 	
privateLL 
VehicleReturnModelLL "
MapVehicleEntityLL# 3
(LL3 4
VehicleLL4 ;
vehicleLL< C
)LLC D
{MM 	
ifNN 
(NN 
vehicleNN 
==NN 
nullNN 
)NN  
returnOO 
nullOO 
;OO 
returnPP 
newPP 
VehicleReturnModelPP )
{QQ 
IdRR 
=RR 
vehicleRR 
.RR 
IdRR 
,RR  
BrandSS 
=SS 
_brandMapperSS $
.SS$ %"
MapEntityToReturnModelSS% ;
(SS; <
vehicleSS< C
.SSC D
BrandSSD I
)SSI J
,SSJ K
FuelTypeTT 
=TT 
_fuelTypeMapperTT *
.TT* +"
MapEntityToReturnModelTT+ A
(TTA B
vehicleTTB I
.TTI J
FuelTypeTTJ R
)TTR S
,TTS T

EngineTypeUU 
=UU 
_engineTypeMapperUU .
.UU. /"
MapEntityToReturnModelUU/ E
(UUE F
vehicleUUF M
.UUM N

EngineTypeUUN X
)UUX Y
,UUY Z
DoorTypeVV 
=VV 
_doorTypeMapperVV *
.VV* +"
MapEntityToReturnModelVV+ A
(VVA B
vehicleVVB I
.VVI J
DoorTypeVVJ R
)VVR S
,VVS T
EmissionWW 
=WW 
vehicleWW "
.WW" #
EmissionWW# +
,WW+ ,
FiscalHPXX 
=XX 
vehicleXX "
.XX" #
FiscalHPXX# +
,XX+ ,
IsActiveYY 
=YY 
vehicleYY "
.YY" #
IsActiveYY# +
,YY+ ,
VolumeZZ 
=ZZ 
vehicleZZ  
.ZZ  !
VolumeZZ! '
,ZZ' (
Model[[ 
=[[ 
_modelMapper[[ $
.[[$ %"
MapEntityToReturnModel[[% ;
([[; <
vehicle[[< C
.[[C D
Model[[D I
)[[I J
,[[J K
Category\\ 
=\\ 
_categoryMapper\\ *
.\\* +"
MapEntityToReturnModel\\+ A
(\\A B
vehicle\\B I
.\\I J
Category\\J R
)\\R S
,\\S T
LicensePlate]] 
=]] 
vehicle]] &
.]]& '
LicensePlate]]' 3
,]]3 4
Chassis^^ 
=^^ 
vehicle^^ !
.^^! "
Chassis^^" )
,^^) *
AverageFuel__ 
=__ 
vehicle__ %
.__% &
AverageFuel__& 1
,__1 2
EndDateDelivery`` 
=``  !
vehicle``" )
.``) *
EndDateDelivery``* 9
,``9 :
EngineCapacityaa 
=aa  
vehicleaa! (
.aa( )
EngineCapacityaa) 7
,aa7 8
EnginePowerbb 
=bb 
vehiclebb %
.bb% &
EnginePowerbb& 1
,bb1 2
Seriecc 
=cc 
_serieMappercc $
.cc$ %"
MapEntityToReturnModelcc% ;
(cc; <
vehiclecc< C
.ccC D
SeriesccD J
)ccJ K
,ccK L
	BuildYeardd 
=dd 
vehicledd #
.dd# $
	BuildYeardd$ -
,dd- .
Countryee 
=ee 
_countryMapperee (
.ee( )"
MapEntityToReturnModelee) ?
(ee? @
vehicleee@ G
.eeG H
CountryeeH O
)eeO P
,eeP Q

Kilometersff 
=ff 
vehicleff $
.ff$ %

Kilometersff% /
,ff/ 0
RegistrationDategg  
=gg! "
vehiclegg# *
.gg* +
RegistrationDategg+ ;
,gg; <
ExteriorColorhh 
=hh  
_exteriorColorMapperhh  4
.hh4 5"
MapExteriorColorEntityhh5 K
(hhK L
vehiclehhL S
.hhS T
ExteriorColorhhT a
)hha b
,hhb c
InteriorColorii 
=ii  
_interiorColorMapperii  4
.ii4 5"
MapInteriorColorEntityii5 K
(iiK L
vehicleiiL S
.iiS T
InteriorColoriiT a
)iia b
}jj 
;jj 
}kk 	
}ll 
}mm ±
jD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\FuelCardMappers\PersonMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
FuelCardMappers ,
{ 
public 

class 
PersonMapper 
: 
IMapper  '
<' (
Person( .
,. /
PersonModel0 ;
,; <
PersonReturnModel= N
>N O
{ 
public		 
PersonReturnModel		  "
MapEntityToReturnModel		! 7
(		7 8
Person		8 >
entity		? E
)		E F
{

 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
PersonReturnModel (
{ 
Title 
= 
entity 
. 
Title $
,$ %
	BirthDate 
= 
entity "
." #
	BirthDate# ,
,, -#
StartDateDriversLicense '
=( )
entity* 0
.0 1#
StartDateDriversLicense1 H
,H I
Picture 
= 
entity  
.  !
Picture! (
,( )
Lastname 
= 
entity !
.! "
Lastname" *
,* +
Language 
= 
entity !
.! "
Language" *
,* +
Id 
= 
entity 
. 
Id 
, 
Gender 
= 
entity 
.  
Gender  &
,& '
	Firstname 
= 
entity "
." #
	Firstname# ,
,, -!
EndDateDriversLicense %
=& '
entity( .
.. /!
EndDateDriversLicense/ D
,D E 
DriversLicenseNumber $
=% &
entity' -
.- . 
DriversLicenseNumber. B
,B C
DriversLicenseType "
=# $
entity% +
.+ ,
DriversLicenseType, >
} 
; 
} 	
public 
Person 
MapModelToEntity &
(& '
PersonModel' 2
model3 8
)8 9
{ 	
return   
new   
Person   
{!! 
	BirthDate"" 
="" 
model"" !
.""! "
	BirthDate""" +
,""+ , 
DriversLicenseNumber## $
=##% &
model##' ,
.##, - 
DriversLicenseNumber##- A
,##A B
DriversLicenseType$$ "
=$$# $
model$$% *
.$$* +
DriversLicenseType$$+ =
,$$= >!
EndDateDriversLicense%% %
=%%& '
model%%( -
.%%- .!
EndDateDriversLicense%%. C
,%%C D
	Firstname&& 
=&& 
model&& !
.&&! "
	Firstname&&" +
,&&+ ,
Gender'' 
='' 
model'' 
.'' 
Gender'' %
,''% &
Id(( 
=(( 
model(( 
.(( 
Id(( 
,(( 
Language)) 
=)) 
model))  
.))  !
Language))! )
,))) *
Lastname** 
=** 
model**  
.**  !
Lastname**! )
,**) *
Picture++ 
=++ 
model++ 
.++  
Picture++  '
,++' (#
StartDateDriversLicense,, '
=,,( )
model,,* /
.,,/ 0#
StartDateDriversLicense,,0 G
,,,G H
Title-- 
=-- 
model-- 
.-- 
Title-- #
}.. 
;.. 
}// 	
}00 
}11 ˜
UD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\IMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
{ 
public 

	interface 
IMapper 
< 
TEntity $
,$ %
in& (
TModel) /
,/ 0
out1 4
TReturnModel5 A
>A B
{ 
TReturnModel "
MapEntityToReturnModel +
(+ ,
TEntity, 3
entity4 :
): ;
;; <
TEntity 
MapModelToEntity  
(  !
TModel! '
model( -
)- .
;. /
} 
} ô
iD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\RecordMappers\CompanyMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
RecordMappers *
{ 
public 

class 
CompanyMapper 
:  
IMapper! (
<( )
Company) 0
,0 1
CompanyModel2 >
,> ?
CompanyReturnModel@ R
>R S
{ 
public		 
CompanyReturnModel		 !"
MapEntityToReturnModel		" 8
(		8 9
Company		9 @
entity		A G
)		G H
{

 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
CompanyReturnModel )
{ 
Name 
= 
entity 
. 
Name "
," #
AccountNumber 
= 
entity  &
.& '
AccountNumber' 4
,4 5
Description 
= 
entity $
.$ %
Description% 0
,0 1
Id 
= 
entity 
. 
Id 
, 
IsActive 
= 
entity !
.! "
IsActive" *
,* +

IsInternal 
= 
entity #
.# $

IsInternal$ .
,. /
NonActiveRemark 
=  !
entity" (
.( )
NonActiveRemark) 8
,8 9
	Reference 
= 
entity "
." #
	Reference# ,
,, -
VAT 
= 
entity 
. 
VAT  
} 
; 
} 	
public 
Company 
MapModelToEntity '
(' (
CompanyModel( 4
model5 :
): ;
{ 	
return 
new 
Company 
{ 
AccountNumber 
= 
model  %
.% &
AccountNumber& 3
,3 4
Description   
=   
model   #
.  # $
Description  $ /
,  / 0
Id!! 
=!! 
model!! 
.!! 
Id!! 
,!! 
IsActive"" 
="" 
model""  
.""  !
IsActive""! )
,"") *

IsInternal## 
=## 
model## "
.##" #

IsInternal### -
,##- .
Name$$ 
=$$ 
model$$ 
.$$ 
Name$$ !
,$$! "
NonActiveRemark%% 
=%%  !
model%%" '
.%%' (
NonActiveRemark%%( 7
,%%7 8
	Reference&& 
=&& 
model&& !
.&&! "
	Reference&&" +
,&&+ ,
VAT'' 
='' 
model'' 
.'' 
VAT'' 
}(( 
;(( 
})) 	
}** 
}++ ñ
mD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\RecordMappers\CorporationMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
RecordMappers *
{ 
public 

class 
CorporationMapper "
:# $
IMapper% ,
<, -
Corporation- 8
,8 9
CorporationModel: J
,J K"
CorporationReturnModelL b
>b c
{ 
private		 
readonly		 
CompanyMapper		 &
_companyMapper		' 5
;		5 6
public 
CorporationMapper  
(  !
)! "
{ 	
_companyMapper 
= 
new  
CompanyMapper! .
(. /
)/ 0
;0 1
} 	
public "
CorporationReturnModel %"
MapEntityToReturnModel& <
(< =
Corporation= H
entityI O
)O P
{ 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new "
CorporationReturnModel -
{ 
Abbreviation 
= 
entity %
.% &
Abbreviation& 2
,2 3
Company 
= 
_companyMapper (
.( )"
MapEntityToReturnModel) ?
(? @
entity@ F
.F G
CompanyG N
)N O
,O P
EndDate 
= 
entity  
.  !
EndDate! (
,( )
Id 
= 
entity 
. 
Id 
, 
Name 
= 
entity 
. 
Name "
," #
	StartDate 
= 
entity "
." #
	StartDate# ,
} 
; 
} 	
public 
Corporation 
MapModelToEntity +
(+ ,
CorporationModel, <
model= B
)B C
{   	
return!! 
new!! 
Corporation!! "
{"" 
Abbreviation## 
=## 
model## $
.##$ %
Abbreviation##% 1
,##1 2
	CompanyId$$ 
=$$ 
($$ 
int$$  
)$$  !
model$$! &
.$$& '
	CompanyId$$' 0
,$$0 1
EndDate%% 
=%% 
model%% 
.%%  
EndDate%%  '
,%%' (
Name&& 
=&& 
model&& 
.&& 
Name&& !
,&&! "
Id'' 
='' 
model'' 
.'' 
Id'' 
,'' 
	StartDate(( 
=(( 
model(( !
.((! "
	StartDate((" +
})) 
;)) 
}** 	
}++ 
},, ﬁ
pD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\RecordMappers\CostAllocationMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
RecordMappers *
{ 
public 

class  
CostAllocationMapper %
:& '
IMapper( /
</ 0
CostAllocation0 >
,> ?
CostAllocationModel@ S
,S T%
CostAllocationReturnModelU n
>n o
{ 
public		 %
CostAllocationReturnModel		 ("
MapEntityToReturnModel		) ?
(		? @
CostAllocation		@ N
entity		O U
)		U V
{

 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new %
CostAllocationReturnModel 0
{ 
Abbreviation 
= 
entity %
.% &
Abbreviation& 2
,2 3
EndDate 
= 
entity  
.  !
EndDate! (
,( )
Id 
= 
entity 
. 
Id 
, 
Name 
= 
entity 
. 
Name "
," #
	StartDate 
= 
entity "
." #
	StartDate# ,
} 
; 
} 	
public 
CostAllocation 
MapModelToEntity .
(. /
CostAllocationModel/ B
modelC H
)H I
{ 	
return 
new 
CostAllocation %
{ 
Abbreviation 
= 
model $
.$ %
Abbreviation% 1
,1 2
Id 
= 
model 
. 
Id 
, 
Name 
= 
model 
. 
Name !
,! "
	StartDate 
= 
model !
.! "
	StartDate" +
,+ ,
EndDate 
= 
model 
.  
EndDate  '
}   
;   
}!! 	
}"" 
}## ù!
hD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\RecordMappers\RecordMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
RecordMappers *
{ 
public 

class 
RecordMapper 
: 
IMapper  '
<' (
Record( .
,. /
RecordModel0 ;
,; <
RecordReturnModel= N
>N O
{		 
private

 
readonly

 
CorporationMapper

 *
_coporationMapper

+ <
;

< =
private 
readonly  
CostAllocationMapper -!
_costAllocationMapper. C
;C D
private 
readonly 
FuelCardMapper '
_fuelCardMapper( 7
;7 8
public 
RecordMapper 
( 
) 
{ 	
_fuelCardMapper 
= 
new !
FuelCardMapper" 0
(0 1
)1 2
;2 3
_coporationMapper 
= 
new  #
CorporationMapper$ 5
(5 6
)6 7
;7 8!
_costAllocationMapper !
=" #
new$ ' 
CostAllocationMapper( <
(< =
)= >
;> ?
} 	
public 
RecordReturnModel  "
MapEntityToReturnModel! 7
(7 8
Record8 >
entity? E
)E F
{ 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
RecordReturnModel (
{ 
FuelCard 
= 
_fuelCardMapper *
.* +"
MapEntityToReturnModel+ A
(A B
entityB H
.H I
FuelCardI Q
)Q R
,R S
Id 
= 
entity 
. 
Id 
, 
Term 
= 
entity 
. 
Term "
," #
Usage 
= 
entity 
. 
Usage $
,$ %
EndDate 
= 
entity  
.  !
EndDate! (
,( )
	StartDate   
=   
entity   "
.  " #
	StartDate  # ,
,  , -
Corporation!! 
=!! 
_coporationMapper!! /
.!!/ 0"
MapEntityToReturnModel!!0 F
(!!F G
entity!!G M
.!!M N
Corporation!!N Y
)!!Y Z
,!!Z [
CostAllocation"" 
=""  !
_costAllocationMapper""! 6
.""6 7"
MapEntityToReturnModel""7 M
(""M N
entity""N T
.""T U
CostAllocation""U c
)""c d
}## 
;## 
}$$ 	
public&& 
Record&& 
MapModelToEntity&& &
(&&& '
RecordModel&&' 2
model&&3 8
)&&8 9
{'' 	
return(( 
new(( 
Record(( 
{)) 
Usage** 
=** 
model** 
.** 
Usage** #
,**# $
CorporationId++ 
=++ 
model++  %
.++% &
CorporationId++& 3
,++3 4
CostAllocationId,,  
=,,! "
model,,# (
.,,( )
CostAllocationId,,) 9
,,,9 :
EndDate-- 
=-- 
model-- 
.--  
EndDate--  '
,--' (

FuelCardId.. 
=.. 
(.. 
int.. !
)..! "
model.." '
...' (

FuelCardId..( 2
,..2 3
Id// 
=// 
model// 
.// 
Id// 
,// 
	StartDate00 
=00 
model00 !
.00! "
	StartDate00" +
,00+ ,
Term11 
=11 
model11 
.11 
Term11 !
}22 
;22 
}33 	
}44 
}55 ¸
lD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\SupplierMappers\SupplierMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
SupplierMappers ,
{ 
public 

class 
SupplierMapper 
:  !
IMapper" )
<) *
Supplier* 2
,2 3
SupplierModel4 A
,A B
SupplierReturnModelC V
>V W
{ 
public		 
SupplierReturnModel		 ""
MapEntityToReturnModel		# 9
(		9 :
Supplier		: B
entity		C I
)		I J
{

 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
SupplierReturnModel *
{ 
Name 
= 
entity 
. 
Name "
," #
Active 
= 
entity 
.  
Active  &
,& '
Id 
= 
entity 
. 
Id 
, 
Internal 
= 
entity !
.! "
Internal" *
,* +
Types 
= 
entity 
. 
Types $
} 
; 
} 	
public 
Supplier 
MapModelToEntity (
(( )
SupplierModel) 6
model7 <
)< =
{ 	
return 
new 
Supplier 
{ 
Name 
= 
model 
. 
Name !
,! "
Active 
= 
model 
. 
Active %
,% &
Id 
= 
model 
. 
Id 
, 
Internal 
= 
model  
.  !
Internal! )
,) *
Types   
=   
model   
.   
Types   #
}!! 
;!! 
}"" 	
}## 
}$$ Ö
hD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\BrandMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public 

class 
BrandMapper 
: 
IMapper &
<& '
Brand' ,
,, -

BrandModel. 8
,8 9
BrandReturnModel: J
>J K
{		 
private

 
readonly

 
ExteriorColorMapper

 , 
_exteriorColorMapper

- A
;

A B
private 
readonly 
InteriorColorMapper , 
_interiorColorMapper- A
;A B
public 
BrandMapper 
( 
) 
{ 	 
_interiorColorMapper  
=! "
new# &
InteriorColorMapper' :
(: ;
); <
;< = 
_exteriorColorMapper  
=! "
new# &
ExteriorColorMapper' :
(: ;
); <
;< =
} 	
public 
BrandReturnModel "
MapEntityToReturnModel  6
(6 7
Brand7 <
entity= C
)C D
{ 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
BrandReturnModel '
{ 
Name 
= 
entity 
. 
Name "
," #
Id 
= 
entity 
. 
Id 
, 
ExteriorColors 
=  
entity! '
.' (
ExteriorColors( 6
.6 7
Select7 =
(= > 
_exteriorColorMapper> R
.R S"
MapExteriorColorEntityS i
)i j
.j k
ToListk q
(q r
)r s
,s t
InteriorColors 
=  
entity! '
.' (
InteriorColors( 6
.6 7
Select7 =
(= > 
_interiorColorMapper> R
.R S"
MapInteriorColorEntityS i
)i j
.j k
ToListk q
(q r
)r s
} 
; 
} 	
public   
Brand   
MapModelToEntity   %
(  % &

BrandModel  & 0
model  1 6
)  6 7
{!! 	
return"" 
new"" 
Brand"" 
{## 
Id$$ 
=$$ 
model$$ 
.$$ 
Id$$ 
,$$ 
Name%% 
=%% 
model%% 
.%% 
Name%% !
}&& 
;&& 
}'' 	
}(( 
})) É
kD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\CategoryMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public 

class 
CategoryMapper 
:  !
IMapper" )
<) *
Category* 2
,2 3
CategoryModel4 A
,A B
CategoryReturnModelC V
>V W
{ 
public		 
CategoryReturnModel		 ""
MapEntityToReturnModel		# 9
(		9 :
Category		: B
entity		C I
)		I J
{

 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
CategoryReturnModel *
{ 
Id 
= 
entity 
. 
Id 
, 
Name 
= 
entity 
. 
Name "
} 
; 
} 	
public 
Category 
MapModelToEntity (
(( )
CategoryModel) 6
model7 <
)< =
{ 	
return 
new 
Category 
{ 
Name 
= 
model 
. 
Name !
,! "
Id 
= 
model 
. 
Id 
} 
; 
} 	
} 
} ƒ
jD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\CountryMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public 

class 
CountryMapper 
:  
IMapper! (
<( )
Country) 0
,0 1
CountryModel2 >
,> ?
CountryReturnModel@ R
>R S
{ 
public		 
CountryReturnModel		 !"
MapEntityToReturnModel		" 8
(		8 9
Country		9 @
entity		A G
)		G H
{

 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
CountryReturnModel )
{ 
Code 
= 
entity 
. 
Code "
," #
Id 
= 
entity 
. 
Id 
, 
IsActive 
= 
entity !
.! "
IsActive" *
,* +
Name 
= 
entity 
. 
Name "
," #
Nationality 
= 
entity $
.$ %
Nationality% 0
,0 1
POD 
= 
entity 
. 
POD  
} 
; 
} 	
public 
Country 
MapModelToEntity '
(' (
CountryModel( 4
model5 :
): ;
{ 	
return 
new 
Country 
{ 
POD 
= 
model 
. 
POD 
,  
Code 
= 
model 
. 
Code !
,! "
Id 
= 
model 
. 
Id 
, 
IsActive 
= 
model  
.  !
IsActive! )
,) *
Name   
=   
model   
.   
Name   !
,  ! "
Nationality!! 
=!! 
model!! #
.!!# $
Nationality!!$ /
}"" 
;"" 
}## 	
}$$ 
}%% É
kD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\DoorTypeMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public 

class 
DoorTypeMapper 
:  !
IMapper" )
<) *
DoorType* 2
,2 3
DoorTypeModel4 A
,A B
DoorTypeReturnModelC V
>V W
{ 
public		 
DoorTypeReturnModel		 ""
MapEntityToReturnModel		# 9
(		9 :
DoorType		: B
entity		C I
)		I J
{

 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
DoorTypeReturnModel *
{ 
Id 
= 
entity 
. 
Id 
, 
Name 
= 
entity 
. 
Name "
} 
; 
} 	
public 
DoorType 
MapModelToEntity (
(( )
DoorTypeModel) 6
model7 <
)< =
{ 	
return 
new 
DoorType 
{ 
Id 
= 
model 
. 
Id 
, 
Name 
= 
model 
. 
Name !
} 
; 
} 	
} 
} ﬂ
mD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\EngineTypeMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public 

class 
EngineTypeMapper !
:" #
IMapper$ +
<+ ,

EngineType, 6
,6 7
EngineTypeModel8 G
,G H!
EngineTypeReturnModelI ^
>^ _
{ 
private		 
readonly		 
BrandMapper		 $
_brandMapper		% 1
;		1 2
public 
EngineTypeMapper 
(  
)  !
{ 	
_brandMapper 
= 
new 
BrandMapper *
(* +
)+ ,
;, -
} 	
public !
EngineTypeReturnModel $"
MapEntityToReturnModel% ;
(; <

EngineType< F
entityG M
)M N
{ 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new !
EngineTypeReturnModel ,
{ 
Brand 
= 
_brandMapper $
.$ %"
MapEntityToReturnModel% ;
(; <
entity< B
.B C
BrandC H
)H I
,I J
Name 
= 
entity 
. 
Name "
," #
Id 
= 
entity 
. 
Id 
} 
; 
} 	
public 

EngineType 
MapModelToEntity *
(* +
EngineTypeModel+ :
model; @
)@ A
{ 	
return 
new 

EngineType !
{ 
BrandId   
=   
(   
int   
)   
model   $
.  $ %
BrandId  % ,
,  , -
Id!! 
=!! 
model!! 
.!! 
Id!! 
,!! 
Name"" 
="" 
model"" 
."" 
Name"" !
}## 
;## 
}$$ 	
}%% 
}&& £	
pD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\ExteriorColorMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public 

class 
ExteriorColorMapper $
{ 
public $
ExteriorColorReturnModel '"
MapExteriorColorEntity( >
(> ?
ExteriorColor? L
exteriorColorM Z
)Z [
{		 	
if

 
(

 
exteriorColor

 
==

  
null

! %
)

% &
return 
null 
; 
return 
new $
ExteriorColorReturnModel /
{ 
Code 
= 
exteriorColor $
.$ %
Code% )
,) *
Id 
= 
exteriorColor "
." #
Id# %
,% &
Name 
= 
exteriorColor $
.$ %
Name% )
} 
; 
} 	
} 
} Ã
kD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\FuelTypeMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public 

class 
FuelTypeMapper 
:  !
IMapper" )
<) *
FuelType* 2
,2 3
FuelTypeModel4 A
,A B
FuelTypeReturnModelC V
>V W
{ 
public		 
FuelTypeReturnModel		 ""
MapEntityToReturnModel		# 9
(		9 :
FuelType		: B
entity		C I
)		I J
{

 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
FuelTypeReturnModel *
{ 
Id 
= 
entity 
. 
Id 
, 
Code 
= 
entity 
. 
Code "
," #
Name 
= 
entity 
. 
Name "
} 
; 
} 	
public 
FuelType 
MapModelToEntity (
(( )
FuelTypeModel) 6
model7 <
)< =
{ 	
return 
new 
FuelType 
{ 
Code 
= 
model 
. 
Code !
,! "
Id 
= 
model 
. 
Id 
, 
Name 
= 
model 
. 
Name !
} 
; 
} 	
} 
} £	
pD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\InteriorColorMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public 

class 
InteriorColorMapper $
{ 
public $
InteriorColorReturnModel '"
MapInteriorColorEntity( >
(> ?
InteriorColor? L
interiorColorM Z
)Z [
{		 	
if

 
(

 
interiorColor

 
==

  
null

! %
)

% &
return 
null 
; 
return 
new $
InteriorColorReturnModel /
{ 
Id 
= 
interiorColor "
." #
Id# %
,% &
Code 
= 
interiorColor $
.$ %
Code% )
,) *
Name 
= 
interiorColor $
.$ %
Name% )
} 
; 
} 	
} 
} £
hD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\ModelMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public 

class 
ModelMapper 
: 
IMapper &
<& '
Model' ,
,, -

ModelModel. 8
,8 9
ModelReturnModel: J
>J K
{ 
private		 
readonly		 
BrandMapper		 $
_brandMapper		% 1
;		1 2
public 
ModelMapper 
( 
) 
{ 	
_brandMapper 
= 
new 
BrandMapper *
(* +
)+ ,
;, -
} 	
public 
ModelReturnModel "
MapEntityToReturnModel  6
(6 7
Model7 <
entity= C
)C D
{ 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
ModelReturnModel '
{ 
Brand 
= 
_brandMapper $
.$ %"
MapEntityToReturnModel% ;
(; <
entity< B
.B C
BrandC H
)H I
,I J
Name 
= 
entity 
. 
Name "
," #
Id 
= 
entity 
. 
Id 
} 
; 
} 	
public 
Model 
MapModelToEntity %
(% &

ModelModel& 0
model1 6
)6 7
{ 	
return 
new 
Model 
{ 
BrandId   
=   
(   
int   
)   
model   $
.  $ %
BrandId  % ,
,  , -
Id!! 
=!! 
model!! 
.!! 
Id!! 
,!! 
Name"" 
="" 
model"" 
."" 
Name"" !
}## 
;## 
}$$ 	
}%% 
}&& ß
hD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\SerieMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public 

class 
SerieMapper 
: 
IMapper &
<& '
Series' -
,- .

SerieModel/ 9
,9 :
SerieReturnModel; K
>K L
{ 
private		 
readonly		 
BrandMapper		 $
_brandMapper		% 1
;		1 2
public 
SerieMapper 
( 
) 
{ 	
_brandMapper 
= 
new 
BrandMapper *
(* +
)+ ,
;, -
} 	
public 
SerieReturnModel "
MapEntityToReturnModel  6
(6 7
Series7 =
entity> D
)D E
{ 	
if 
( 
entity 
== 
null 
) 
return 
null 
; 
return 
new 
SerieReturnModel '
{ 
Brand 
= 
_brandMapper $
.$ %"
MapEntityToReturnModel% ;
(; <
entity< B
.B C
BrandC H
)H I
,I J
Name 
= 
entity 
. 
Name "
," #
Id 
= 
entity 
. 
Id 
} 
; 
} 	
public 
Series 
MapModelToEntity &
(& '

SerieModel' 1
model2 7
)7 8
{ 	
return 
new 
Series 
{ 
BrandId   
=   
(   
int   
)   
model   $
.  $ %
BrandId  % ,
,  , -
Id!! 
=!! 
model!! 
.!! 
Id!! 
,!! 
Name"" 
="" 
model"" 
."" 
Name"" !
}## 
;## 
}$$ 	
}%% 
}&& ôd
jD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Mappers\VehicleMappers\VehicleMapper.cs
	namespace 	
eMenka
 
. 
API 
. 
Mappers 
. 
VehicleMappers +
{ 
public		 

class		 
VehicleMapper		 
:		  
IMapper		! (
<		( )
Vehicle		) 0
,		0 1
VehicleModel		2 >
,		> ?
VehicleReturnModel		@ R
>		R S
{

 
private 
readonly 
BrandMapper $
_brandMapper% 1
;1 2
private 
readonly 
CategoryMapper '
_categoryMapper( 7
;7 8
private 
readonly 
CountryMapper &
_countryMapper' 5
;5 6
private 
readonly 
DoorTypeMapper '
_doorTypeMapper( 7
;7 8
private 
readonly 
DriverMapper %
_driverMapper& 3
;3 4
private 
readonly 
EngineTypeMapper )
_engineTypeMapper* ;
;; <
private 
readonly 
ExteriorColorMapper , 
_exteriorColorMapper- A
;A B
private 
readonly 
FuelTypeMapper '
_fuelTypeMapper( 7
;7 8
private 
readonly 
InteriorColorMapper , 
_interiorColorMapper- A
;A B
private 
readonly 
ModelMapper $
_modelMapper% 1
;1 2
private 
readonly 
SerieMapper $
_serieMapper% 1
;1 2
public 
VehicleMapper 
( 
) 
{ 	
_brandMapper 
= 
new 
BrandMapper *
(* +
)+ ,
;, -
_fuelTypeMapper 
= 
new !
FuelTypeMapper" 0
(0 1
)1 2
;2 3
_engineTypeMapper 
= 
new  #
EngineTypeMapper$ 4
(4 5
)5 6
;6 7
_doorTypeMapper 
= 
new !
DoorTypeMapper" 0
(0 1
)1 2
;2 3
_modelMapper 
= 
new 
ModelMapper *
(* +
)+ ,
;, -
_categoryMapper 
= 
new !
CategoryMapper" 0
(0 1
)1 2
;2 3
_serieMapper 
= 
new 
SerieMapper *
(* +
)+ ,
;, -
_countryMapper   
=   
new    
CountryMapper  ! .
(  . /
)  / 0
;  0 1
_driverMapper!! 
=!! 
new!! 
DriverMapper!!  ,
(!!, -
)!!- .
;!!. / 
_interiorColorMapper""  
=""! "
new""# &
InteriorColorMapper""' :
("": ;
)""; <
;""< = 
_exteriorColorMapper##  
=##! "
new### &
ExteriorColorMapper##' :
(##: ;
)##; <
;##< =
}$$ 	
public&& 
VehicleReturnModel&& !"
MapEntityToReturnModel&&" 8
(&&8 9
Vehicle&&9 @
entity&&A G
)&&G H
{'' 	
if(( 
((( 
entity(( 
==(( 
null(( 
)(( 
return)) 
null)) 
;)) 
return** 
new** 
VehicleReturnModel** )
{++ 
Id,, 
=,, 
entity,, 
.,, 
Id,, 
,,, 
Brand-- 
=-- 
_brandMapper-- $
.--$ %"
MapEntityToReturnModel--% ;
(--; <
entity--< B
.--B C
Brand--C H
)--H I
,--I J
FuelType.. 
=.. 
_fuelTypeMapper.. *
...* +"
MapEntityToReturnModel..+ A
(..A B
entity..B H
...H I
FuelType..I Q
)..Q R
,..R S

EngineType// 
=// 
_engineTypeMapper// .
.//. /"
MapEntityToReturnModel/// E
(//E F
entity//F L
.//L M

EngineType//M W
)//W X
,//X Y
DoorType00 
=00 
_doorTypeMapper00 *
.00* +"
MapEntityToReturnModel00+ A
(00A B
entity00B H
.00H I
DoorType00I Q
)00Q R
,00R S
Emission11 
=11 
entity11 !
.11! "
Emission11" *
,11* +
FiscalHP22 
=22 
entity22 !
.22! "
FiscalHP22" *
,22* +
IsActive33 
=33 
entity33 !
.33! "
IsActive33" *
,33* +
Volume44 
=44 
entity44 
.44  
Volume44  &
,44& '
Model55 
=55 
_modelMapper55 $
.55$ %"
MapEntityToReturnModel55% ;
(55; <
entity55< B
.55B C
Model55C H
)55H I
,55I J
FuelCard66 
=66 
MapFuelCardEntity66 ,
(66, -
entity66- 3
.663 4
FuelCard664 <
)66< =
,66= >
Category77 
=77 
_categoryMapper77 *
.77* +"
MapEntityToReturnModel77+ A
(77A B
entity77B H
.77H I
Category77I Q
)77Q R
,77R S
LicensePlate88 
=88 
entity88 %
.88% &
LicensePlate88& 2
,882 3
Chassis99 
=99 
entity99  
.99  !
Chassis99! (
,99( )
AverageFuel:: 
=:: 
entity:: $
.::$ %
AverageFuel::% 0
,::0 1
EndDateDelivery;; 
=;;  !
entity;;" (
.;;( )
EndDateDelivery;;) 8
,;;8 9
EngineCapacity<< 
=<<  
entity<<! '
.<<' (
EngineCapacity<<( 6
,<<6 7
EnginePower== 
=== 
entity== $
.==$ %
EnginePower==% 0
,==0 1
Serie>> 
=>> 
_serieMapper>> $
.>>$ %"
MapEntityToReturnModel>>% ;
(>>; <
entity>>< B
.>>B C
Series>>C I
)>>I J
,>>J K
	BuildYear?? 
=?? 
entity?? "
.??" #
	BuildYear??# ,
,??, -
Country@@ 
=@@ 
_countryMapper@@ (
.@@( )"
MapEntityToReturnModel@@) ?
(@@? @
entity@@@ F
.@@F G
Country@@G N
)@@N O
,@@O P

KilometersAA 
=AA 
entityAA #
.AA# $

KilometersAA$ .
,AA. /
RegistrationDateBB  
=BB! "
entityBB# )
.BB) *
RegistrationDateBB* :
,BB: ;
ExteriorColorCC 
=CC  
_exteriorColorMapperCC  4
.CC4 5"
MapExteriorColorEntityCC5 K
(CCK L
entityCCL R
.CCR S
ExteriorColorCCS `
)CC` a
,CCa b
InteriorColorDD 
=DD  
_interiorColorMapperDD  4
.DD4 5"
MapInteriorColorEntityDD5 K
(DDK L
entityDDL R
.DDR S
InteriorColorDDS `
)DD` a
}EE 
;EE 
}FF 	
publicHH 
VehicleHH 
MapModelToEntityHH '
(HH' (
VehicleModelHH( 4
modelHH5 :
)HH: ;
{II 	
returnJJ 
newJJ 
VehicleJJ 
{KK 
IdLL 
=LL 
modelLL 
.LL 
IdLL 
,LL 
EngineTypeIdMM 
=MM 
(MM  
intMM  #
)MM# $
modelMM$ )
.MM) *
EngineTypeIdMM* 6
,MM6 7
BrandIdNN 
=NN 
(NN 
intNN 
)NN 
modelNN $
.NN$ %
BrandIdNN% ,
,NN, -

DoorTypeIdOO 
=OO 
(OO 
intOO !
)OO! "
modelOO" '
.OO' (

DoorTypeIdOO( 2
,OO2 3
EmissionPP 
=PP 
(PP 
intPP 
)PP  
modelPP  %
.PP% &
EmissionPP& .
,PP. /
FiscalHPQQ 
=QQ 
(QQ 
intQQ 
)QQ  
modelQQ  %
.QQ% &
FiscalHPQQ& .
,QQ. /

FuelTypeIdRR 
=RR 
(RR 
intRR !
)RR! "
modelRR" '
.RR' (

FuelTypeIdRR( 2
,RR2 3
IsActiveSS 
=SS 
modelSS  
.SS  !
IsActiveSS! )
,SS) *
ModelIdTT 
=TT 
(TT 
intTT 
)TT 
modelTT $
.TT$ %
ModelIdTT% ,
,TT, -
VolumeUU 
=UU 
(UU 
intUU 
)UU 
modelUU #
.UU# $
VolumeUU$ *
,UU* +
LicensePlateVV 
=VV 
modelVV $
.VV$ %
LicensePlateVV% 1
,VV1 2

FuelCardIdWW 
=WW 
modelWW "
.WW" #

FuelCardIdWW# -
,WW- .
SeriesIdXX 
=XX 
(XX 
intXX 
)XX  
modelXX  %
.XX% &
SeriesIdXX& .
,XX. /
ChassisYY 
=YY 
modelYY 
.YY  
ChassisYY  '
,YY' (
AverageFuelZZ 
=ZZ 
modelZZ #
.ZZ# $
AverageFuelZZ$ /
,ZZ/ 0
EndDateDelivery[[ 
=[[  !
model[[" '
.[[' (
EndDateDelivery[[( 7
,[[7 8
EngineCapacity\\ 
=\\  
model\\! &
.\\& '
EngineCapacity\\' 5
,\\5 6
EnginePower]] 
=]] 
model]] #
.]]# $
EnginePower]]$ /
,]]/ 0
	CountryId^^ 
=^^ 
model^^ !
.^^! "
	CountryId^^" +
,^^+ ,
	BuildYear__ 
=__ 
model__ !
.__! "
	BuildYear__" +
,__+ ,

CategoryId`` 
=`` 
model`` "
.``" #

CategoryId``# -
,``- .

Kilometersaa 
=aa 
modelaa "
.aa" #

Kilometersaa# -
,aa- .
RegistrationDatebb  
=bb! "
modelbb# (
.bb( )
RegistrationDatebb) 9
,bb9 :
ExteriorColorIdcc 
=cc  !
modelcc" '
.cc' (
ExteriorColorIdcc( 7
,cc7 8
InteriorColorIddd 
=dd  !
modeldd" '
.dd' (
InteriorColorIddd( 7
}ee 
;ee 
}ff 	
privatehh 
FuelCardReturnModelhh #
MapFuelCardEntityhh$ 5
(hh5 6
FuelCardhh6 >
fuelCardhh? G
)hhG H
{ii 	
ifjj 
(jj 
fuelCardjj 
==jj 
nulljj  
)jj  !
returnkk 
nullkk 
;kk 
returnll 
newll 
FuelCardReturnModelll *
{mm 
Drivernn 
=nn 
_driverMappernn &
.nn& '"
MapEntityToReturnModelnn' =
(nn= >
fuelCardnn> F
.nnF G
DrivernnG M
)nnM N
,nnN O
EndDateoo 
=oo 
fuelCardoo "
.oo" #
EndDateoo# *
,oo* +
	StartDatepp 
=pp 
fuelCardpp $
.pp$ %
	StartDatepp% .
,pp. /
Idqq 
=qq 
fuelCardqq 
.qq 
Idqq  
,qq  !
BlockingDaterr 
=rr 
fuelCardrr '
.rr' (
BlockingDaterr( 4
,rr4 5
BlockingReasonss 
=ss  
fuelCardss! )
.ss) *
BlockingReasonss* 8
,ss8 9
	IsBlockedtt 
=tt 
fuelCardtt $
.tt$ %
	IsBlockedtt% .
,tt. /
PinCodeuu 
=uu 
fuelCarduu "
.uu" #
PinCodeuu# *
,uu* +
Numbervv 
=vv 
fuelCardvv !
.vv! "
Numbervv" (
}ww 
;ww 
}xx 	
}yy 
}zz Ÿ
gD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\FuelCardModels\DriverModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
FuelCardModels *
{ 
public 

class 
DriverModel 
: 

IModelBase )
{ 
[ 	
Required	 
] 
public 
int 
? 
PersonId '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public		 
DateTime		 
	StartDate		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
public

 
DateTime

 
?

 
EndDate

  
{

! "
get

# &
;

& '
set

( +
;

+ ,
}

- .
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
} 
} ∫
iD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\FuelCardModels\FuelCardModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
FuelCardModels *
{ 
public 

class 
FuelCardModel 
:  

IModelBase! +
{ 
[ 	
Required	 
] 
public 
int 
? 
DriverId '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[		 	
Required			 
]		 
public		 
int		 
?		 
	VehicleId		 (
{		) *
get		+ .
;		. /
set		0 3
;		3 4
}		5 6
[

 	
Required

	 
]

 
public

 
int

 
?

 
	CompanyId

 (
{

) *
get

+ .
;

. /
set

0 3
;

3 4
}

5 6
public 
DateTime 
	StartDate !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 
? 
EndDate  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
bool 
	IsBlocked 
{ 
get  #
;# $
set% (
;( )
}* +
public 
DateTime 
? 
BlockingDate %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
BlockingReason $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
string 
PinCode 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
Number 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
} 
} Õ
gD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\FuelCardModels\PersonModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
FuelCardModels *
{ 
public 

class 
PersonModel 
: 

IModelBase )
{ 
[		 	
Required			 
]		 
public		 
string		  
	Firstname		! *
{		+ ,
get		- 0
;		0 1
set		2 5
;		5 6
}		7 8
[ 	
Required	 
] 
public 
string  
Lastname! )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
DateTime 
? 
	BirthDate "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
Language 
Language  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string  
DriversLicenseNumber *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
string 
DriversLicenseType (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
DateTime 
? #
StartDateDriversLicense 0
{1 2
get3 6
;6 7
set8 ;
;; <
}= >
public 
DateTime 
? !
EndDateDriversLicense .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
public 
string 
Gender 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
Title 
{ 
get !
;! "
set# &
;& '
}( )
public 
byte 
[ 
] 
Picture 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
} 
} Ω
zD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\FuelCardModels\ReturnModels\DriverReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
FuelCardModels *
.* +
ReturnModels+ 7
{ 
public 

class 
DriverReturnModel "
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
PersonReturnModel  
Person! '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public		 
DateTime		 
	StartDate		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
public

 
DateTime

 
?

 
EndDate

  
{

! "
get

# &
;

& '
set

( +
;

+ ,
}

- .
} 
} ß
|D:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\FuelCardModels\ReturnModels\FuelCardReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
FuelCardModels *
.* +
ReturnModels+ 7
{ 
public 

class 
FuelCardReturnModel $
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public

 
DriverReturnModel

  
Driver

! '
{

( )
get

* -
;

- .
set

/ 2
;

2 3
}

4 5
public 
VehicleReturnModel !
Vehicle" )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
Company 
Company 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
DateTime 
	StartDate !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 
? 
EndDate  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
bool 
	IsBlocked 
{ 
get  #
;# $
set% (
;( )
}* +
public 
DateTime 
? 
BlockingDate %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
BlockingReason $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
string 
PinCode 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
Number 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} Ä
zD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\FuelCardModels\ReturnModels\PersonReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
FuelCardModels *
.* +
ReturnModels+ 7
{ 
public 

class 
PersonReturnModel "
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public		 
string		 
	Firstname		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
public

 
string

 
Lastname

 
{

  
get

! $
;

$ %
set

& )
;

) *
}

+ ,
public 
DateTime 
? 
	BirthDate "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
Language 
Language  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string  
DriversLicenseNumber *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
string 
DriversLicenseType (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
DateTime 
? #
StartDateDriversLicense 0
{1 2
get3 6
;6 7
set8 ;
;; <
}= >
public 
DateTime 
? !
EndDateDriversLicense .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
public 
string 
Gender 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
Title 
{ 
get !
;! "
set# &
;& '
}( )
public 
byte 
[ 
] 
Picture 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} ”
WD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\IModelBase.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
{ 
public 

	interface 

IModelBase 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
} 
} Á
fD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\RecordModels\CompanyModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
RecordModels (
{ 
public 

class 
CompanyModel 
: 

IModelBase  *
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public		 
string		 
Description		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
public

 
string

 
	Reference

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
public 
bool 
? 

IsInternal 
{  !
get" %
;% &
set' *
;* +
}, -
public 
bool 
? 
IsActive 
{ 
get  #
;# $
set% (
;( )
}* +
public 
string 
NonActiveRemark %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
VAT 
{ 
get 
;  
set! $
;$ %
}& '
public 
string 
AccountNumber #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
} 
} Ã
jD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\RecordModels\CorporationModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
RecordModels (
{ 
public 

class 
CorporationModel !
:" #

IModelBase$ .
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public

 
string

 
Abbreviation

 "
{

# $
get

% (
;

( )
set

* -
;

- .
}

/ 0
[ 	
Required	 
] 
public 
int 
? 
	CompanyId (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
DateTime 
	StartDate !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 
? 
EndDate  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
} 
} ı	
mD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\RecordModels\CostAllocationModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
RecordModels (
{ 
public 

class 
CostAllocationModel $
:% &

IModelBase' 1
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public

 
string

 
Abbreviation

 "
{

# $
get

% (
;

( )
set

* -
;

- .
}

/ 0
public 
DateTime 
	StartDate !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 
? 
EndDate  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
} 
} ª
eD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\RecordModels\RecordModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
RecordModels (
{ 
public 

class 
RecordModel 
: 

IModelBase )
{ 
[		 	
Required			 
]		 
public		 
int		 
?		 

FuelCardId		 )
{		* +
get		, /
;		/ 0
set		1 4
;		4 5
}		6 7
[ 	
Required	 
] 
public 
int 
? 
CorporationId ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
[ 	
Required	 
] 
public 
int 
? 
CostAllocationId /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
public 
Term 
Term 
{ 
get 
; 
set  #
;# $
}% &
public 
DateTime 
	StartDate !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 
EndDate 
{  !
get" %
;% &
set' *
;* +
}, -
public 
Usage 
Usage 
{ 
get  
;  !
set" %
;% &
}' (
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
} 
} Œ
yD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\RecordModels\ReturnModels\CompanyReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
RecordModels (
.( )
ReturnModels) 5
{ 
public 

class 
CompanyReturnModel #
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Description !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
	Reference 
{  !
get" %
;% &
set' *
;* +
}, -
public		 
bool		 
?		 

IsInternal		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
public

 
bool

 
?

 
IsActive

 
{

 
get

  #
;

# $
set

% (
;

( )
}

* +
public 
string 
NonActiveRemark %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
VAT 
{ 
get 
;  
set! $
;$ %
}& '
public 
string 
AccountNumber #
{$ %
get& )
;) *
set+ .
;. /
}0 1
} 
} ˝

}D:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\RecordModels\ReturnModels\CorporationReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
RecordModels (
.( )
ReturnModels) 5
{ 
public 

class "
CorporationReturnModel '
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public		 
string		 
Abbreviation		 "
{		# $
get		% (
;		( )
set		* -
;		- .
}		/ 0
public

 
CompanyReturnModel

 !
Company

" )
{

* +
get

, /
;

/ 0
set

1 4
;

4 5
}

6 7
public 
DateTime 
	StartDate !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
DateTime 
? 
EndDate  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} ›	
ÄD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\RecordModels\ReturnModels\CostAllocationReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
RecordModels (
.( )
ReturnModels) 5
{ 
public 

class %
CostAllocationReturnModel *
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public		 
string		 
Abbreviation		 "
{		# $
get		% (
;		( )
set		* -
;		- .
}		/ 0
public

 
DateTime

 
	StartDate

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 
DateTime 
? 
EndDate  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} ﬁ
xD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\RecordModels\ReturnModels\RecordReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
RecordModels (
.( )
ReturnModels) 5
{ 
public 

class 
RecordReturnModel "
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
public

 
FuelCardReturnModel

 "
FuelCard

# +
{

, -
get

. 1
;

1 2
set

3 6
;

6 7
}

8 9
public "
CorporationReturnModel %
Corporation& 1
{2 3
get4 7
;7 8
set9 <
;< =
}> ?
public %
CostAllocationReturnModel (
CostAllocation) 7
{8 9
get: =
;= >
set? B
;B C
}D E
public 
Term 
Term 
{ 
get 
; 
set  #
;# $
}% &
public 
DateTime 
? 
	StartDate "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
DateTime 
? 
EndDate  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
Usage 
Usage 
{ 
get  
;  !
set" %
;% &
}' (
} 
} ÿ	
|D:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\SupplierModels\ReturnModels\SupplierReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
SupplierModels *
.* +
ReturnModels+ 7
{ 
public 

class 
SupplierReturnModel $
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public		 
SupplierType		 
[		 
]		 
Types		 #
{		$ %
get		& )
;		) *
set		+ .
;		. /
}		0 1
public

 
bool

 
Active

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 
bool 
Internal 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} Ω	
iD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\SupplierModels\SupplierModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
SupplierModels *
{ 
public 

class 
SupplierModel 
:  

IModelBase! +
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public		 
SupplierType		 
[		 
]		 
Types		 #
{		$ %
get		& )
;		) *
set		+ .
;		. /
}		0 1
public

 
bool

 
Active

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 
bool 
Internal 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} ¯
eD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\BrandModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
{ 
public 

class 

BrandModel 
: 

IModelBase (
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
int 
[ 
] 
InteriorColorIds %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public		 
int		 
[		 
]		 
ExteriorColorIds		 %
{		& '
get		( +
;		+ ,
set		- 0
;		0 1
}		2 3
public

 
int

 
Id

 
{

 
get

 
;

 
set

  
;

  !
}

" #
} 
} Ä
hD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\CategoryModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
{ 
public 

class 
CategoryModel 
:  

IModelBase! +
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
}		 
}

 ‰

gD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\CountryModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
{ 
public 

class 
CountryModel 
: 

IModelBase  *
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public		 
string		 
Code		 
{		 
get		  
;		  !
set		" %
;		% &
}		' (
public

 
string

 
Nationality

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 
bool 
POD 
{ 
get 
; 
set "
;" #
}$ %
public 
bool 
IsActive 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
} 
} Ä
hD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\DoorTypeModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
{ 
public 

class 
DoorTypeModel 
:  

IModelBase! +
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
}		 
}

 ﬂ
jD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\EngineTypeModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
{ 
public 

class 
EngineTypeModel  
:! "

IModelBase# -
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[		 	
Required			 
]		 
public		 
int		 
?		 
BrandId		 &
{		' (
get		) ,
;		, -
set		. 1
;		1 2
}		3 4
public

 
int

 
Id

 
{

 
get

 
;

 
set

  
;

  !
}

" #
} 
} ò
hD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\FuelTypeModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
{ 
public 

class 
FuelTypeModel 
:  

IModelBase! +
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public		 
string		 
Code		 
{		 
get		  
;		  !
set		" %
;		% &
}		' (
public

 
int

 
Id

 
{

 
get

 
;

 
set

  
;

  !
}

" #
} 
} ’
eD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ModelModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
{ 
public 

class 

ModelModel 
: 

IModelBase (
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[		 	
Required			 
]		 
public		 
int		 
?		 
BrandId		 &
{		' (
get		) ,
;		, -
set		. 1
;		1 2
}		3 4
public

 
int

 
Id

 
{

 
get

 
;

 
set

  
;

  !
}

" #
} 
} ©	
xD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\BrandReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class 
BrandReturnModel !
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public		 
List		 
<		 $
InteriorColorReturnModel		 ,
>		, -
InteriorColors		. <
{		= >
get		? B
;		B C
set		D G
;		G H
}		I J
public

 
List

 
<

 $
ExteriorColorReturnModel

 ,
>

, -
ExteriorColors

. <
{

= >
get

? B
;

B C
set

D G
;

G H
}

I J
} 
} Á
{D:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\CategoryReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class 
CategoryReturnModel $
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
} 
} À

zD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\CountryReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class 
CountryReturnModel #
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Code 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Nationality !
{" #
get$ '
;' (
set) ,
;, -
}. /
public		 
bool		 
POD		 
{		 
get		 
;		 
set		 "
;		" #
}		$ %
public

 
bool

 
IsActive

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
} 
} Á
{D:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\DoorTypeReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class 
DoorTypeReturnModel $
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
} 
} é
}D:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\EngineTypeReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class !
EngineTypeReturnModel &
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
BrandReturnModel 
Brand  %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
}		 ä
ÄD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\ExteriorColorReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class $
ExteriorColorReturnModel )
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Code 
{ 
get  
;  !
set" %
;% &
}' (
} 
}		 ˇ
{D:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\FuelTypeReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class 
FuelTypeReturnModel $
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Code 
{ 
get  
;  !
set" %
;% &
}' (
} 
}		 ä
ÄD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\InteriorColorReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class $
InteriorColorReturnModel )
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Code 
{ 
get  
;  !
set" %
;% &
}' (
} 
}		 Ñ
xD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\ModelReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class 
ModelReturnModel !
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
BrandReturnModel 
Brand  %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
}		 Ñ
xD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\SerieReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class 
SerieReturnModel !
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
BrandReturnModel 
Brand  %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
}		 Ñ$
zD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\ReturnModels\VehicleReturnModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
.) *
ReturnModels* 6
{ 
public 

class 
VehicleReturnModel #
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public		 
BrandReturnModel		 
Brand		  %
{		& '
get		( +
;		+ ,
set		- 0
;		0 1
}		2 3
public

 
ModelReturnModel

 
Model

  %
{

& '
get

( +
;

+ ,
set

- 0
;

0 1
}

2 3
public 
FuelTypeReturnModel "
FuelType# +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public !
EngineTypeReturnModel $

EngineType% /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
public 
DoorTypeReturnModel "
DoorType# +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
CategoryReturnModel "
Category# +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
FuelCardReturnModel "
FuelCard# +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
public 
SerieReturnModel 
Serie  %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
int 
? 
Volume 
{ 
get  
;  !
set" %
;% &
}' (
public 
int 
? 
FiscalHP 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 
? 
Emission 
{ 
get "
;" #
set$ '
;' (
}) *
public 
bool 
IsActive 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
LicensePlate "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
string 
Chassis 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 
? 
EngineCapacity "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
int 
? 
EnginePower 
{  !
get" %
;% &
set' *
;* +
}, -
public 
DateTime 
? 
EndDateDelivery (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
int 
? 
AverageFuel 
{  !
get" %
;% &
set' *
;* +
}, -
public 
int 
? 
	BuildYear 
{ 
get  #
;# $
set% (
;( )
}* +
public 
CountryReturnModel !
Country" )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
double 

Kilometers  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
DateTime 
RegistrationDate (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public $
ExteriorColorReturnModel '
ExteriorColor( 5
{6 7
get8 ;
;; <
set= @
;@ A
}B C
public   $
InteriorColorReturnModel   '
InteriorColor  ( 5
{  6 7
get  8 ;
;  ; <
set  = @
;  @ A
}  B C
}!! 
}"" ’
eD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\SerieModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
{ 
public 

class 

SerieModel 
: 

IModelBase (
{ 
[ 	
Required	 
] 
public 
string  
Name! %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[		 	
Required			 
]		 
public		 
int		 
?		 
BrandId		 &
{		' (
get		) ,
;		, -
set		. 1
;		1 2
}		3 4
public

 
int

 
Id

 
{

 
get

 
;

 
set

  
;

  !
}

" #
} 
} Í(
gD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Models\VehicleModels\VehicleModel.cs
	namespace 	
eMenka
 
. 
API 
. 
Models 
. 
VehicleModels )
{ 
public 

class 
VehicleModel 
: 

IModelBase  *
{ 
[ 	
Required	 
] 
public 
int 
? 
BrandId &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
[		 	
Required			 
]		 
public		 
int		 
?		 
ModelId		 &
{		' (
get		) ,
;		, -
set		. 1
;		1 2
}		3 4
[

 	
Required

	 
]

 
public

 
int

 
?

 

FuelTypeId

 )
{

* +
get

, /
;

/ 0
set

1 4
;

4 5
}

6 7
[ 	
Required	 
] 
public 
int 
? 
EngineTypeId +
{, -
get. 1
;1 2
set3 6
;6 7
}8 9
[ 	
Required	 
] 
public 
int 
? 

DoorTypeId )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
public 
int 
? 

FuelCardId 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
] 
public 
int 
? 
SeriesId '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[ 	
Required	 
] 
public 
int 
? 
Volume %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
Required	 
] 
public 
int 
? 
FiscalHP '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[ 	
Required	 
] 
public 
int 
? 
Emission '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[ 	
Required	 
] 
public 
bool 
IsActive '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[ 	
Required	 
] 
public 
int 
? 

CategoryId )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
[ 	
Required	 
] 
public 
string  
LicensePlate! -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
[ 	
Required	 
] 
public 
string  
Chassis! (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
int 
? 
EngineCapacity "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
int 
EnginePower 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
DateTime 
? 
EndDateDelivery (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
int 
? 
AverageFuel 
{  !
get" %
;% &
set' *
;* +
}, -
public 
int 
? 
	CountryId 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 
? 
	BuildYear 
{ 
get  #
;# $
set% (
;( )
}* +
public 
double 

Kilometers  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
DateTime 
RegistrationDate (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
public 
int 
ExteriorColorId "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
int 
InteriorColorId "
{# $
get% (
;( )
set* -
;- .
}/ 0
public   
int   
Id   
{   
get   
;   
set    
;    !
}  " #
}!! 
}"" ˜

MD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Program.cs
	namespace 	
eMenka
 
. 
API 
{ 
public 

static 
class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{		 	
CreateHostBuilder

 
(

 
args

 "
)

" #
.

# $
Build

$ )
(

) *
)

* +
.

+ ,
Run

, /
(

/ 0
)

0 1
;

1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
{ 	
return 
Host 
.  
CreateDefaultBuilder ,
(, -
args- 1
)1 2
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{8 9

webBuilder: D
.D E

UseStartupE O
<O P
StartupP W
>W X
(X Y
)Y Z
;Z [
}\ ]
)] ^
;^ _
} 	
} 
} †@
MD:\pxl\workspace_project\emenka20\eMenka\BackEnd\eMenka\eMenka.API\Startup.cs
	namespace 	
eMenka
 
. 
API 
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services 
. 
AddControllers #
(# $
)$ %
.% &
AddNewtonsoftJson& 7
(7 8
o8 9
=>: <
{ 
o 
. 
SerializerSettings $
.$ %!
ReferenceLoopHandling% :
=; <!
ReferenceLoopHandling= R
.R S
IgnoreS Y
;Y Z
} 
) 
; 
services 
. 
AddCors 
( 
options $
=>% '
{ 
options 
. 
	AddPolicy !
(! "
$str" :
,: ;
builder   
=>   
{!! 
builder"" 
.""  
WithOrigins""  +
(""+ ,
$str"", /
)""/ 0
;""0 1
builder## 
.##  
AllowAnyHeader##  .
(##. /
)##/ 0
;##0 1
builder$$ 
.$$  
AllowAnyMethod$$  .
($$. /
)$$/ 0
;$$0 1
}%% 
)%% 
;%% 
}&& 
)&& 
;&& 
services'' 
.'' 
	AddScoped'' 
('' 
typeof'' %
(''% &
IGenericRepository''& 8
<''8 9
>''9 :
)'': ;
,''; <
typeof''= C
(''C D
GenericRepository''D U
<''U V
>''V W
)''W X
)''X Y
;''Y Z
services(( 
.(( 
	AddScoped(( 
<(( 
IVehicleRepository(( 1
,((1 2
VehicleRepository((3 D
>((D E
(((E F
)((F G
;((G H
services)) 
.)) 
	AddScoped)) 
<)) 
IBrandRepository)) /
,))/ 0
BrandRepository))1 @
>))@ A
())A B
)))B C
;))C D
services** 
.** 
	AddScoped** 
<** 
IModelRepository** /
,**/ 0
ModelRepository**1 @
>**@ A
(**A B
)**B C
;**C D
services++ 
.++ 
	AddScoped++ 
<++ 
ISerieRepository++ /
,++/ 0
SerieRepository++1 @
>++@ A
(++A B
)++B C
;++C D
services,, 
.,, 
	AddScoped,, 
<,, 
IDoorTypeRepository,, 2
,,,2 3
DoorTypeRepository,,4 F
>,,F G
(,,G H
),,H I
;,,I J
services-- 
.-- 
	AddScoped-- 
<-- 
IFuelTypeRepository-- 2
,--2 3
FuelTypeRepository--4 F
>--F G
(--G H
)--H I
;--I J
services.. 
... 
	AddScoped.. 
<.. !
IEngineTypeRepository.. 4
,..4 5 
EngineTypeRepository..6 J
>..J K
(..K L
)..L M
;..M N
services// 
.// 
	AddScoped// 
<// 
ICategoryRepository// 2
,//2 3
CategoryRepository//4 F
>//F G
(//G H
)//H I
;//I J
services00 
.00 
	AddScoped00 
<00 
IRecordRepository00 0
,000 1
RecordRepository002 B
>00B C
(00C D
)00D E
;00E F
services11 
.11 
	AddScoped11 
<11 
ICompanyRepository11 1
,111 2
CompanyRepository113 D
>11D E
(11E F
)11F G
;11G H
services22 
.22 
	AddScoped22 
<22 
IFuelCardRepository22 2
,222 3
FuelCardRepository224 F
>22F G
(22G H
)22H I
;22I J
services33 
.33 
	AddScoped33 
<33 %
ICostAllocationRepository33 8
,338 9$
CostAllocationRepository33: R
>33R S
(33S T
)33T U
;33U V
services44 
.44 
	AddScoped44 
<44 "
ICorporationRepository44 5
,445 6!
CorporationRepository447 L
>44L M
(44M N
)44N O
;44O P
services55 
.55 
	AddScoped55 
<55 
IDriverRepository55 0
,550 1
DriverRepository552 B
>55B C
(55C D
)55D E
;55E F
services66 
.66 
	AddScoped66 
<66 
IPersonRepository66 0
,660 1
PersonRepository662 B
>66B C
(66C D
)66D E
;66E F
services77 
.77 
	AddScoped77 
<77 $
IExteriorColorRepository77 7
,777 8#
ExteriorColorRepository779 P
>77P Q
(77Q R
)77R S
;77S T
services88 
.88 
	AddScoped88 
<88 $
IInteriorColorRepository88 7
,887 8#
InteriorColorRepository889 P
>88P Q
(88Q R
)88R S
;88S T
services99 
.99 
	AddScoped99 
<99 
ICountryRepository99 1
,991 2
CountryRepository993 D
>99D E
(99E F
)99F G
;99G H
services:: 
.:: 
	AddScoped:: 
<:: 
ISupplierRepository:: 2
,::2 3
SupplierRepository::4 F
>::F G
(::G H
)::H I
;::I J
services<< 
.<< 
AddDbContext<< !
<<<! "
EfenkaContext<<" /
><</ 0
(<<0 1
options<<1 8
=><<9 ;
{== 
options>> 
.>> 
UseSqlServer>> $
(>>$ %
Configuration>>% 2
.>>2 3
GetConnectionString>>3 F
(>>F G
$str>>G O
)>>O P
)>>P Q
;>>Q R
options?? 
.?? &
EnableSensitiveDataLogging?? 2
(??2 3
)??3 4
;??4 5
}@@ 
)@@ 
;@@ 
}AA 	
publicDD 
voidDD 
	ConfigureDD 
(DD 
IApplicationBuilderDD 1
appDD2 5
,DD5 6
IWebHostEnvironmentDD7 J
envDDK N
)DDN O
{EE 	
ifFF 
(FF 
envFF 
.FF 
IsDevelopmentFF !
(FF! "
)FF" #
)FF# $
appFF% (
.FF( )%
UseDeveloperExceptionPageFF) B
(FFB C
)FFC D
;FFD E
appHH 
.HH 
UseHttpsRedirectionHH #
(HH# $
)HH$ %
;HH% &
appJJ 
.JJ 

UseRoutingJJ 
(JJ 
)JJ 
;JJ 
appLL 
.LL 
UseAuthorizationLL  
(LL  !
)LL! "
;LL" #
appMM 
.MM 
UseCorsMM 
(MM 
$strMM 0
)MM0 1
;MM1 2
appOO 
.OO 
UseEndpointsOO 
(OO 
	endpointsOO &
=>OO' )
{OO* +
	endpointsOO, 5
.OO5 6
MapControllersOO6 D
(OOD E
)OOE F
;OOF G
}OOH I
)OOI J
;OOJ K
}PP 	
}QQ 
}RR 