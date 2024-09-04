using System;

namespace EjerciciosC
{
    public static class Solucion2
    {
        public static void OperacionesMatematicas()
        {
            /// Imprime el mensaje "Ingresa el primer número: " en la consola
            Console.Write("Ingresa el primer número: ");
            /// Declara una variable 'num1' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num1 = double.Parse(Console.ReadLine());
            /// Imprime el mensaje "Ingresa el segundo número: " en la consola
            Console.Write("Ingresa el segundo número: ");
            /// Declara una variable 'num2' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num2 = double.Parse(Console.ReadLine());   
            /// Realiza la suma de 'num1' y 'num2' y muestra el resultado en la consola
            Console.WriteLine("Suma: " + (num1 + num2));
            /// Realiza la resta de 'num1' y 'num2' y muestra el resultado en la consola
            Console.WriteLine("Resta: " + (num1 - num2));
            /// Realiza la multiplicación de 'num1' y 'num2' y muestra el resultado en la consola
            Console.WriteLine("Multiplicación: " + (num1 * num2));
            /// Verifica si 'num2' es diferente de cero antes de realizar la división
            if (num2 != 0)
            {
                /// Realiza la división de 'num1' entre 'num2' y muestra el resultado en la consola
                Console.WriteLine("División: " + (num1 / num2));
            }
            else
            {
                /// Imprime un mensaje indicando que no se puede dividir entre cero
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }
    }
}