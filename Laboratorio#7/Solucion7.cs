using System;

namespace Lab7
{
    public static class Solucion7
    {
        public static void JuegoDeAdivinanzaConIntentosLimitados()
        {
            Random rand = new Random();
            int numeroSecreto = rand.Next(1, 101);
            int intentos = 0;
            int maxIntentos = 10;
            int adivinanza;
            
            do
            {
                Console.Write("Adivina el número (1-100): ");
                adivinanza = int.Parse(Console.ReadLine());
                intentos++;
                
                if (adivinanza > numeroSecreto)
                    Console.WriteLine("Demasiado alto.");
                else if (adivinanza < numeroSecreto)
                    Console.WriteLine("Demasiado bajo.");
                
            } while (adivinanza != numeroSecreto && intentos < maxIntentos);

            if (adivinanza == numeroSecreto)
                Console.WriteLine("¡Has adivinado!");
            else
                Console.WriteLine("Has perdido. El número era " + numeroSecreto);
        }      
    }
}