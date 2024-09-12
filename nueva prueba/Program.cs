using System;

class Program
{
        static void Main()
    {
            {
            int n = 1; // Define una variable entera 'n' que representa el número de niveles de la pirámide.
            
            // Inicia un bucle 'for' que itera desde 1 hasta 'n' (inclusive), para cada nivel de la pirámide.
            for (int i = 5; i >= n; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
