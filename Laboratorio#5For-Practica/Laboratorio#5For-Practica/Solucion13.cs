using System;

namespace Laboratorio5
{
    public static class Solucion13
    {
            public static void ContarHastaUnNúmeroDadoPorElUsuario()
        {
            Console.Write("Ingrese un numero: ");
            //convertimos el texto ingresado a numero
            int n = int.Parse(Console.ReadLine());
            //Inicializamos i en 1
            int i =1 ; 
            //Mientras i sea menor o igual a n
            while(i<=n)
            {
                Console.WriteLine(i);
                i++;//Incrementamos i en 1
            }
        }
    }
}