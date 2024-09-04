using System;

namespace EjerciciosC
{
    public static class Solucion4
    {
        public static void MinutosAHoras()
        {
            /// Imprime el mensaje "Ingresa una cantidad de minutos: " en la consola
            Console.Write("Ingresa una cantidad de minutos: ");
            /// Declara una variable 'minutos' de tipo int y lee la entrada del usuario, convirtiéndola a un entero
            int minutos = int.Parse(Console.ReadLine());
            /// Calcula el número de horas dividiendo los minutos entre 60
            int horas = minutos / 60;
            /// Calcula los minutos restantes usando el operador módulo para obtener el resto de la división
            int minutosRestantes = minutos % 60;
            /// Imprime el resultado en la consola, mostrando la cantidad de horas y minutos restantes
            Console.WriteLine(minutos + " minutos son " + horas + " horas y " + minutosRestantes + " minutos.");
        }
    }
}