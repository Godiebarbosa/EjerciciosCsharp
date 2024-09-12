using System;

namespace Lab7
{
    public static class Solucion2
    {
        public static void EncontrarElNúmeroPrimoMásCercano()
        {
            Console.WriteLine("Ingrese un número:");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                int candidato = num;

                while (candidato > 1)
                {
                    if (EsPrimo(candidato))
                    {
                        Console.WriteLine($"El número primo más cercano menor o igual a {num} es {candidato}");
                        return;
                    }
                    candidato--;
                }

                Console.WriteLine("No hay números primos menores o iguales al número ingresado.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }

        private static bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }   
}