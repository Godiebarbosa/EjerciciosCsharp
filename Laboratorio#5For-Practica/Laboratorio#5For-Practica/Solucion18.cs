using System;

namespace Laboratorio5
{
    public static class Solucion18
    {
        public static void DeterminarElDíaDeLaSemana()
        {
            Console.Write("ingrese un numero del 1 al 7 para el dia de la semana");
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
                Console.WriteLine("Miercoles");
                break;
                case 4:
                Console.WriteLine("Jueves");
                break;
                case 5:
                Console.WriteLine("Viernes");
                break;
                case 6:
                Console.WriteLine("Sabado");
                break;
                case 7:
                Console.WriteLine("Domingo");
                break;
            }
        }
    }
}