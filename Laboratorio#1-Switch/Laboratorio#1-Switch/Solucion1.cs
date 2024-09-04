using System;

namespace Laboratorio1
{
    public static class Solucion1
    {
  public static void DiaDeLaSemana()
        {
            Console.WriteLine("El día Lunes es el número 1");  
            Console.WriteLine("El día Martes es el número 2");
            Console.WriteLine("El día Miércoles es el número 3"); 
            Console.WriteLine("El día Jueves es el número 4");    
            Console.WriteLine("El día Viernes es el número 5");
            Console.WriteLine("El día Sábado es el número 6"); 
            Console.WriteLine("El día Domingo es el número 7");
            Console.Write("Introduce un número del 1 al 7: ");

            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Número no válido. Debe ser entre 1 y 7.");
                    break;
            }
        }
    }
}