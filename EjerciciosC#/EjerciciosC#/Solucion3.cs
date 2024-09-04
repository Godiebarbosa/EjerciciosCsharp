using System;

namespace EjerciciosC
{
    public static class Solucion3
    {
        public static void MediaDeTresNumeros()
        {
            /// Imprime el mensaje "Ingresa el primer número: " en la consola
            Console.Write("Ingresa el primer número: ");
            /// Declara una variable 'num1' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num1 = double.Parse(Console.ReadLine());
            /// Imprime el mensaje "Ingresa el segundo número: " en la consola
            Console.Write("Ingresa el segundo número: ");
            /// Declara una variable 'num2' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num2 = double.Parse(Console.ReadLine());
            /// Imprime el mensaje "Ingresa el tercer número: " en la consola
            Console.Write("Ingresa el tercer número: ");
            /// Declara una variable 'num3' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num3 = double.Parse(Console.ReadLine());
            /// Calcula la media de los tres números sumándolos y dividiéndolos entre 3
            double media = (num1 + num2 + num3) / 3;
            /// Imprime el resultado de la media en la consola
            Console.WriteLine("La media de los tres números es: " + media);
        }
    }
}