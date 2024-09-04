using System;

namespace Laboratorio5
{
    public static class Solucion17
    {
        public static void AdivinarUnNúmeroHastaAcertar()
        {
            //establecemos un numero secreto
            int numerosecreto = 7;
            int intento;
            do
            {
                Console.Write("Adivine el numero secreto: ");
                intento = int.Parse(Console.ReadLine());
                if (intento != numerosecreto)
                {
                    Console.WriteLine("incorrecto, intentelo de nuevo");
                }
            } 
            while (intento != numerosecreto);

            Console.WriteLine("¡Correcto! has adivinado el numero secreto.");
        }  
    }
}