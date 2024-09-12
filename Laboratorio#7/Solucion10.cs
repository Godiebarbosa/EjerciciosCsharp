using System;

namespace Lab7
{
    public static class Solucion10
    {
        public static void ContarLaFrecuenciaDeCaracteresEnUnaPalabra()
    {
                    // Solicitar al usuario que ingrese una palabra
        Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine();

        // Diccionario para almacenar la frecuencia de cada carácter
        Dictionary<char, int> frecuencia = new Dictionary<char, int>();

        // Bucle foreach que recorre cada letra de la palabra
        foreach (char letra in palabra)
        {
            // Si la letra ya está en el diccionario, incrementamos su valor
            if (frecuencia.ContainsKey(letra))
            {
                frecuencia[letra]++;
            }
            else
            {
                // Si la letra no está en el diccionario, la añadimos con un valor de 1
                frecuencia[letra] = 1;
            }
        }

        // Mostrar la frecuencia de cada letra
        Console.WriteLine("Frecuencia de caracteres:");
        foreach (var par in frecuencia)
        {
            Console.WriteLine($"{par.Key}: {par.Value}");
        }
    }
    }
}