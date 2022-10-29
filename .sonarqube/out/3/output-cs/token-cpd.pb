¿
YD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Config\AppSetting.cs
	namespace 	
WebPulsaciones
 
. 
Config 
{ 
public 

class 

AppSetting 
{ 
public		 
string		 
Secret		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
}

 
} ◊
kD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\AdministradorController.cs
	namespace		 	
Proyectopweb		
 
.		 
Controllers		 "
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
] 
[ 
ApiController 
] 
public 

class #
AdministradorController (
:) *
ControllerBase+ 9
{ 
private 
readonly  
AdministradorService - 
administradorService. B
;B C
public #
AdministradorController &
(& '
ConsultorioContext' 9
context: A
)A B
{ 	
this 
.  
administradorService %
=& '
new( + 
AdministradorService, @
(@ A
contextA H
)H I
;I J
} 	
[ 	
HttpPost	 
] 
public 
ActionResult 
< "
AdministradorViewModel 2
>2 3
Guardar4 ;
(; <#
AdministradorInputModel< S#
administradorInputModelT k
)k l
{ 	
var 
administrador 
= 
MapearAdministrador  3
(3 4#
administradorInputModel4 K
)K L
;L M
var 
	respuesta 
= 
this  
.  ! 
administradorService! 5
.5 6
Guardar6 =
(= >
administrador> K
)K L
;L M
if 
( 
	respuesta 
. 
Error 
==  "
true# '
)' (
{ 
return 

BadRequest !
(! "
	respuesta" +
.+ ,
Mensaje, 3
)3 4
;4 5
}   
return!! 
Ok!! 
(!! 
	respuesta!! 
.!!  
administrador!!  -
)!!- .
;!!. /
}"" 	
[$$ 	
HttpGet$$	 
]$$ 
public%% 
IEnumerable%% 
<%% "
AdministradorViewModel%% 1
>%%1 2
Gets%%3 7
(%%7 8
)%%8 9
{&& 	
var'' 
administradores'' 
=''  !
this''" &
.''& ' 
administradorService''' ;
.''; <,
 ConsultarTodosLosAdministradores''< \
(''\ ]
)''] ^
.''^ _
Select''_ e
(''e f
p''f g
=>''h j
new''k n#
AdministradorViewModel	''o Ö
(
''Ö Ü
p
''Ü á
)
''á à
)
''à â
;
''â ä
return(( 
administradores(( "
;((" #
}** 	
private,, 
Administrador,, 
MapearAdministrador,, 1
(,,1 2#
AdministradorInputModel,,2 I#
administradorInputModel,,J a
),,a b
{-- 	
var.. 
administrador.. 
=.. 
new..  #
Administrador..$ 1
(..1 2
)..2 3
;..3 4
{// 
administrador00 
.00 
nombreUsuario00 +
=00, -#
administradorInputModel00. E
.00E F
nombreUsuario00F S
;00S T
administrador11 
.11 

contrasena11 (
=11) *#
administradorInputModel11+ B
.11B C
contrase√±a11C M
;11M N
administrador22 
.22 
tipoUsuario22 )
=22* +#
administradorInputModel22, C
.22C D
tipoUsuario22D O
;22O P
}44 
return55 
administrador55  
;55  !
}66 	
}99 
}:: ´=
dD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\AgendaController.cs
	namespace 	
Proyectopweb
 
. 
Controllers "
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
AgendaController !
:" #
ControllerBase$ 2
{ 
private 
readonly 
AgendaService &
_agendaService' 5
;5 6
public 
AgendaController 
(  
ConsultorioContext  2
context3 :
): ;
{ 	
_agendaService 
= 
new  
AgendaService! .
(. /
context/ 6
)6 7
;7 8
} 	
[ 	
HttpPost	 
] 
public 
ActionResult 
< 
AgendaViewModel +
>+ ,
Guardar- 4
(4 5
AgendaInputModel5 E
AgendaInputModelF V
)V W
{ 	
var 
agenda 
= 
MapearaAgenda &
(& '
AgendaInputModel' 7
)7 8
;8 9
var 
	respuesta 
= 
_agendaService *
.* +
Guardar+ 2
(2 3
agenda3 9
)9 :
;: ;
if   
(   
	respuesta   
.   
IsError   !
==  " $
true  % )
)  ) *
{!! 
return"" 

BadRequest"" !
(""! "
	respuesta""" +
.""+ ,
Mensaje"", 3
)""3 4
;""4 5
}## 
return$$ 
Ok$$ 
($$ 
	respuesta$$ 
.$$  
Agenda$$  &
)$$& '
;$$' (
}%% 	
['' 	
HttpGet''	 
]'' 
public(( 
ActionResult(( 
<(( 
IEnumerable(( '
<((' (
AgendaViewModel((( 7
>((7 8
>((8 9
Gets((: >
(((> ?
)((? @
{)) 	
var** 
	respuesta** 
=** 
_agendaService** *
.*** +
	Consultar**+ 4
(**4 5
)**5 6
;**6 7
if++ 
(++ 
	respuesta++ 
.++ 
Error++ 
==++  "
true++# '
)++' (
{,, 
return-- 

BadRequest-- !
(--! "
	respuesta--" +
.--+ ,
Mensaje--, 3
)--3 4
;--4 5
}.. 
return// 
Ok// 
(// 
	respuesta// 
.//  
Agendas//  '
.//' (
Select//( .
(//. /
p/// 0
=>//1 3
new//4 7
AgendaViewModel//8 G
(//G H
p//H I
)//I J
)//J K
)//K L
;//L M
}00 	
[11 	
HttpGet11	 
(11 
$str11 
)11 
]11 
public22 
List22 
<22 
string22 
>22 
Get22 
(22  
)22  !
{33 	
var44 
	respuesta44 
=44 
_agendaService44 *
.44* +

nuevaLista44+ 5
(445 6
)446 7
;447 8
return66 
	respuesta66 
;66 
}77 	
[88 	
HttpGet88	 
(88 
$str88 
)88 
]88 
public99 
ActionResult99 
<99 
string99 "
>99" #
	getAgenda99$ -
(99- .
DateTime99. 6
fecha997 <
)99< =
{:: 	
var;; 
	respuesta;; 
=;; 
_agendaService;; *
.;;* +!
buscarFechaDisponible;;+ @
(;;@ A
fecha;;A F
);;F G
;;;G H
if<< 
(<< 
	respuesta<< 
.<< 
Error<< 
==<<  "
true<<# '
)<<' (
{== 
return>> 

BadRequest>> !
(>>! "
	respuesta>>" +
.>>+ ,
Mensaje>>, 3
)>>3 4
;>>4 5
}?? 
return@@ 
Ok@@ 
(@@ 
	respuesta@@ 
.@@  
listaAgendas@@  ,
.@@, -
Select@@- 3
(@@3 4
p@@4 5
=>@@6 8
new@@9 <
string@@= C
(@@C D
p@@D E
)@@E F
)@@F G
)@@G H
;@@H I
}BB 	
[CC 	
HttpGetCC	 
(CC 
$strCC 
)CC 
]CC  
publicDD 
ListDD 
<DD 
stringDD 
>DD 

getTerapiaDD &
(DD& '
stringDD' -
nombrePsicologoDD. =
)DD= >
{EE 	
varGG 
	respuestaGG 
=GG 
_agendaServiceGG *
.GG* +
buscarTerapiaGG+ 8
(GG8 9
nombrePsicologoGG9 H
)GGH I
;GGI J
returnII 
	respuestaII 
;II 
}KK 	
[LL 	
HttpGetLL	 
(LL 
$strLL "
)LL" #
]LL# $
publicMM 
ListMM 
<MM 
stringMM 
>MM 
getMM 
(MM  
stringMM  &
horaMM' +
)MM+ ,
{NN 	
varOO 
	respuestaOO 
=OO 
_agendaServiceOO *
.OO* +
buscarPsicologoOO+ :
(OO: ;
horaOO; ?
)OO? @
;OO@ A
returnPP 
	respuestaPP 
;PP 
}RR 	
[SS 	
HttpGetSS	 
(SS 
$strSS 
)SS 
]SS 
publicTT 
ActionResultTT 
<TT 
AgendaViewModelTT +
>TT+ ,
GetsTT- 1
(TT1 2
stringTT2 8
idTT9 ;
)TT; <
{UU 	
varVV 
	respuestaVV 
=VV 
_agendaServiceVV *
.VV* +
BuscarVV+ 1
(VV1 2
idVV2 4
)VV4 5
;VV5 6
ifWW 
(WW 
	respuestaWW 
.WW 
IsErrorWW !
==WW" $
trueWW% )
)WW) *
{XX 
returnYY 

BadRequestYY !
(YY! "
	respuestaYY" +
.YY+ ,
MensajeYY, 3
)YY3 4
;YY4 5
}ZZ 
return[[ 
Ok[[ 
([[ 
	respuesta[[ 
.[[  
Agenda[[  &
)[[& '
;[[' (
}\\ 	
private]] 
Agenda]] 
MapearaAgenda]] $
(]]$ %
AgendaInputModel]]% 5
AgendaInputModel]]6 F
)]]F G
{^^ 	
varaa 
agendaaa 
=aa 
newaa 
Agendaaa #
{bb 
idPsicologocc 
=cc 
AgendaInputModelcc .
.cc. /
idPsicologocc/ :
,cc: ;
fechaDeseadadd 
=dd 
AgendaInputModeldd /
.dd/ 0
fechaDeseadadd0 <
,dd< =
horaCitaee 
=ee 
AgendaInputModelee +
.ee+ ,
horaCitaee, 4
,ee4 5
	psicologoff 
=ff 
newff 
	Psicologoff  )
{gg 
identificacionhh 
=hh  
AgendaInputModelhh! 1
.hh1 2
idPsicologohh2 =
,hh= >
}jj 
,jj 
}mm 
;mm 
returnoo 
agendaoo 
;oo 
}pp 	
}ss 
}tt á/
bD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\CitaController.cs
	namespace		 	
Proyectopweb		
 
.		 
Controllers		 "
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
] 
[ 
ApiController 
] 
public 

class 
CitaController 
:  !
ControllerBase" 0
{ 
private 
readonly 
CitaService $
_citaService% 1
;1 2
private 
readonly 
PsicologoService )
_psicologoService* ;
;; <
public 
CitaController 
( 
ConsultorioContext 0
context1 8
)8 9
{ 	
_citaService 
= 
new 
CitaService *
(* +
context+ 2
)2 3
;3 4
_psicologoService 
= 
new  #
PsicologoService$ 4
(4 5
context5 <
)< =
;= >
} 	
[ 	
HttpPost	 
] 
public 
ActionResult 
< 
CitaViewModel )
>) *
Guardar+ 2
(2 3
CitaInputModel3 A
citaInputModelB P
)P Q
{ 	
var 
cita 
= 
MapearaCitas #
(# $
citaInputModel$ 2
)2 3
;3 4
var 
	respuesta 
= 
_citaService (
.( )
Guardar) 0
(0 1
cita1 5
)5 6
;6 7
if 
( 
	respuesta 
. 
IsError !
==" $
true% )
)) *
{ 
return   

BadRequest   !
(  ! "
	respuesta  " +
.  + ,
Mensaje  , 3
)  3 4
;  4 5
}!! 
return"" 
Ok"" 
("" 
	respuesta"" 
.""  
Cita""  $
)""$ %
;""% &
}## 	
[%% 	
HttpGet%%	 
]%% 
public&& 
ActionResult&& 
<&& 
IEnumerable&& '
<&&' (
CitaViewModel&&( 5
>&&5 6
>&&6 7
Gets&&8 <
(&&< =
)&&= >
{'' 	
var(( 
	respuesta(( 
=(( 
_citaService(( (
.((( )
	Consultar(() 2
(((2 3
)((3 4
;((4 5
if)) 
()) 
	respuesta)) 
.)) 
Error)) 
==))  "
true))# '
)))' (
{** 
return++ 

BadRequest++ !
(++! "
	respuesta++" +
.+++ ,
Mensaje++, 3
)++3 4
;++4 5
},, 
return-- 
Ok-- 
(-- 
	respuesta-- 
.--  
Citas--  %
.--% &
Select--& ,
(--, -
p--- .
=>--/ 1
new--2 5
CitaViewModel--6 C
(--C D
p--D E
)--E F
)--F G
)--G H
;--H I
}.. 	
[// 	
HttpGet//	 
(// 
$str// !
)//! "
]//" #
public00 
string00 
GetNombrePaciente00 '
(00' (
string00( .
id00/ 1
)001 2
{11 	
var22 
	respuesta22 
=22 
_citaService22 (
.22( )
nombrePaciente22) 7
(227 8
id228 :
)22: ;
;22; <
return44 
	respuesta44 
;44 
}55 	
[66 	
HttpGet66	 
(66 
$str66 
)66 
]66 
public77 
ActionResult77 
<77 
CitaViewModel77 )
>77) *
Gets77+ /
(77/ 0
string770 6
id777 9
)779 :
{88 	
var99 
	respuesta99 
=99 
_citaService99 (
.99( )
Buscar99) /
(99/ 0
id990 2
)992 3
;993 4
if:: 
(:: 
	respuesta:: 
.:: 
IsError:: !
==::" $
true::% )
)::) *
{;; 
return<< 

BadRequest<< !
(<<! "
	respuesta<<" +
.<<+ ,
Mensaje<<, 3
)<<3 4
;<<4 5
}== 
return>> 
Ok>> 
(>> 
	respuesta>> 
.>>  
Cita>>  $
)>>$ %
;>>% &
}?? 	
privateAA 
CitaAA 
MapearaCitasAA !
(AA! "
CitaInputModelAA" 0
citaInputModelAA1 ?
)AA? @
{BB 	
varCC 
citaCC 
=CC 
newCC 
CitaCC 
{CC  

idPacienteDD 
=DD 
citaInputModelDD '
.DD' (

idPacienteDD( 2
,DD2 3
fechaDeseadaEE 
=EE 
citaInputModelEE )
.EE) *
fechaDeseadaEE* 6
,EE6 7
nombreFF 
=FF 
citaInputModelFF !
.FF! "
nombreFF" (
,FF( )
horaCitaGG 
=GG 
citaInputModelGG #
.GG# $
horaCitaGG$ ,
,GG, -
estadoHH 
=HH 
citaInputModelHH !
.HH! "
estadoHH" (
,HH( )
pacienteII 
=II 
newII 
PacienteII !
{II! "
identificacionJJ 
=JJ 
citaInputModelJJ -
.JJ- .

idPacienteJJ. 8
,JJ8 9
}LL 
,LL 
}MM 
;MM 
returnOO 
citaOO 
;OO 
}PP 	
}QQ 
}RR ª!
hD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\EnfermedadController.cs
	namespace		 	
Proyectopweb		
 
.		 
Controllers		 "
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
] 
[ 
ApiController 
] 
public 

class  
EnfermedadController %
:& '
ControllerBase( 6
{ 
private 
readonly 
EnfermedadService * 
_enfermedadgoService+ ?
;? @
public  
EnfermedadController #
(# $
ConsultorioContext$ 6
context7 >
)> ?
{ 	 
_enfermedadgoService  
=! "
new# &
EnfermedadService' 8
(8 9
context9 @
)@ A
;A B
} 	
[ 	
HttpGet	 
] 
public 
ActionResult 
< 
List  
<  !
EnfermedadViewModel! 4
>4 5
>5 6
GetConsulta7 B
(B C
)C D
{ 	
var 
	respuesta 
=  
_enfermedadgoService 0
.0 1
	Consultar1 :
(: ;
); <
;< =
if 
( 
	respuesta 
. 
Error 
==  "
true# '
)' (
{ 
return 

BadRequest !
(! "
	respuesta" +
.+ ,
Mensaje, 3
)3 4
;4 5
} 
return 
Ok 
( 
	respuesta 
.  
Enfermedades  ,
., -
Select- 3
(3 4
p4 5
=>6 8
new9 <
EnfermedadViewModel= P
(P Q
pQ R
)R S
)S T
)T U
;U V
}   	
["" 	
HttpGet""	 
("" 
$str"" 
)"" 
]"" 
public## 
List## 
<## 
string## 
>## 
Gets##  
(##  !
)##! "
{$$ 	
var%% 
	respuesta%% 
=%%  
_enfermedadgoService%% 0
.%%0 1
ListaCodigo3%%1 =
(%%= >
)%%> ?
;%%? @
return'' 
	respuesta'' 
;'' 
}(( 	
[))	 

HttpGet))
 
()) 
$str)) 
))) 
])) 
public** 
List** 
<** 
string** 
>** 
	GetCodigo** %
(**% &
string**& ,
codigo3**- 4
)**4 5
{++ 	
var,, 
	respuesta,, 
=,,  
_enfermedadgoService,, 0
.,,0 1
ListaCodigo4,,1 =
(,,= >
codigo3,,> E
),,E F
;,,F G
return.. 
	respuesta.. 
;.. 
}// 	
[00 	
HttpGet00	 
(00 
$str00 $
)00$ %
]00% &
public11 
List11 
<11 
string11 
>11 
Gets11  
(11  !
string11! '
codigo311( /
)11/ 0
{22 	
var33 
	respuesta33 
=33  
_enfermedadgoService33 0
.330 1
ListaDescripcion3331 B
(33B C
codigo333C J
)33J K
;33K L
return55 
	respuesta55 
;55 
}66 	
[88 	
HttpGet88	 
(88 
$str88 $
)88$ %
]88% &
public99 
List99 
<99 
string99 
>99 
GetLis99 "
(99" #
string99# )
codigo499* 1
)991 2
{:: 	
var;; 
	respuesta;; 
=;;  
_enfermedadgoService;; 0
.;;0 1
ListaDescripcion4;;1 B
(;;B C
codigo4;;C J
);;J K
;;;K L
return== 
	respuesta== 
;== 
}>> 	
}?? 
}@@ Ò
aD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\EpsController.cs
	namespace 	
Proyectopweb
 
. 
Controllers "
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
EpsController 
:  
ControllerBase! /
{ 
private 
readonly 

EpsService #
_EpsService$ /
;/ 0
private 
readonly 
IHubContext $
<$ %
	SignalHub% .
>. /
_hubContext0 ;
;; <
public 
EpsController 
( 
ConsultorioContext /
context0 7
,7 8
IHubContext9 D
<D E
	SignalHubE N
>N O

hubContextP Z
)Z [
{ 	
_hubContext 
= 

hubContext $
;$ %
_EpsService 
= 
new 

EpsService (
(( )
context) 0
)0 1
;1 2
} 	
[ 	
AllowAnonymous	 
] 
[ 	
HttpGet	 
] 
public   
List   
<   
string   
>   
GetList   #
(  # $
)  $ %
{!! 	
var"" 
	respuesta"" 
="" 
_EpsService"" '
.""' (
consultaEps""( 3
(""3 4
)""4 5
;""5 6
return$$ 
	respuesta$$ 
;$$ 
}&& 	
}44 
}55 ≈3
hD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\EvaluacionController.cs
	namespace 	
Proyectopweb
 
. 
Controllers "
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class  
EvaluacionController %
:& '
ControllerBase( 6
{ 
private 
readonly 
EvaluacionService *
_evaluacionService+ =
;= >
public  
EvaluacionController #
(# $
ConsultorioContext$ 6
context7 >
)> ?
{ 	
_evaluacionService 
=  
new! $
EvaluacionService% 6
(6 7
context7 >
)> ?
;? @
} 	
[ 	
AllowAnonymous	 
] 
[ 	
HttpPost	 
] 
public 
ActionResult 
< 
EvaluacionViewModel /
>/ 0
Guardar1 8
(8 9 
EvaluacionInputModel9 M 
evaluacionInputModelN b
)b c
{ 	
var 

evaluacion 
= 
MapearaEvaluacion .
(. / 
evaluacionInputModel/ C
)C D
;D E
var 
	respuesta 
= 
_evaluacionService .
.. /
Guardar/ 6
(6 7

evaluacion7 A
)A B
;B C
if 
( 
	respuesta 
. 
IsError !
==" $
true% )
)) *
{   
return!! 

BadRequest!! !
(!!! "
	respuesta!!" +
.!!+ ,
Mensaje!!, 3
)!!3 4
;!!4 5
}"" 
return## 
Ok## 
(## 
	respuesta## 
.##  

Evaluacion##  *
)##* +
;##+ ,
}$$ 	
[%% 	
AllowAnonymous%%	 
]%% 
[&& 	
HttpGet&&	 
]&& 
public'' 
ActionResult'' 
<'' 
IEnumerable'' '
<''' (
EvaluacionViewModel''( ;
>''; <
>''< =
Gets''> B
(''B C
)''C D
{(( 	
var)) 
	respuesta)) 
=)) 
_evaluacionService)) .
.)). /
	Consultar))/ 8
