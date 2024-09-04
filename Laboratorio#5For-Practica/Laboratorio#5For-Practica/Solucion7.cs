using System;

namespace Laboratorio5
{
    public static class Solucion7
    {
        public static void InvertirUnaCadena()
        {
            string texto = "Hola";
            string invertido = "";
            for (int i = texto.Length - 1; i >= 0; i--) // Comenzamos desde el último carácter.
            {
                invertido += texto[i]; // Agregamos cada letra al inicio del texto invertido.
            }
            {
                Console.WriteLine(invertido);
            }
        }
        
    }
}