using System;

namespace Laboratorio5
{
    public static class Solucion4
    {
        public static void ImrpimeTablaDeMultiplicar()
        {
            int numero = 3;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
