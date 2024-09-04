using System;

namespace Laboratorio4
{
    public static class Solucion2
    {
        public static void Suma1aumentandoa10()
        {
            int suma = 0; // Declara una variable llamada 'suma' y la inicializa en 0. Esta variable almacenará la suma total.
            int i = 1; // Declara una variable llamada 'i' y la inicializa en 1. 'i' se usará como contador.

            while(i <= 10) // Inicia un bucle 'while' que se ejecutará mientras 'i' sea menor o igual a 10.
            {
                suma += i; // Suma el valor actual de 'i' a 'suma'. Es equivalente a 'suma = suma + i'.
                i++; // Incrementa el valor de 'i' en 1. Es equivalente a 'i = i + 1'.
            } 
            
            {
                Console.WriteLine($"la suma de los numeros es: {suma}"); // Muestra el resultado de la suma en la consola.
            }
        }
    }
}

