using System;

namespace EjerciciosC
{
    public static class Solucion7
    {
        public static void DistanciaEntreNumeros()
        {
            Console.Write("Ingresa el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            
            Console.Write("Ingresa el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            
            double distancia = Math.Abs(num1 - num2);
            
            Console.WriteLine("La distancia entre los dos números es: " + distancia);
        }
    }
}