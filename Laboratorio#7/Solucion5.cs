using System;

namespace Lab7
{
    public static class Solucion5
    {
        public static void DibujarUnTriánguloInversoDeAsteriscos()
    {
            {
            int n = 5; // Define una variable entera 'n' que representa el número de niveles de la pirámide.
            
            // Inicia un bucle 'for' que itera desde 1 hasta 'n' (inclusive), para cada nivel de la pirámide.
            for (int i = 1; i <= n; i++)
            {
                // Imprimir espacios. Este bucle 'for' imprime espacios antes de los asteriscos en cada línea.
                // La cantidad de espacios disminuye a medida que 'i' aumenta, para centrar la pirámide.
                for (int j = n; j > i; j--)
                {
                    Console.Write(" "); // Imprime un espacio sin saltar de línea.
                }
                
                // Imprimir asteriscos. Este bucle 'for' imprime los asteriscos en cada línea.
                // La cantidad de asteriscos es siempre un número impar: 1, 3, 5, etc.
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*"); // Imprime un asterisco sin saltar de línea.
                }
                
                // Imprime una nueva línea después de cada nivel de la pirámide.
                Console.WriteLine();
            }
        }
    }
    }
}