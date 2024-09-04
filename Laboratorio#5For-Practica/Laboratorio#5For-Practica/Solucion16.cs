using System;

namespace Laboratorio5
{
    public static class Solucion16
    {
        public static void SumarNúmerosIngresadosHastaQueElUsuarioIngrese0()
        {
            int suma = 0;
            int numero ;
            do
            {
                Console.Write("ingrese un numero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
            }
            while (numero != 0);
            Console.WriteLine($"La suma total es : {suma}");
        }
    }
}