
var numberString = string.Empty
do
{
    Console.Write("Ingrese Numero entero o la plabra salir: ");
    var numberString = Console.ReadLine();
    if (numberString.ToLower() == "salir"
    {
       continue;
    }
 
    var numberint = 0;
    if (int.TryParse(numberString, out numberint));
    if (numberint % 2 == 0)
    {
        Console.WriteLine($"El numero {numberString}, es par");
    }
    else
    {
        Console.WriteLine($"El numero {numberString}, es impar");
    }
    else
    {
        Console.WriteLine($"El numero {numberString}, ingresado no es un numero entero");
    }
} while (numberString != "S");
   Console.WriteLine("GAME OVER.").