())8 9
)))9 :
;)): ;
if** 
(** 
	respuesta** 
.** 
Error** 
==**  "
true**# '
)**' (
{++ 
return,, 

BadRequest,, !
(,,! "
	respuesta,," +
.,,+ ,
Mensaje,,, 3
),,3 4
;,,4 5
}-- 
return.. 
Ok.. 
(.. 
	respuesta.. 
...  
Evaluaciones..  ,
..., -
Select..- 3
(..3 4
p..4 5
=>..6 8
new..9 <
EvaluacionViewModel..= P
(..P Q
p..Q R
)..R S
)..S T
)..T U
;..U V
}// 	
[00 	
AllowAnonymous00	 
]00 
[11 	
HttpGet11	 
(11 
$str11 
)11 
]11 
public22 
ActionResult22 
<22 
EvaluacionViewModel22 /
>22/ 0
Gets221 5
(225 6
string226 <
id22= ?
)22? @
{33 	
var44 
	respuesta44 
=44 
_evaluacionService44 .
.44. /
Buscar44/ 5
(445 6
id446 8
)448 9
;449 :
if55 
(55 
	respuesta55 
.55 
IsError55 !
==55" $
true55% )
)55) *
{66 
return77 

BadRequest77 !
(77! "
	respuesta77" +
.77+ ,
Mensaje77, 3
)773 4
;774 5
}88 
return99 
Ok99 
(99 
	respuesta99 
.99  

Evaluacion99  *
)99* +
;99+ ,
}:: 	
private<< 

