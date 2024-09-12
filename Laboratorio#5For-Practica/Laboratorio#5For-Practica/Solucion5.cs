using System;

namespace Laboratorio5
{
    public static class Solucion5
    {
        public static void ImprimirElementosDeUnArreglo()
        {
            int[] numeros = { 1, 2, 3, 4, 5 }; // Declaramos un arreglo de enteros
            for (int i = 0; i < numeros.Length; i++) // Bucle que recorre el arreglo
            {
                Console.WriteLine(numeros[i]); // Imprime cada elemento del arreglo
            }

        }
    }
}