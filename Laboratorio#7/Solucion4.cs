using System;

namespace Lab7
{
    public static class Solucion4
    {
        public static void FactorialRecursivo()
 {
            Console.Write("Introduce un número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                // Verifica si el número es impar
                if (numero % 2 != 0)
                {
                    // Calcula y muestra el factorial si el número es impar
                    long resultado = CalcularFactorial(numero);
                    Console.WriteLine($"El factorial de {numero} es {resultado}.");
                }
                else
                {
                    // Muestra un mensaje si el número es par
                    Console.WriteLine("No se calcula el factorial de números pares.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }

        // Función para calcular el factorial de un número usando recursión
        static long CalcularFactorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * CalcularFactorial(n - 1);
        }
    }
}