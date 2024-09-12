using System;

namespace Laboratorio5
{
    public static class Solucion2
    {
        public static void SumarNumeros1a5()
        {
        int suma = 0; // Inicializamos la variable suma en 0
        for (int i = 1; i <= 5; i++) // Bucle que va del 1 al 5
            {
                suma += i; // Suma el valor de i a la variable suma
            }
            Console.WriteLine($"La suma es: {suma}"); // Muestra la suma total
        }
    }
}