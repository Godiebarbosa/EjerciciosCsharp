using System;

namespace Laboratorio5
{
    public static class Solucion5
    {
        public static void ImprimirElementosDeUnArreglo()
        {
            int[] numeros = { 1, 2, 3, 4, 5 }; // Declaramos un arreglo deenteros.
            for (int i = 0; i < numeros.Length; i++) // Iteramos desde 0 hastala longitud del arreglo.
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}