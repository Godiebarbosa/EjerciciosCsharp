using System;

namespace Laboratorio5
{
    public static class Solucion2
    {
        public static void SumarNumeros1a5()
        {
                int suma = 0; // Inicializamos una variable para almacenar la suma.
                for (int i = 1; i <= 5; i++) // Iteramos desde 1 hasta 5.
            {
                suma += i; // Suma acumulada: suma = suma + i.
            }
                Console.WriteLine($"La suma es: {suma}");
        }
    }
}