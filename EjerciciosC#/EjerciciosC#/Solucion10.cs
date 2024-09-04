using System;

namespace EjerciciosC
{
    public static class Solucion10
    {
        public static void IntercambiarValores()
        {
            /// Imprime el mensaje "Ingresa el valor de A: " en la consola
            Console.Write("Ingresa el valor de A: ");
            /// Declara una variable 'a' de tipo int y lee la entrada del usuario, convirtiéndola a entero
            int a = int.Parse(Console.ReadLine());
            /// Imprime el mensaje "Ingresa el valor de B: " en la consola
            Console.Write("Ingresa el valor de B: ");
            /// Declara una variable 'b' de tipo int y lee la entrada del usuario, convirtiéndola a entero
            int b = int.Parse(Console.ReadLine());
            /// Intercambio de valores: se utiliza una variable temporal 'temp' para almacenar el valor de 'a'
            int temp = a;
            /// Asigna el valor de 'b' a 'a'
            a = b;
            /// Asigna el valor almacenado en 'temp' (originalmente 'a') a 'b'
            b = temp;
            /// Imprime el valor de 'a' después del intercambio
            Console.WriteLine("Después del intercambio, el valor de A es: " + a);
            /// Imprime el valor de 'b' después del intercambio
            Console.WriteLine("Después del intercambio, el valor de B es: " + b);
        }
    }
}