Evaluacion<< 
MapearaEvaluacion<< ,
(<<, - 
EvaluacionInputModel<<- A 
evaluacionInputModel<<B V
)<<V W
{== 	
var>> 

evaluacion>> 
=>> 
new>>  

Evaluacion>>! +
{>>+ ,"
identificacionPaciente?? "
=??# $ 
evaluacionInputModel??% 9
.??9 :"
identificacionPaciente??: P
,??P Q#
identificacionPsicologo@@ #
=@@$ % 
evaluacionInputModel@@& :
.@@: ;#
identificacionPsicologo@@; R
,@@R S
diagnosticoAA 
=AA  
evaluacionInputModelAA ,
.AA, -
diagnosticoAA- 8
,AA8 9
	ocupacionBB 
=BB  
evaluacionInputModelBB ,
.BB, -
	ocupacionBB- 6
,BB6 7
consultaCC 
=CC  
evaluacionInputModelCC +
.CC+ ,
consultaCC, 4
,CC4 5
observacionDD 
=DD  
evaluacionInputModelDD .
.DD. /
observacionDD/ :
,DD: ;
pruebaEE 
=EE  
evaluacionInputModelEE )
.EE) *
pruebaEE* 0
,EE0 1
analisisFF 
=FF  
evaluacionInputModelFF +
.FF+ ,
analisisFF, 4
,FF4 5

pronosticoGG 
=GG  
evaluacionInputModelGG -
.GG- .

pronosticoGG. 8
,GG8 9
recomendacionHH 
=HH  
evaluacionInputModelHH 0
.HH0 1
recomendacionHH1 >
,HH> ?
pacienteII 
=II 
newII 
PacienteII !
{II! "
identificacionJJ 
=JJ  
evaluacionInputModelJJ 3
.JJ3 4"
identificacionPacienteJJ4 J
,JJJ K
}LL 
,LL 
	PsicologoMM 
=MM 
newMM 
	PsicologoMM #
{MM# $
identificacionNN 
=NN  
evaluacionInputModelNN 3
.NN3 4#
identificacionPsicologoNN4 K
,NNK L
}PP 
,PP 
}QQ 
;QQ 
returnSS 

evaluacionSS 
;SS 
}TT 	
}UU 
}VV ë>
fD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\PacienteController.cs
	namespace 	
Proyectopweb
 
. 
Controllers "
{ 
[ 
	Authorize 
( 
Roles 
= 
$str  
)  !
]! "
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
PacienteController #
:$ %
ControllerBase& 4
{ 
private 
readonly 
PacienteService (
_pacienteService) 9
;9 :
private 
readonly 
IHubContext $
<$ %
	SignalHub% .
>. /
_hubContext0 ;
;; <
public 
PacienteController !
(! "
ConsultorioContext" 4
context5 <
,< =
IHubContext> I
<I J
	SignalHubJ S
>S T

hubContextU _
)_ `
{ 	
_hubContext 
= 

hubContext $
;$ %
_pacienteService 
= 
new "
PacienteService# 2
(2 3
context3 :
): ;
;; <
} 	
[ 	
AllowAnonymous	 
] 
[ 	
HttpPost	 
] 
public 
async 
Task 
< 
ActionResult &
<& '
PacienteViewModel' 8
>8 9
>9 :
Post; ?
(? @
PacienteInputModel@ R
pacienteInputModelS e
)e f
{   	
var!! 
paciente!! 
=!! 
MapearaPaciente!! *
(!!* +
pacienteInputModel!!+ =
)!!= >
;!!> ?
var"" 
	respuesta"" 
="" 
_pacienteService"" ,
."", -
Guardar""- 4
(""4 5
paciente""5 =
)""= >
;""> ?
if$$ 
($$ 
	respuesta$$ 
.$$ 
Error$$ 
==$$  "
true$$# '
)$$' (
{%% 

ModelState&& 
.&& 
AddModelError&& (
(&&( )
$str&&) ;
,&&; <
	respuesta&&= F
.&&F G
Mensaje&&G N
)&&N O
;&&O P
var'' 
problemDetails'' "
=''# $
new''% ($
ValidationProblemDetails'') A
(''A B

ModelState''B L
)''L M
{(( 
Status)) 
=)) 
StatusCodes)) (
.))( )
Status400BadRequest))) <
,))< =
}** 
;** 
await++ 
_hubContext++ !
.++! "
Clients++" )
.++) *
All++* -
.++- .
	SendAsync++. 7
(++7 8
$str++8 O
,++O P
pacienteInputModel++Q c
)++c d
;++d e
return,, 

BadRequest,, !
(,,! "
problemDetails,," 0
),,0 1
;,,1 2
}-- 
return.. 
Ok.. 
(.. 
	respuesta.. 
...  
Paciente..  (
)..( )
;..) *
}// 	
[00 	
AllowAnonymous00	 
]00 
[11 	
HttpGet11	 
]11 
public22 
ActionResult22 
<22 
List22  
<22  !
PacienteViewModel22! 2
>222 3
>223 4
Gets225 9
(229 :
)22: ;
{33 	
var44 
	respuesta44 
=44 
_pacienteService44 ,
.44, -&
ConsultarTodosLosPacientes44- G
(44G H
)44H I
;44I J
if55 
(55 
	respuesta55 
.55 
Error55 
==55  "
true55# '
)55' (
{66 
return77 

BadRequest77 !
(77! "
	respuesta77" +
.77+ ,
Mensaje77, 3
)773 4
;774 5
}88 
return99 
Ok99 
(99 
	respuesta99 
.99  
	Pacientes99  )
.99) *
Select99* 0
(990 1
p991 2
=>993 5
new996 9
PacienteViewModel99: K
(99K L
p99L M
)99M N
)99N O
)99O P
;99P Q
};; 	
[<< 	
AllowAnonymous<<	 
]<< 
[== 	
HttpGet==	 
(== 
$str== 
)== 
]== 
public>> 
ActionResult>> 
<>> 
PacienteViewModel>> -
>>>- .
Gets>>/ 3
(>>3 4
string>>4 :
id>>; =
)>>= >
{?? 	
var@@ 
	respuesta@@ 
=@@ 
_pacienteService@@ ,
.@@, -
Buscar@@- 3
(@@3 4
id@@4 6
)@@6 7
;@@7 8
ifAA 
(AA 
	respuestaAA 
.AA 
IsErrorAA !
==AA" $
trueAA% )
)AA) *
{BB 
returnCC 

BadRequestCC !
(CC! "
	respuestaCC" +
.CC+ ,
MensajeCC, 3
)CC3 4
;CC4 5
}DD 
returnEE 
OkEE 
(EE 
	respuestaEE 
.EE  
PacienteEE  (
)EE( )
;EE) *
}FF 	
privateGG 
PacienteGG 
MapearaPacienteGG (
(GG( )
PacienteInputModelGG) ;
pacienteInputModelGG< N
)GGN O
{HH 	
varII 
pacienteII 
=II 
newII 
PacienteII '
(II' (
)II( )
{JJ 
tipoDocumentoKK 
=KK 
pacienteInputModelKK  2
.KK2 3
tipoDocumentoKK3 @
,KK@ A
identificacionLL 
=LL  
pacienteInputModelLL! 3
.LL3 4
identificacionLL4 B
,LLB C
nombreMM 
=MM 
pacienteInputModelMM +
.MM+ ,
nombreMM, 2
,MM2 3
apellidoNN 
=NN 
pacienteInputModelNN -
.NN- .
apellidoNN. 6
,NN6 7
fechaNacimientoOO 
=OO  !
pacienteInputModelOO" 4
.OO4 5
fechaNacimientoOO5 D
,OOD E
sexoPP 
=PP 
pacienteInputModelPP )
.PP) *
sexoPP* .
,PP. /
	direccionQQ 
=QQ 
pacienteInputModelQQ .
.QQ. /
	direccionQQ/ 8
,QQ8 9
EpsRR 
=RR 
pacienteInputModelRR (
.RR( )
EpsRR) ,
,RR, -
usuarioTT 
=TT 
newTT 
UsuarioTT #
{TT# $
tipoUsuarioUU 
=UU  
$strUU  *
,UU* +
nombreUsuarioVV !
=VV! "
pacienteInputModelVV" 4
.VV4 5
nombreUsuarioVV5 B
,VVB C

contrasenaWW 
=WW 
pacienteInputModelWW 1
.WW1 2

contrasenaWW2 <
,WW< =
correoXX 
=XX 
pacienteInputModelXX -
.XX- .
correoXX. 4
,XX4 5
estadoYY 
=YY 
$strYY 
,YY  
telefonoZZ 
=ZZ 
pacienteInputModelZZ /
.ZZ/ 0
telefonoZZ0 8
,ZZ8 9
}\\ 
}^^ 
;^^ 
paciente__ 
.__ 
calcularEdad__ !
(__! "
paciente__" *
.__* +
fechaNacimiento__+ :
)__: ;
;__; <
returnbb 
pacientebb 
;bb 
}cc 	
}dd 
}ee õA
gD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\PsicologoController.cs
	namespace 	
Proyectopweb
 
. 
Controllers "
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
PsicologoController $
:% &
ControllerBase' 5
{ 
private 
readonly 
PsicologoService )
_psicologoService* ;
;; <
private 
readonly 
IHubContext $
<$ %
	SignalHub% .
>. /
_hubContext0 ;
;; <
public 
PsicologoController "
(" #
ConsultorioContext# 5
context6 =
,= >
IHubContext> I
<I J
	SignalHubJ S
>S T

hubContextU _
)_ `
{ 	
_hubContext 
= 

hubContext #
;# $
this 
. 
_psicologoService !
=# $
new% (
PsicologoService) 9
(9 :
context: A
)A B
;B C
} 	
[ 	
AllowAnonymous	 
] 
[ 	
HttpPost	 
] 
public 
async 
Task 
< 
ActionResult &
<& '
PsicologoViewModel' 9
>9 :
>: ;
Guardar< C
(C D
PsicologoInputModelD W
psicologoInputModelX k
)k l
{   	
var!! 
	psicologo!! 
=!! 
MapearPsicologo!! +
(!!+ ,
psicologoInputModel!!, ?
)!!? @
;!!@ A
var"" 
	respuesta"" 
="" 
_psicologoService"" -
.""- .
Guardar"". 5
(""5 6
	psicologo""6 ?
)""? @
;""@ A
if$$ 
($$ 
	respuesta$$ 
.$$ 
Error$$ 
==$$  "
true$$# '
)$$' (
{%% 

ModelState&& 
.&& 
AddModelError&& (
(&&( )
$str&&) <
,&&< =
	respuesta&&> G
.&&G H
Mensaje&&H O
)&&O P
;&&P Q
var'' 
problemDetails'' "
=''# $
new''% ($
ValidationProblemDetails'') A
(''A B

ModelState''B L
)''L M
{(( 
Status)) 
=)) 
StatusCodes)) (
.))( )
Status400BadRequest))) <
,))< =
}** 
;** 
await++ 
_hubContext++ !
.++! "
Clients++" )
.++) *
All++* -
.++- .
	SendAsync++. 7
