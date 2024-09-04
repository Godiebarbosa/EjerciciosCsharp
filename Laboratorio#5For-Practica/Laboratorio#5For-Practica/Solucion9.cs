using System;

namespace Laboratorio5
{
    public static class Solucion9
    {
        public static void CalcularElFactorialDeUnNúmero()
        {
            int numero = 5;
            int factorial = 1;
        
            for (int i = 1 ; i <= numero; i++)
            {
                //multiplicamos el valor actual de factorial por i
                factorial*=i;
            }
        }

    }
}