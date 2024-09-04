using System;

namespace Laboratorio4
{
    public static class Solucion4
    {
        public static void ContarNumPositivosDig()
        {
            int numero; // Declara una variable entera llamada 'numero' para almacenar el número ingresado por el usuario.
            int contador = 0; // Declara una variable entera llamada 'contador' y la inicializa en 0. Esta variable cuenta los números positivos ingresados.

            do // Inicia un bucle 'do-while', que se ejecuta al menos una vez y repite mientras la condición al final sea verdadera.
            {
                Console.Write("Ingresa un número (negativo para terminar): "); // Muestra un mensaje pidiendo al usuario que ingrese un número.
                numero = int.Parse(Console.ReadLine()); // Lee una línea de texto ingresada por el usuario, la convierte a un entero y la guarda en la variable 'numero'.
                
                if (numero >= 0) // Verifica si el número ingresado es mayor o igual a 0.
                {
                    contador++; // Si es positivo (o cero), incrementa el contador en 1.
                }
            } while (numero >= 0); // El bucle se repite mientras 'numero' sea mayor o igual a 0.

            // Una vez que el usuario ingresa un número negativo, se sale del bucle y se ejecuta la siguiente línea.
            Console.WriteLine("Total de números positivos ingresados: " + contador); // Muestra el total de números positivos ingresados en la consola.
        }
    }
}