(++7 8
$str++8 O
,++O P
psicologoInputModel++P c
)++c d
;++d e
return,, 

BadRequest,, !
(,,! "
problemDetails,," 0
),,0 1
;,,1 2
}-- 
return.. 
Ok.. 
(.. 
	respuesta.. 
...  
	psicologo..  )
)..) *
;..* +
}// 	
[11 	
AllowAnonymous11	 
]11 
[22	 

HttpGet22
 
]22 
public33 
ActionResult33 
<33 
IEnumerable33 %
<33% &
PsicologoViewModel33& 8
>338 9
>339 :
Gets33; ?
(33? @
)33@ A
{44 
var55 
	respuesta55 
=55 
_psicologoService55 -
.55- .
	Consultar55. 7
(557 8
)558 9
;559 :
if66 
(66 
	respuesta66 
.66 
Error66 
==66  "
true66# '
)66' (
{77 
return88 

BadRequest88 !
(88! "
	respuesta88" +
.88+ ,
Mensaje88, 3
)883 4
;884 5
}99 
return:: 
Ok:: 
(:: 
	respuesta:: 
.::  
	Psicologo::  )
.::) *
Select::* 0
(::0 1
p::1 2
=>::3 5
new::6 9
PsicologoViewModel::: L
(::L M
p::M N
)::N O
)::O P
)::P Q
;::Q R
};; 
[<< 
AllowAnonymous<< 
]<< 
[== 	
HttpGet==	 
(== 
$str== 
)== 
]== 
public>> 
ActionResult>> 
<>> 
PsicologoViewModel>> .
>>>. /
Gets>>0 4
(>>4 5
string>>5 ;
id>>< >
)>>> ?
{?? 	
var@@ 
	respuesta@@ 
=@@ 
_psicologoService@@ ,
.@@, -
Buscar@@- 3
(@@3 4
id@@4 6
)@@6 7
;@@7 8
ifAA 
(AA 
	respuestaAA 
.AA 
IsErrorAA !
==AA" $
trueAA% )
)AA) *
{BB 
returnCC 

BadRequestCC !
(CC! "
	respuestaCC" +
.CC+ ,
MensajeCC, 3
)CC3 4
;CC4 5
}DD 
returnEE 
OkEE 
(EE 
	respuestaEE 
.EE  
	PsicologoEE  )
)EE) *
;EE* +
}FF 	
privateGG 
	PsicologoGG 
MapearPsicologoGG )
(GG) *
PsicologoInputModelGG* =
PsicologoInputModelGG> Q
)GGQ R
{HH 	
varII 
	psicologoII 
=II 
newII 
	PsicologoII  )
