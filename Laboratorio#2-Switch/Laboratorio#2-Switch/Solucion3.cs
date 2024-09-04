using System;

namespace Laboratorio2
{
    public static class Solucion3
    {
  public static void Calificación()
        {
        Console.Write("Introduce la calificación (0-100): ");
        int calificacion = int.Parse(Console.ReadLine());
        switch (calificacion / 10)
            {
            case 10:
            case 9:
            Console.WriteLine("Calificación: A");
            break;
            case 8:
            Console.WriteLine("Calificación: B");
            break;
            case 7:
            Console.WriteLine("Calificación: C");
            break;
            case 6:
            Console.WriteLine("Calificación: D");
            break;
            default:
            Console.WriteLine("Calificación: F");
            break;
            }
        }
    }
}