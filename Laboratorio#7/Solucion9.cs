using System;

namespace Lab7
{
    public static class Solucion9
    {
        public static void SumaDeLosNúmerosPrimosEntre1yn()
        {
            {
                Console.Write("Introduce un número n: ");
                int n = int.Parse(Console.ReadLine());
                int sumaPrimos = 0;

                for (int i = 2; i <= n; i++)
                {
                    if (EsPrimo(i))
                    {
                        sumaPrimos += i;
                    }
                }

                Console.WriteLine($"La suma de los números primos entre 1 y {n} es: {sumaPrimos}");
            }

            static bool EsPrimo(int numero)
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}