using System;

namespace Laboratorio5
{
    public static class Solucion4
    {
        public static void ImrpimeTablaDeMultiplicar()
        {
        int numero = 3; // Declaramos el número de la tabla
        for (int i = 1; i <= 10; i++) // Bucle que va del 1 al 10
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}"); // Imprime la multiplicación
        }

        }
    }
}
