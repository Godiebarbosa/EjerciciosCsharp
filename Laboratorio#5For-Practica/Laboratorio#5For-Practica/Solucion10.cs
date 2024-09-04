using System;

namespace Laboratorio5
{
    public static class Solucion10
    {
        public static void MostrarUnaFiguraDeAsteriscos()
        {
            int filas = 5;
            for (int i = 1 ; i <= filas; i++)
            {
                //Bucle anidado que imprime los asteriscos
                for (int j= 1; j<= i; j++)
                {
                    Console.WriteLine("*");
                }
            //imprime una nueva linea al final de cada fila
            Console.WriteLine();
            }
        }
    }
}