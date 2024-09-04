using System;

namespace EjerciciosC
{
    public static class Solucion9
    {
        public static void InvertirNumeroDosCifras()
        {
            /// Imprime el mensaje "Ingresa un número de dos cifras: " en la consola
            Console.Write("Ingresa un número de dos cifras: ");
            /// Declara una variable 'numero' de tipo string y lee la entrada del usuario
            string numero = Console.ReadLine();
            /// Verifica si la longitud del string ingresado es igual a 2 (es decir, si tiene dos cifras)
            if (numero.Length == 2)
            {
                /// Utiliza el método Reverse para invertir el string y lo convierte a un array de caracteres
                string invertido = new string(numero.Reverse().ToArray());
                /// Imprime el número invertido en la consola
                Console.WriteLine("El número invertido es: " + invertido);
            }
            else
            {
                /// Si el número no tiene dos cifras, muestra un mensaje de error
                Console.WriteLine("Por favor, ingresa un número de dos cifras.");
            }
        }
    }
}
