/* Programa que le muestre al usuario un menu como este: [E]Español  [I]Inglés  [F]Francés. 
Según la letra ingresada por el usuario, muestre una frase en el lenguaje seleccionado.
*/

string x;

Console.WriteLine(".::::Menu::::.");
Console.WriteLine("Elige una de las opciones");
Console.WriteLine("[E]Español");
Console.WriteLine("[I]Inglés");
Console.WriteLine("[F]Francés");

x = Convert.ToString(Console.ReadLine())!;

switch (x) {

case "E" or "e":
Console.WriteLine("Aprender a dudar es aprender a pensar");
break;

case "I" or "i":
Console.WriteLine("If you change the way you look at things, the things you look at change");
break;

case "F" or "f":
Console.WriteLine("La mémoire est l?avenir du passé");
break;

default:
Console.WriteLine("Error!,la letra ingresado es incorrecta :( ");
break;
}

Console.ReadKey();