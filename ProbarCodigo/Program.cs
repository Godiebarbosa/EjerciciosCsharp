using System;

class Lab7
{
        static void Main()
            {
            int v1 = 1;
            int v2 = 2;
            //Mostar el primer numero en 0
            Console.WriteLine(v1);
            //en este caso generamos hasta 15
                for(int i = 0; i <= 13; i ++);
                {
                    int temp = v1;
                    v1 = v2;
                    v2 = temp + v1;

                    Console.WriteLine($"{v1}");
                }    
            }
    }