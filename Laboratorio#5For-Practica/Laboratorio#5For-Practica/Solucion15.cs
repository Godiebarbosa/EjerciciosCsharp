using System;

namespace Laboratorio5
{
    public static class Solucion15
    {
            public static void ContarCuántasVecesApareceUnNúmero()
        {
            int contador = 0;
            int numero;

            Console.WriteLine("Ingrese un numero(0 para terminar): ");
            numero = int.Parse(Console.ReadLine());

            while(numero != 0)
            {
                //comprobamos si el numero es 5
                if(numero==5)
            
                {
                    contador++;
                }
                Console.Write("Ingrese otro numero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El numero 5 fue ingresado {contador} veces");
        }
    }
}