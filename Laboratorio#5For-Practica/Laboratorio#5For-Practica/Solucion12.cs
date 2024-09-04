using System;

namespace Laboratorio5
{
    public static class Solucion12
    {
        public static void SumarNúmerosHastaQueElUsuarioIngrese0()
        {
            //variable para almacenar la suma.
            int suma = 0;
            int numero;

            Console.Write("ingrese un numero (0 para terminar):");
            //convertimos el texto a numero
            numero = int.Parse(Console.ReadLine());
            //El bucle se ejecuta mientras el numero no sea 0
            while (numero != 0 )
            {
                suma += numero;
                Console.Write("Ingrese otro numnero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());
            }
        Console.WriteLine($"La suma total es : {suma}");
        }
    }
}
