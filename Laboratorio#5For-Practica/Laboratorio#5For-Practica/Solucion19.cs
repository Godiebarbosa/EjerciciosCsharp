using System;

namespace Laboratorio5
{
    public static class Solucion19
    {
        public static void OperacionesBásicasDeCalculad()
        {
            Console.Write("Ingrese el primer numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("ingrese una operacion ( +, -, *, /): ");
            char operacion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (operacion)
            {
                case '+':
                Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                break;
                case '-':
                Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                break;
                case '*':
                Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                break;
                case '/':
                    if(num2 !=0)
                    {
                        Console.WriteLine($"Resultado {num1} / {num2} = {num1 / num2}");
                    } 
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    break;
                    default:
                Console.WriteLine("Operación no válida");
                break;
            }
        }
    }
}