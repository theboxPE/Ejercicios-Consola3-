/* Programa que le pida al usuario un numero del 1 al 7 y que segun el numero, 
escriba en la pantalla el nombre del dia de la semana correspondiente
*/

int dia;

Console.WriteLine("Ingrese un numero del 1 al 7");
dia = Convert.ToInt32(Console.ReadLine());

switch (dia) {

case 1:
Console.WriteLine("Domingo");
break;

case 2:
Console.WriteLine("Lunes");
break;

case 3:
Console.WriteLine("Martes");
break;

case 4:
Console.WriteLine("Miercoles");
break;

case 5:
Console.WriteLine("Jueves");
break;

case 6:
Console.WriteLine("Viernes");
break;

case 7:
Console.WriteLine("Sabado");
break;

default:
Console.WriteLine("Error!,el numero ingresado es incorrecta :( ");
break;
}

Console.ReadKey();