(II) *
)II* +
{II+ ,
tipoDocumentoJJ 
=JJ 
PsicologoInputModelJJ -
.JJ- .
tipoDocumentoJJ. ;
,JJ; <
identificacionKK 
=KK 
PsicologoInputModelKK 0
.KK0 1
identificacionKK1 ?
,KK? @
nombreLL 
=LL 
PsicologoInputModelLL (
.LL( )
nombreLL) /
,LL/ 0
apellidoMM 
=MM 
PsicologoInputModelMM *
.MM* +
apellidoMM+ 3
,MM3 4
fechaNacimientoNN 
=NN 
PsicologoInputModelNN /
.NN/ 0
fechaNacimientoNN0 ?
,NN? @
sexoOO 
=OO 
PsicologoInputModelOO &
.OO& '
sexoOO' +
,OO+ ,
	direccionPP 
=PP 
PsicologoInputModelPP +
.PP+ ,
	direccionPP, 5
,PP5 6
UniversidadEgresoQQ 
=QQ 
PsicologoInputModelQQ 1
.QQ1 2
UniversidadEgresoQQ2 C
,QQC D
fechaFinalizacionRR 
=RR 
PsicologoInputModelRR 0
.RR0 1
fechaFinalizacionRR1 B
,RRB C
areaEspecializadaSS 
=SS 
PsicologoInputModelSS 0
.SS0 1
areaEspecializadaSS1 B
,SSB C
mesesExperienciaTT 
=TT 
PsicologoInputModelTT /
.TT/ 0
mesesExperienciaTT0 @
,UU 
usuarioVV 
=VV 
newVV 
UsuarioVV 
{VV  
tipoUsuarioWW 
=WW  
$strWW  +
,WW+ ,
nombreUsuarioXX !
=XX! "
PsicologoInputModelXX" 5
.XX5 6
nombreUsuarioXX6 C
,XXC D

contrasenaYY 
=YY 
PsicologoInputModelYY 2
.YY2 3

contrasenaYY3 =
,YY= >
correoZZ 
=ZZ 
PsicologoInputModelZZ .
.ZZ. /
correoZZ/ 5
,ZZ5 6
estado[[ 
=[[ 
$str[[ 
,[[  
telefono\\ 
=\\ 
PsicologoInputModel\\ 0
.\\0 1
telefono\\1 9
,\\9 :
}^^ 
,^^ 
}aa 
;aa 
	psicologocc 
.cc 
calcularEdadcc "
(cc" #
	psicologocc# ,
.cc, -
fechaNacimientocc- <
)cc< =
;cc= >
returndd 
	psicologodd 
;dd 
}ee 	
}ff 
}gg ¿2
iD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\TratamientoController.cs
	namespace 	
Proyectopweb
 
. 
Controllers "
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class !
TratamientoController &
:' (
ControllerBase) 7
{ 
private 
readonly 
TratamientoService +
_tratamientoService, ?
;? @
public !
TratamientoController $
($ %
ConsultorioContext% 7
context8 ?
)? @
{ 	
_tratamientoService 
=  !
new" %
TratamientoService& 8
(8 9
context9 @
)@ A
;A B
} 	
[ 	
AllowAnonymous	 
] 
[ 	
HttpPost	 
] 
public 
ActionResult 
<  
TratamientoViewModel 0
>0 1
Guardar2 9
(9 :!
TratamientoInputModel: O!
tratamientoInputModelP e
)e f
{ 	
var 
tratamiento 
= 
MapearaTratamiento 0
(0 1!
tratamientoInputModel1 F
)F G
;G H
var 
	respuesta 
= 
_tratamientoService /
./ 0
Guardar0 7
(7 8
tratamiento8 C
)C D
;D E
if 
( 
	respuesta 
. 
IsError !
==" $
true% )
)) *
{   
return!! 

BadRequest!! !
(!!! "
	respuesta!!" +
.!!+ ,
Mensaje!!, 3
)!!3 4
;!!4 5
}"" 
return## 
Ok## 
(## 
	respuesta## 
.##  
Tratamiento##  +
)##+ ,
;##, -
}$$ 	
[%% 	
AllowAnonymous%%	 
]%% 
[&& 	
HttpGet&&	 
]&& 
public'' 
ActionResult'' 
<'' 
IEnumerable'' '
<''' ( 
TratamientoViewModel''( <
>''< =
>''= >
Gets''? C
(''C D
)''D E
{(( 	
var)) 
	respuesta)) 
=)) 
_tratamientoService)) /
.))/ 0
	Consultar))0 9
())9 :
))): ;
;)); <
if** 
(** 
	respuesta** 
.** 
Error** 
==**  "
true**# '
)**' (
{++ 
return,, 

BadRequest,, !
(,,! "
	respuesta,," +
.,,+ ,
Mensaje,,, 3
),,3 4
;,,4 5
}-- 
return.. 
Ok.. 
(.. 
	respuesta.. 
...  
Tratamientos..  ,
..., -
Select..- 3
(..3 4
p..4 5
=>..6 8
new..9 < 
TratamientoViewModel..= Q
(..Q R
p..R S
)..S T
)..T U
)..U V
;..V W
}// 	
[11 	
HttpGet11	 
(11 
$str11 
)11 
]11 
public22 
ActionResult22 
<22  
TratamientoViewModel22 0
>220 1
Gets222 6
(226 7
string227 =
id22> @
)22@ A
{33 	
var44 
	respuesta44 
=44 
_tratamientoService44 /
.44/ 0
Buscar440 6
(446 7
id447 9
)449 :
;44: ;
if55 
(55 
	respuesta55 
.55 
IsError55 !
==55" $
true55% )
)55) *
{66 
return77 

BadRequest77 !
(77! "
	respuesta77" +
.77+ ,
Mensaje77, 3
)773 4
;774 5
}88 
return99 
Ok99 
(99 
	respuesta99 
.99  
Tratamiento99  +
)99+ ,
;99, -
}:: 	
private;; 
Tratamiento;; 
MapearaTratamiento;; .
(;;. /!
TratamientoInputModel;;/ D!
tratamientoInputModel;;E Z
);;Z [
{<< 	
var== 
tratamiento== 
=== 
new== !
Tratamiento==" -
{==- ."
identificacionPaciente>> "
=>># $!
tratamientoInputModel>>% :
.>>: ;"
identificacionPaciente>>; Q
,>>Q R#
identificacionPsicologo?? #
=??$ %!
tratamientoInputModel??& ;
.??; <#
identificacionPsicologo??< S
,??S T
fecha@@ 
=@@ !
tratamientoInputModel@@ )
.@@) *
fecha@@* /
,@@/ 0

medicacionAA 
=AA !
tratamientoInputModelAA ,
.AA, -

medicacionAA- 7
,AA7 8
tratamientoPasoBB 
=BB !
tratamientoInputModelBB 1
.BB1 2
tratamientoPasoBB2 A
,BBA B
codigo_3CC 
=CC !
tratamientoInputModelCC *
.CC* +
codigo_3CC+ 3
,CC3 4
codigo_4DD 
=DD !
tratamientoInputModelDD *
.DD* +
codigo_4DD+ 3
,DD3 4
descripcion_3EE 
=EE !
tratamientoInputModelEE /
.EE/ 0
descripcion_3EE0 =
,EE= >
descripcion_4FF 
=FF !
tratamientoInputModelFF /
.FF/ 0
descripcion_4FF0 =
,FF= >
pacienteGG 
=GG 
newGG 
PacienteGG !
{GG! "
identificacionHH 
=HH !
tratamientoInputModelHH 4
.HH4 5"
identificacionPacienteHH5 K
,HHK L
}JJ 
,JJ 
	PsicologoKK 
=KK 
newKK 
	PsicologoKK #
{KK# $
identificacionLL 
=LL !
tratamientoInputModelLL 4
.LL4 5#
identificacionPsicologoLL5 L
,LLL M
}NN 
,NN 
}OO 
;OO 
returnQQ 
tratamientoQQ 
;QQ 
}RR 	
}SS 
}TT Œ
eD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\UsuarioController.cs
	namespace 	
Proyectopweb
 
. 
Controllers "
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
UsuarioController "
:# $
ControllerBase% 3
{ 
private 
UsuarioService 
usuarioService -
;- .
private 

JwtService 
_jwtService &
;& '
ConsultorioContext 
_context #
;# $
public 
UsuarioController  
(  !
ConsultorioContext! 3
context4 ;
,; <
IOptions= E
<E F

AppSettingF P
>P Q
appSettingsR ]
,] ^

JwtService_ i

jwtServicej t
)t u
{ 	
_context 
= 
context 
; 
this 
. 
usuarioService 
=  !
new" %
UsuarioService& 4
(4 5
context5 <
)< =
;= >
_jwtService%% 
=%% 
new%% 

JwtService%% (
(%%( )
appSettings%%) 4
)%%4 5
;%%5 6
usuarioService&& 
=&& 
new&&  
UsuarioService&&! /
(&&/ 0
context&&0 7
)&&7 8
;&&8 9
}'' 	
[(( 	
AllowAnonymous((	 
](( 
[)) 	
HttpPost))	 
])) 
public** 
IActionResult** 
Login** "
(**" #
UsuarioInputModel**# 4
model**5 :
)**: ;
{++ 	
var,, 
user,, 
=,, 
usuarioService,, %
.,,% &
Validate,,& .
(,,. /
model,,/ 4
.,,4 5
nombreUsuario,,5 B
,,,B C
model,,D I
.,,I J

contrasena,,J T
),,T U
;,,U V
if.. 
(.. 
user.. 
==.. 
null.. 
).. 
{// 

ModelState00 
.00 
AddModelError00 (
(00( )
$str00) :
,00: ;
$str00< _
)00_ `
;00` a
var11 
problemDetails11 "
=11# $
new11% ($
ValidationProblemDetails11) A
(11A B

ModelState11B L
)11L M
{22 
Status33 
=33 
StatusCodes33 (
.33( )
Status400BadRequest33) <
,33< =
}44 
;44 
return55 

BadRequest55 !
(55! "
problemDetails55" 0
)550 1
;551 2
}66 
var77 
response77 
=77 
_jwtService77 &
.77& '
GenerateToken77' 4
(774 5
user775 9
)779 :
;77: ;
return99 
Ok99 
(99 
response99 
)99 
;99  
}:: 	
}>> 
}?? á
mD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Controllers\WeatherForecastController.cs
	namespace 	
Proyectopweb
 
. 
Controllers "
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
[ 
Route 

(
 
$str 
) 
] 
public 

class %
WeatherForecastController *
:+ ,
ControllerBase- ;
{ 
private 
static 
readonly 
string  &
[& '
]' (
	Summaries) 2
=3 4
new5 8
[8 9
]9 :
{ 	
$str 
, 
$str !
,! "
$str# +
,+ ,
$str- 3
,3 4
$str5 ;
,; <
$str= C
,C D
$strE L
,L M
$strN S
,S T
$strU a
,a b
$strc n
} 	
;	 

private 
readonly 
ILogger  
<  !%
WeatherForecastController! :
>: ;
_logger< C
;C D
public %
WeatherForecastController (
(( )
ILogger) 0
<0 1%
WeatherForecastController1 J
>J K
loggerL R
)R S
{ 	
_logger 
= 
logger 
; 
} 	
[ 	
HttpGet	 
] 
public 
IEnumerable 
< 
WeatherForecast *
>* +
Get, /
(/ 0
)0 1
{ 	
var 
rng 
= 
new 
Random  
(  !
)! "
;" #
return 

Enumerable 
. 
Range #
(# $
$num$ %
,% &
$num' (
)( )
.) *
Select* 0
(0 1
index1 6
=>7 9
new: =
WeatherForecast> M
{ 
Date   
=   
DateTime   
.    
Now    #
.  # $
AddDays  $ +
(  + ,
index  , 1
)  1 2
,  2 3
TemperatureC!! 
=!! 
rng!! "
.!!" #
Next!!# '
(!!' (
-!!( )
$num!!) +
,!!+ ,
$num!!- /
)!!/ 0
,!!0 1
Summary"" 
="" 
	Summaries"" #
[""# $
rng""$ '
.""' (
Next""( ,
("", -
	Summaries""- 6
.""6 7
Length""7 =
)""= >
]""> ?
}## 
)## 
.$$ 
ToArray$$ 
($$ 
)$$ 
;$$ 
}%% 	
}&& 
}'' æ
VD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Hubs\SignalHub.cs
	namespace 	
Proyectopweb
 
. 
Hubs 
{ 
public 

class 
	SignalHub 
: 
Hub 
{ 
} 
}		 ’
fD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Models\AdministradorInputModel.cs
	namespace 	
Proyectopweb
 
. 
Models 
{ 
public 

class #
AdministradorInputModel (
{ 
public

 
string

 
nombreUsuario

 #
{

$ %
get

& )
;

) *
set

+ .
;

. /
}

0 1
public 
string 
contrase√±a  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
tipoUsuario !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
public 

class "
AdministradorViewModel '
:( )#
AdministradorInputModel* A
{ 
public "
AdministradorViewModel %
(% &
Administrador& 3
administrador4 A
)A B
{ 	
nombreUsuario 
= 
administrador )
.) *
nombreUsuario* 7
;7 8
contrase√±a 
= 
administrador &
.& '

contrasena' 1
;1 2
tipoUsuario 
= 
administrador '
.' (
tipoUsuario( 3
;3 4
} 	
} 
} Ù
ZD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Models\AgendaModel.cs
	namespace 	
Proyectopweb
 
. 
Models 
{ 
public 

class 
AgendaInputModel !
{ 
public 
string 
idPsicologo !
{" #
get$ '
;' (
set) ,
;, -
}. /
public		 
DateTime		 
fechaDeseada		 $
{		% &
get		' *
;		* +
set		, /
;		/ 0
}		1 2
public

 
string

 
horaCita
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
+ ,
} 
public 

class 
AgendaViewModel  
:! "
AgendaInputModel# 3
{ 
public 
AgendaViewModel 
( 
)  
{ 	
} 	
public 
AgendaViewModel 
( 
Agenda %
agenda& ,
), -
{ 	
idPsicologo 
= 
agenda  
.  !
idPsicologo! ,
;, -
fechaDeseada 
= 
agenda !
.! "
fechaDeseada" .
;. /
horaCita 
= 
agenda 
. 
horaCita &
;& '
idAgenda 
= 
agenda 
. 
idAgenda &
;& '
} 	
public 
int 
idAgenda 
{ 
get !
;! "
set# &
;& '
}( )
}!! 
}"" â
XD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Models\CitaModel.cs
	namespace 	
Proyectopweb
 
. 
Models 
{ 
public 

class 
CitaInputModel 
{ 
[		 	
Required			 
(		 
ErrorMessage		 
=		  
$str		! M
)		M N
]		N O
public

 
string

 

idPaciente

  
{

  !
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
+ ,
[ 	
Required	 
( 
ErrorMessage 
=  
$str! C
)C D
]D E
public 
DateTime 
fechaDeseada $
{$ %
get% (
;( )
set* -
;- .
}/ 0
[ 	
Required	 
( 
ErrorMessage 
=  
$str! J
)J K
]K L
public 
string 
nombre 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Required	 
( 
ErrorMessage 
=  
$str! B
)B C
]C D
public 
string 
horaCita 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
estado 
{ 
get "
;" #
set$ '
;' (
}) *
} 
public 

class 
CitaViewModel 
:  
CitaInputModel! /
{ 
public 
CitaViewModel 
( 
) 
{ 	
} 	
public 
CitaViewModel 
( 
Cita !
cita" &
)& '
{ 	
idCita 
= 
cita 
. 
idCita 
;  

idPaciente 
= 
cita 
. 

idPaciente '
;' (
fechaDeseada 
= 
cita 
. 
fechaDeseada +
;+ ,
nombre   
=   
cita   
.   
nombre   
;   
horaCita!! 
=!! 
cita!! 
.!! 
horaCita!! !
;!!! "
estado"" 
="" 
cita"" 
."" 
estado"" 
;"" 
}## 	
public$$ 
int$$ 
idCita$$ 
{$$ 
get$$ 
;$$ 
set$$ "
;$$" #
}$$$ %
}%% 
}&& ƒ
^D:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Models\EnfermedadModel.cs
	namespace 	
Proyectopweb
 
. 
Models 
{ 
public 

class  
EnfermedadInputModel %
{ 
} 
public 

class 
EnfermedadViewModel $
:% & 
EnfermedadInputModel' ;
{ 
public 
EnfermedadViewModel "
(" #
)# $
{ 	
} 	
public 
EnfermedadViewModel "
(" #

Enfermedad# -

enfermedad. 8
)8 9
{ 	
idEnfermedad 
= 

enfermedad %
.% &
idEnfermedad& 2
;2 3
Codigo_3 
= 

enfermedad !
.! "
Codigo_3" *
;* +
Descripcion_3 
= 

enfermedad &
.& '
Descripcion_3' 4
;4 5
Codigo_4 
= 

enfermedad !
.! "
Codigo_4" *
;* +
Descripcion_4 
= 

enfermedad &
.& '
Descripcion_4' 4
;4 5
} 	
public 
int 
idEnfermedad 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
Codigo_3 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
Descripcion_3 #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public   
string   
Codigo_4   
{    
get  ! $
;  $ %
set  & )
;  ) *
}  + ,
public!! 
string!! 
Descripcion_4!! #
{!!$ %
get!!& )
;!!) *
set!!+ .
;!!. /
}!!0 1
}"" 
}$$ º
WD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Models\EpsModel.cs
	namespace 	
Proyectopweb
 
. 
Models 
{ 
public 

class 
EpsInputModel 
{ 
} 
public 

class 
EpsViewModel 
: 
EpsInputModel  -
{ 
public 
EpsViewModel 
( 
) 
{ 	
} 	
public 
EpsViewModel 
( 
Eps 
eps  #
)# $
{ 	
Administradora 
= 
eps 
. 
Administradora -
;- .
} 	
public	 
string 
Administradora %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
} Ô
^D:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Models\EvaluacionModel.cs
	namespace 	
Proyectopweb
 
. 
Models 
{ 
public 

class  
EvaluacionInputModel %
{ 
public 
string "
identificacionPaciente ,
{- .
get. 1
;1 2
set3 6
;6 7
}7 8
public		 
string		 #
identificacionPsicologo		 -
{		. /
get		/ 2
;		2 3
set		4 7
;		7 8
}		8 9
public

 
string

 
diagnostico

 !
{

" #
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
, -
public 
string 
	ocupacion 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 
consulta 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
observacion !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
prueba 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
analisis 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 

pronostico  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
recomendacion #
{$ %
get& )
;) *
set+ .
;. /
}0 1
} 
public 

class 
EvaluacionViewModel $
:% & 
EvaluacionInputModel' ;
{ 
public 
EvaluacionViewModel "
(" #
)# $
{ 	
} 	
public 
EvaluacionViewModel "
(" #

Evaluacion# -

evaluacion. 8
)8 9
{ 	
IdEvaluacion 
= 

evaluacion %
.% &
IdEvaluacion& 2
;2 3"
identificacionPaciente "
=# $

evaluacion% /
./ 0"
identificacionPaciente0 F
;F G#
identificacionPsicologo   #
=  $ %

evaluacion  & 0
.  0 1#
identificacionPsicologo  1 H
;  H I
diagnostico!! 
=!! 

evaluacion!! $
.!!$ %
diagnostico!!% 0
;!!0 1
	ocupacion"" 
="" 

evaluacion"" "
.""" #
	ocupacion""# ,
;"", -
consulta## 
=## 

evaluacion## !
.##! "
consulta##" *
;##* +
observacion$$ 
=$$ 

evaluacion$$ $
.$$$ %
observacion$$% 0
;$$0 1
prueba%% 
=%% 

evaluacion%% 
.%%  
prueba%%  &
;%%& '
analisis&& 
=&& 

evaluacion&& !
.&&! "
analisis&&" *
;&&* +

pronostico'' 
='' 

evaluacion'' #
.''# $

pronostico''$ .
;''. /
recomendacion(( 
=(( 

evaluacion(( &
.((& '
recomendacion((' 4
;((4 5
})) 	
public** 
int** 
IdEvaluacion** 
{**  !
get**" %
;**% &
set**' *
;*** +
}**, -
}++ 
},, Ú7
\D:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Models\PacienteModel.cs
	namespace 	
Proyectopweb
 
. 
Models 
{ 
public 

class 
PacienteInputModel #
{ 
[		 	
Required			 
(		 
ErrorMessage		 
=		  
$str		! D
)		D E
]		E F
public

 
string

 
nombreUsuario

 #
{

$ %
get

& )
;

) *
set

+ .
;

. /
}

0 1
[ 	
Required	 
( 
ErrorMessage 
=  
$str! =
)= >
]> ?
public 
string 

contrasena  
{! "
get# &
;& '
set( +
;+ ,
}- .
[ 	
Required	 
( 
ErrorMessage 
=  
$str! D
)D E
]E F
public 
string 
tipoDocumento #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
( 
ErrorMessage 
=  
$str! A
)A B
]B C
public 
string 
identificacion $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 9
)9 :
]: ;
public 
string 
nombre 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Required	 
( 
ErrorMessage 
=  
$str! ;
); <
]< =
public 
string 
apellido 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
SexoValidacion	 
( 
ErrorMessage %
=% &
$str& K
)K L
]L M
public 
string 
sexo 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
( 
ErrorMessage 
=  
$str! B
)B C
]C D
public 
DateTime 
fechaNacimiento '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[ 	
Required	 
( 
ErrorMessage 
=  
$str! ;
); <
]< =
public 
string 
telefono 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
( 
ErrorMessage 
=  
$str! <
)< =
]= >
public 
string 
	direccion 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 9
)9 :
]: ;
public 
string 
correo 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 6
)6 7
]7 8
public   
string   
Eps   
{   
get   
;    
set  ! $
;  $ %
}  & '
public!! 
Usuario!! 
usuario!! 
{!!  
get!!! $
;!!$ %
set!!& )
;!!) *
}!!+ ,
public"" 
string"" 
tipoUsuario"" !
{""" #
get""$ '
;""' (
set"") ,
;"", -
}"". /
public## 
string## 
estado## 
{## 
get## "
;##" #
set##$ '
;##' (
}##) *
}%% 
public&& 

class&& 
SexoValidacion&& 
:&&  !
ValidationAttribute&&" 5
{'' 
	protected(( 
override(( 
ValidationResult(( +
IsValid((, 3
(((3 4
object((4 :
value((; @
,((@ A
ValidationContext((B S
validationContext((T e
)((e f
{)) 	
if** 
(** 
(** 
value** 
.** 
ToString** 
(**  
)**  !
.**! "
ToUpper**" )
(**) *
)*** +
==**, .
$str**/ :
)**: ;
||**< >
(**? @
value**@ E
.**E F
ToString**F N
(**N O
)**O P
.**P Q
ToUpper**Q X
(**X Y
)**Y Z
==**[ ]
$str**^ h
)**h i
)**i j
{++ 
return,, 
ValidationResult,, '
.,,' (
Success,,( /
;,,/ 0
}-- 
else.. 
{// 
return00 
new00 
ValidationResult00 +
(00+ ,
ErrorMessage00, 8
)008 9
;009 :
}11 
}22 	
}33 
public44 

class44 
PacienteViewModel44 "
:44# $
PacienteInputModel44% 7
{55 
public66 
PacienteViewModel66  
(66  !
)66! "
{77 	
}99 	
public:: 
PacienteViewModel::  
(::  !
Paciente::! )
paciente::* 2
)::2 3
{;; 	
tipoDocumento== 
=== 
paciente== $
.==$ %
tipoDocumento==% 2
;==2 3
identificacion>> 
=>> 
paciente>> %
.>>% &
identificacion>>& 4
;>>4 5
nombre?? 
=?? 
paciente?? 
.?? 
nombre?? $
;??$ %
apellido@@ 
=@@ 
paciente@@ 
.@@  
apellido@@  (
;@@( )
sexoAA 
=AA 
pacienteAA 
.AA 
sexoAA  
;AA  !
fechaNacimientoBB 
=BB 
pacienteBB &
.BB& '
fechaNacimientoBB' 6
;BB6 7
	direccionCC 
=CC 
pacienteCC  
.CC  !
	direccionCC! *
;CC* +
EpsDD 
=DD 
pacienteDD 
.DD 
EpsDD 
;DD 
edadEE 
=EE 
pacienteEE 
.EE 
edadEE 
;EE 
}II 	
publicJJ 
intJJ 
edadJJ 
{JJ 
getJJ 
;JJ 
setJJ "
;JJ" #
}JJ$ %
}KK 
}LL Í3
bD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Models\PsicologoInputModel.cs
	namespace 	
Proyectopweb
 
. 
Models 
{		 
public

 

class

 
PsicologoInputModel

 $
{ 
[ 	
Required	 
( 
ErrorMessage 
=  
$str! D
)D E
]E F
public 
string 
nombreUsuario #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
( 
ErrorMessage 
=  
$str! =
)= >
]> ?
public 
string 

contrasena  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
tipoUsuario !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
( 
ErrorMessage 
=  
$str! A
)A B
]B C
public 
string 
identificacion $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Required	 
( 
ErrorMessage 
=  
$str! A
)A B
]B C
public 
string 
tipoDocumento #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
( 
ErrorMessage 
=  
$str! 9
)9 :
]: ;
public 
string 
nombre 
{ 
get "
;" #
set$ '
;' (
}) *
[ 	
Required	 
( 
ErrorMessage 
=  
$str! ;
); <
]< =
public 
string 
apellido 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
sexo 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
( 
ErrorMessage 
=  
$str! F
)F G
]G H
public 
DateTime 
fechaNacimiento '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
[ 	
Required	 
( 
ErrorMessage 
=  
$str! ;
); <
]< =
public 
string 
telefono 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
( 
ErrorMessage 
=  
$str! <
)< =
]= >
public 
string 
	direccion 
{  !
get" %
;% &
set' *
;* +
}, -
[   	
Required  	 
(   
ErrorMessage   
=    
$str  ! 9
)  9 :
]  : ;
public!! 
string!! 
correo!! 
{!! 
get!! "
;!!" #
set!!$ '
;!!' (
}!!) *
["" 	
Required""	 
("" 
ErrorMessage"" 
=""  
$str""! >
)""> ?
]""? @
public## 
string## 
UniversidadEgreso## '
{##( )
get##* -
;##- .
set##/ 2
;##2 3
}##4 5
[$$ 	
Required$$	 
($$ 
ErrorMessage$$ 
=$$  
$str$$! E
)$$E F
]$$F G
public%% 
string%% 
fechaFinalizacion%% '
{%%( )
get%%* -
;%%- .
set%%/ 2
;%%2 3
}%%4 5
[&& 	
Required&&	 
(&& 
ErrorMessage&& 
=&&  
$str&&! E
)&&E F
]&&F G
public'' 
string'' 
areaEspecializada'' '
{''( )
get''* -
;''- .
set''/ 2
;''2 3
}''4 5
[(( 	
Required((	 
((( 
ErrorMessage(( 
=((  
$str((! J
)((J K
]((K L
public)) 
string)) 
mesesExperiencia)) &
{))' (
get))) ,
;)), -
set)). 1
;))1 2
}))3 4
public** 
Usuario** 
usuario** 
{**  
get**! $
;**$ %
set**& )
;**) *
}**+ ,
}++ 
public-- 

class-- 
PsicologoViewModel-- #
:--$ %
PsicologoInputModel--& 9
{.. 
public// 
PsicologoViewModel// !
(//! "
	Psicologo//" +
	psicologo//, 5
)//5 6
{00 	
identificacion22 
=22 
	psicologo22 &
.22& '
identificacion22' 5
;225 6
nombre33 
=33 
	psicologo33 
.33 
nombre33 $
;33$ %
apellido44 
=44 
	psicologo44 
.44  
apellido44  (
;44( )
sexo55 
=55 
	psicologo55 
.55 
sexo55  
;55  !
	direccion77 
=77 
	psicologo77 
.77  
	direccion77  )
;77) *
edad88 
=88 
	psicologo88 
.88 
edad88 
;88  
UniversidadEgreso99 
=99 
	psicologo99 &
.99& '
UniversidadEgreso99' 8
;998 9
fechaFinalizacion:: 
=:: 
	psicologo:: &
.::& '
fechaFinalizacion::' 8
;::8 9
areaEspecializada;; 
=;; 
	psicologo;; &
.;;& '
areaEspecializada;;' 8
;;;8 9
mesesExperiencia<< 
=<< 
	psicologo<< %
.<<% &
mesesExperiencia<<& 6
;<<6 7
}>> 	
public?? 
int?? 
edad?? 
{?? 
get?? 
;?? 
set?? !
;??! "
}??" #
}@@ 
}AA ä
dD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Models\TratamientoInputModel.cs
	namespace 	
Proyectopweb
 
. 
Models 
{ 
public 

class !
TratamientoInputModel &
{ 
public 
string "
identificacionPaciente ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public		 
string		 #
identificacionPsicologo		 -
{		. /
get		0 3
;		3 4
set		5 8
;		8 9
}		: ;
public

 
DateTime

 
fecha

 
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
public 
string 
codigo_3 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
codigo_4 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
descripcion_3 #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
descripcion_4 #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 

medicacion  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
string 
tratamientoPaso %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
public 

class  
TratamientoViewModel %
:& '!
TratamientoInputModel( =
{ 
public  
TratamientoViewModel #
(# $
)$ %
{ 	
} 	
public  
TratamientoViewModel #
(# $
Tratamiento$ /
tratamiento0 ;
); <
{ 	
IdTratamiento 
= 
tratamiento '
.' (
IdTratamiento( 5
;5 6"
identificacionPaciente "
=# $
tratamiento% 0
.0 1"
identificacionPaciente1 G
;G H#
identificacionPsicologo   #
=  $ %
tratamiento  & 1
.  1 2#
identificacionPsicologo  2 I
;  I J
codigo_3!! 
=!! 
tratamiento!! !
.!!! "
codigo_3!!" *
;!!* +
codigo_4"" 
="" 
tratamiento""  
.""  !
codigo_4""! )
;"") *
descripcion_3## 
=## 
tratamiento## %
.##% &
descripcion_3##& 3
;##3 4
descripcion_4$$ 
=$$ 
tratamiento$$ %
.$$% &
descripcion_4$$& 3
;$$3 4
fecha%% 
=%% 
tratamiento%% 
.%%  
fecha%%  %
;%%% &

medicacion&& 
=&& 
tratamiento&& $
.&&$ %

medicacion&&% /
;&&/ 0
tratamientoPaso'' 
='' 
tratamiento'' )
.'') *
tratamientoPaso''* 9
;''9 :
})) 	
public** 
int** 
IdTratamiento**  
{**! "
get**# &
;**& '
set**( +
;**+ ,
}**- .
}++ 
},, ∆
[D:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Models\UsuarioModel.cs
	namespace 	
Proyectopweb
 
. 
Models 
{ 
public 

class 
UsuarioInputModel "
{ 
[		 	
Required			 
]		 
public

 
string

 
nombreUsuario

 #
{

$ %
get

& )
;

) *
set

+ .
;

. /
}

0 1
[ 	
Required	 
] 
public 
string 

contrasena  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
public 

class 
UsuarioViewModel !
:" #
UsuarioInputModel$ 5
{ 
public 
UsuarioViewModel 
(  
)  !
{ 	
} 	
public 
string 
nombreUsuario #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
tipoUsuario !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
estado 
{ 
get "
;" #
set$ '
;' (
}) *
public 
string 
Token 
{ 
get !
;! "
set# &
;& '
}( )
} 
} £
ZD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Pages\Error.cshtml.cs
	namespace

 	
Proyectopweb


 
.

 
Pages

 
{ 
[ 
ResponseCache 
( 
Duration 
= 
$num 
,  
Location! )
=* +!
ResponseCacheLocation, A
.A B
NoneB F
,F G
NoStoreH O
=P Q
trueR V
)V W
]W X
public 

class 

ErrorModel 
: 
	PageModel '
{ 
private 
readonly 
ILogger  
<  !

ErrorModel! +
>+ ,
_logger- 4
;4 5
public 

ErrorModel 
( 
ILogger !
<! "

ErrorModel" ,
>, -
logger. 4
)4 5
{ 	
_logger 
= 
logger 
; 
} 	
public 
string 
	RequestId 
{  !
get" %
;% &
set' *
;* +
}, -
public 
bool 
ShowRequestId !
=>" $
!% &
string& ,
., -
IsNullOrEmpty- :
(: ;
	RequestId; D
)D E
;E F
public 
void 
OnGet 
( 
) 
{ 	
	RequestId 
= 
Activity  
.  !
Current! (
?( )
.) *
Id* ,
??- /
HttpContext0 ;
.; <
TraceIdentifier< K
;K L
} 	
} 
} ©

OD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Program.cs
	namespace

 	
Proyectopweb


 
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
; 
} 
} –"
ZD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Service\JwtService.cs
	namespace 	
WebPulsaciones
 
{ 
public 

class 

JwtService 
{ 
private 
readonly 

AppSetting #
_appSettings$ 0
;0 1
public 

JwtService 
( 
IOptions "
<" #

AppSetting# -
>- .
appSettings/ :
): ;
=>; =
_appSettings> J
=K L
appSettingsM X
.X Y
ValueY ^
;^ _
public 
UsuarioViewModel 
GenerateToken  -
(- .
Usuario. 5
	userLogIn6 ?
)? @
{ 	
if 
( 
	userLogIn 
== 
null !
)! "
return# )
null* .
;. /
var 
userResponse 
= 
new "
UsuarioViewModel# 3
(3 4
)4 5
{6 7
tipoUsuario8 C
=C D
	userLogInD M
.M N
tipoUsuarioN Y
,Y Z
nombreUsuarioZ g
=h i
	userLogInj s
.s t
nombreUsuario	t Å
,
Å Ç
estado
É â
=
â ä
	userLogIn
ä ì
.
ì î
estado
î ö
}
ö õ
;
õ ú
var 
tokenHandler 
= 
new "#
JwtSecurityTokenHandler# :
(: ;
); <
;< =
var 
key 
= 
Encoding 
. 
ASCII $
.$ %
GetBytes% -
(- .
_appSettings. :
.: ;
Secret; A
)A B
;B C
var 
tokenDescriptor 
=  !
new" %#
SecurityTokenDescriptor& =
{ 
Subject 
= 
new 
ClaimsIdentity ,
(, -
new- 0
Claim1 6
[6 7
]7 8
{   
new!! 
Claim!! 
(!! 

ClaimTypes!! (
.!!( )
Name!!) -
,!!- .
	userLogIn!!/ 8
.!!8 9
nombreUsuario!!9 F
.!!F G
ToString!!G O
(!!O P
)!!P Q
)!!Q R
,!!R S
new"" 
Claim"" 
("" 

ClaimTypes"" (
.""( )
Email"") .
,"". /
	userLogIn""0 9
.""9 :
correo"": @
.""@ A
ToString""A I
(""I J
)""J K
)""K L
,""L M
new## 
Claim## 
(## 

ClaimTypes## (
.##( )
MobilePhone##) 4
,##4 5
	userLogIn##6 ?
.##? @
telefono##@ H
.##H I
ToString##I Q
(##Q R
)##R S
)##S T
,##T U
new$$ 
Claim$$ 
($$ 

ClaimTypes$$ (
.$$( )
Role$$) -
,$$- .
	userLogIn$$/ 8
.$$8 9
tipoUsuario$$9 D
.$$D E
ToString$$E M
($$M N
)$$N O
)$$O P
,$$P Q
}&& 
)&& 
,&& 
Expires'' 
='' 
DateTime'' "
.''" #
UtcNow''# )
.'') *
AddDays''* 1
(''1 2
$num''2 3
)''3 4
,''4 5
SigningCredentials(( "
=((# $
new((% (
SigningCredentials(() ;
(((; <
new((< ? 
SymmetricSecurityKey((@ T
(((T U
key((U X
)((X Y
,((Y Z
SecurityAlgorithms(([ m
.((m n 
HmacSha256Signature	((n Å
)
((Å Ç
})) 
;)) 
var** 
token** 
=** 
tokenHandler** $
.**$ %
CreateToken**% 0
(**0 1
tokenDescriptor**1 @
)**@ A
;**A B
userResponse++ 
.++ 
Token++ 
=++  
tokenHandler++! -
.++- .

WriteToken++. 8
(++8 9
token++9 >
)++> ?
;++? @
return,, 
userResponse,, 
;,,  
}-- 	
}.. 
}// „V
OD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\Startup.cs
	namespace 	
Proyectopweb
 
{ 
public 

class 
Startup 
{ 
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{ 	
Configuration 
= 
configuration )
;) *
} 	
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public   
void   
ConfigureServices   %
(  % &
IServiceCollection  & 8
services  9 A
)  A B
{!! 	
var## 
connectionString##  
=##! "
Configuration### 0
.##0 1
GetConnectionString##1 D
(##D E
$str##E X
)##X Y
;##Y Z
services$$ 
.$$ 
AddDbContext$$ !
<$$! "
ConsultorioContext$$" 4
>$$4 5
($$5 6
p$$6 7
=>$$8 :
p$$; <
.$$< =
UseSqlServer$$= I
($$I J
connectionString$$J Z
)$$Z [
)$$[ \
;$$\ ]
services%% 
.%% 

AddSignalR%% 
(%%  
)%%  !
;%%! "
services&& 
.&& #
AddControllersWithViews&& ,
(&&, -
)&&- .
;&&. /
services'' 
.'' 
	AddScoped'' 
<'' 

JwtService'' )
>'') *
(''* +
)''+ ,
;'', -
var** 
appSettingsSection** "
=**# $
Configuration**% 2
.**2 3

GetSection**3 =
(**= >
$str**> J
)**J K
;**K L
services++ 
.++ 
	Configure++ 
<++ 

AppSetting++ )
>++) *
(++* +
appSettingsSection+++ =
)++= >
;++> ?
var// 
appSettings// 
=// 
appSettingsSection// 0
.//0 1
Get//1 4
<//4 5

AppSetting//5 ?
>//? @
(//@ A
)//A B
;//B C
var00 
key00 
=00 
Encoding00 
.00 
ASCII00 $
.00$ %
GetBytes00% -
(00- .
appSettings00. 9
.009 :
Secret00: @
)00@ A
;00A B
services11 
.11 
AddAuthentication11 &
(11& '
x11' (
=>11) +
{22 
x33 
.33 %
DefaultAuthenticateScheme33 +
=33, -
JwtBearerDefaults33. ?
.33? @ 
AuthenticationScheme33@ T
;33T U
x44 
.44 "
DefaultChallengeScheme44 (
=44) *
JwtBearerDefaults44+ <
.44< = 
AuthenticationScheme44= Q
;44Q R
}55 
)55 
.66 
AddJwtBearer66 
(66 
x66 
=>66 
{77 
x88 
.88  
RequireHttpsMetadata88 &
=88' (
false88) .
;88. /
x99 
.99 
	SaveToken99 
=99 
true99 "
;99" #
x:: 
.:: %
TokenValidationParameters:: +
=::, -
new::. 1%
TokenValidationParameters::2 K
{;; $
ValidateIssuerSigningKey<< ,
=<<- .
true<</ 3
,<<3 4
IssuerSigningKey== $
===% &
new==' * 
SymmetricSecurityKey==+ ?
(==? @
key==@ C
)==C D
,==D E
ValidateIssuer>> "
=>># $
false>>% *
,>>* +
ValidateAudience?? $
=??% &
false??' ,
}@@ 
;@@ 
}AA 
)AA 
;AA 
servicesDD 
.DD 
AddSpaStaticFilesDD &
(DD& '
configurationDD' 4
=>DD5 7
{EE 
configurationFF 
.FF 
RootPathFF &
=FF' (
$strFF) 9
;FF9 :
}GG 
)GG 
;GG 
servicesHH 
.HH 
AddSwaggerGenHH "
(HH" #
cHH# $
=>HH% '
{II 	
cJJ 
.JJ 

SwaggerDocJJ 
(JJ 
$strJJ 
,JJ 
newJJ "
OpenApiInfoJJ# .
{KK 
VersionLL 
=LL 
$strLL 
,LL 
TitleMM 
=MM 
$strMM "
,MM" #
DescriptionNN 
=NN 
$strNN E
,NNE F
TermsOfServiceOO 
=OO  
newOO! $
UriOO% (
(OO( )
$strOO) D
)OOD E
,OOE F
ContactPP 
=PP 
newPP 
OpenApiContactPP ,
{QQ 
NameRR 
=RR 
$strRR )
,RR) *
EmailSS 
=SS 
stringSS "
.SS" #
EmptySS# (
,SS( )
UrlTT 
=TT 
newTT 
UriTT !
(TT! "
$strTT" ?
)TT? @
,TT@ A
}UU 
,UU 
LicenseVV 
=VV 
newVV 
OpenApiLicenseVV ,
{WW 
NameXX 
=XX 
$strXX +
,XX+ ,
UrlYY 
=YY 
newYY 
UriYY !
(YY! "
$strYY" ?
)YY? @
,YY@ A
}ZZ 
}[[ 
)[[ 
;[[ 
c\\ 
.\\ !
AddSecurityDefinition\\ #
(\\# $
$str\\$ 0
,\\0 1
new\\2 5!
OpenApiSecurityScheme\\6 K
{\\K L
Name]] 
=]] 
$str]] $
,]]$ %
Type^^ 
=^^ 
SecuritySchemeType^^ '
.^^' (
Http^^( ,
,^^, -
Scheme__ 
=__ 
$str__ 
,__  
BearerFormat`` 
=`` 
$str`` "
,``" #
Inaa 
=aa 
ParameterLocationaa $
.aa$ %
Headeraa% +
,aa+ ,
Descriptionbb 
=bb 
$strbb P
}cc 
)cc 
;cc 
cdd 
.dd "
AddSecurityRequirementdd $
(dd$ %
newdd% (&
OpenApiSecurityRequirementdd) C
{ddC D
{ee 
newff !
OpenApiSecuritySchemeff ,
{gg 
	Referencehh  
=hh  !
newhh! $
OpenApiReferencehh% 5
{ii 
Typejj 
=jj  
ReferenceTypejj  -
.jj- .
SecuritySchemejj. <
,jj< =
Idkk 
=kk 
$strkk *
}ll 
}mm 
,mm 
newnn 
stringnn 
[nn 
]nn 
{nn  
}nn  !
}oo 
}pp 
)pp 
;pp 
}rr 	
)rr	 

;rr
 
}tt 	
publicww 
voidww 
	Configureww 
(ww 
IApplicationBuilderww 1
appww2 5
,ww5 6
IWebHostEnvironmentww7 J
envwwK N
)wwN O
{xx 	
appyy 
.yy 

UseSwaggeryy 
(yy 
)yy 
;yy 
appzz 
.zz 
UseSwaggerUIzz 
(zz 
czz 
=>zz !
{{{ 
c|| 
.|| 
SwaggerEndpoint|| !
(||! "
$str||" <
,||< =
$str||> I
)||I J
;||J K
}~~ 
)~~ 
;~~ 
if 
( 
env 
. 
IsDevelopment !
(! "
)" #
)# $
{
ÄÄ 
app
ÅÅ 
.
ÅÅ '
UseDeveloperExceptionPage
ÅÅ -
(
ÅÅ- .
)
ÅÅ. /
;
ÅÅ/ 0
}
ÇÇ 
else
ÉÉ 
{
ÑÑ 
app
ÖÖ 
.
ÖÖ !
UseExceptionHandler
ÖÖ '
(
ÖÖ' (
$str
ÖÖ( 0
)
ÖÖ0 1
;
ÖÖ1 2
app
áá 
.
áá 
UseHsts
áá 
(
áá 
)
áá 
;
áá 
}
àà 
app
ää 
.
ää !
UseHttpsRedirection
ää #
(
ää# $
)
ää$ %
;
ää% &
app
ãã 
.
ãã 
UseStaticFiles
ãã 
(
ãã 
)
ãã  
;
ãã  !
if
åå 
(
åå 
!
åå 
env
åå 
.
åå 
IsDevelopment
åå "
(
åå" #
)
åå# $
)
åå$ %
{
çç 
app
éé 
.
éé 
UseSpaStaticFiles
éé %
(
éé% &
)
éé& '
;
éé' (
}
èè 
app
ëë 
.
ëë 

UseRouting
ëë 
(
ëë 
)
ëë 
;
ëë 
app
ìì 
.
ìì 
UseCors
ìì 
(
ìì 
x
ìì 
=>
ìì 
x
ìì 
.
îî 
AllowAnyOrigin
îî 
(
îî  
)
îî  !
.
ïï 
AllowAnyMethod
ïï 
(
ïï  
)
ïï  !
.
ññ 
AllowAnyHeader
ññ 
(
ññ  
)
ññ  !
)
ññ! "
;
ññ" #
app
òò 
.
òò 
UseAuthentication
òò !
(
òò! "
)
òò" #
;
òò# $
app
ôô 
.
ôô 
UseAuthorization
ôô  
(
ôô  !
)
ôô! "
;
ôô" #
app
úú 
.
úú 
UseEndpoints
úú 
(
úú 
	endpoints
úú &
=>
úú' )
{
ùù 
	endpoints
ûû 
.
ûû 
MapHub
ûû  
<
ûû  !
	SignalHub
ûû! *
>
ûû* +
(
ûû+ ,
$str
ûû, 8
)
ûû8 9
;
ûû9 :
	endpoints
üü 
.
üü  
MapControllerRoute
üü ,
(
üü, -
name
†† 
:
†† 
$str
†† #
,
††# $
pattern
°° 
:
°° 
$str
°° @
)
°°@ A
;
°°A B
}
¢¢ 
)
¢¢ 
;
¢¢ 
app
§§ 
.
§§ 
UseSpa
§§ 
(
§§ 
spa
§§ 
=>
§§ 
{
•• 
spa
©© 
.
©© 
Options
©© 
.
©© 

SourcePath
©© &
=
©©' (
$str
©©) 4
;
©©4 5
if
´´ 
(
´´ 
env
´´ 
.
´´ 
IsDevelopment
´´ %
(
´´% &
)
´´& '
)
´´' (
{
¨¨ 
spa
≠≠ 
.
≠≠ !
UseAngularCliServer
≠≠ +
(
≠≠+ ,
	npmScript
≠≠, 5
:
≠≠5 6
$str
≠≠7 >
)
≠≠> ?
;
≠≠? @
}
ÆÆ 
}
ØØ 
)
ØØ 
;
ØØ 
}
∞∞ 	
}
±± 
}≤≤ ›
WD:\Upc\ProyectoModificaciones\Proyecto-Programacion-Web\ProyectoPWEB\WeatherForecast.cs
	namespace 	
Proyectopweb
 
{ 
public 

class 
WeatherForecast  
{ 
public 
DateTime 
Date 
{ 
get "
;" #
set$ '
;' (
}) *
public		 
int		 
TemperatureC		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
public 
int 
TemperatureF 
=>  "
$num# %
+& '
(( )
int) ,
), -
(- .
TemperatureC. :
/; <
$num= C
)C D
;D E
public 
string 
Summary 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} 