//
Console.WriteLine("Ingrese el primer número:");
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Ingrese la operación (+, -, *, /):");
string operation = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Ingrese el segundo número:");
int number2 = int.Parse(Console.ReadLine() ?? "0");

switch(operation)
{
    case "+":
        Console.WriteLine("El resultado es: " + (number1 + number2));
        break;
    case "-":
        Console.WriteLine("El resultado es: " + (number1 - number2));
        break;
    case "*":
        Console.WriteLine("El resultado es: " + (number1 * number2));
        break;
    case "/":
        if (number2 != 0)
        {
            Console.WriteLine("El resultado es: " + ((double)number1 / number2));
        }
        else if (number2 == 0) {
            Console.WriteLine("Error: División por cero no es permitida.");
        }
        else {
            Console.WriteLine("Indefinido");
        }
        break;
}