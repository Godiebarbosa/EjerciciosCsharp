using System;

namespace EjerciciosC
{
    public static class Solucion8
    {
        public static void RaizCuadradaYCubica()
        {
            /// Imprime el mensaje "Ingresa un número: " en la consola
            Console.Write("Ingresa un número: ");
            /// Declara una variable 'num' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num = double.Parse(Console.ReadLine());
            /// Calcula la raíz cuadrada del número ingresado usando Math.Sqrt y la almacena en la variable 'raizCuadrada'
            double raizCuadrada = Math.Sqrt(num);
            /// Calcula la raíz cúbica del número ingresado usando Math.Cbrt y la almacena en la variable 'raizCubica'
            double raizCubica = Math.Cbrt(num);
            /// Imprime el resultado de la raíz cuadrada en la consola
            Console.WriteLine("La raíz cuadrada de " + num + " es: " + raizCuadrada);
            /// Imprime el resultado de la raíz cúbica en la consola
            Console.WriteLine("La raíz cúbica de " + num + " es: " + raizCubica);
        }
    }
}