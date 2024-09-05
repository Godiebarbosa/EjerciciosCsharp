using System;

namespace Lab7
{
    public static class Solucion1
    {
        public static void GenerarLaSecuenciaFibonacci()
            {
            int v1 = 0;
            int v2 = 1;
            //Mostar el primer numero en 0
            Console.WriteLine(v1);
            //en este caso generamos hasta 15
                for(int i = 0; i < 15; i ++);
                {
                    int temp = v1;
                    v1 = v2;
                    v2 = temp + v1;
                    Console.WriteLine(v1);
                }    
            }
    }
}