using System;

namespace EjerciciosC
{
    public static class Solucion1
    {
        public static void DatosPersonales()
        {
            /// Muestra un mensaje en la consola solicitando el nombre del usuario
            Console.Write("¿Cuál es tu nombre?");
            /// Declara una variable 'nombre' y almacena la entrada del usuario
            string nombre = Console.ReadLine();
            /// Muestra un mensaje en la consola solicitando la edad del usuario
            Console.Write("¿Cual es tu edad?");
            /// Declara una variable 'edad', convierte la entrada a entero y la almacena
            int edad = int.Parse(Console.ReadLine());
            /// Muestra un mensaje en la consola preguntando si el usuario trabaja
            Console.Write("¿trabajas?");
            /// Declara una variable 'trabajo' y almacena la respuesta del usuario
            string trabajo = Console.ReadLine();
            /// Muestra un mensaje en la consola preguntando si el usuario estudia
            Console.Write("¿Estudias?");
            /// Declara una variable 'estudio' y almacena la respuesta del usuario
            string estudio = Console.ReadLine();
            /// Muestra en la consola los datos recolectados formateados en una línea
            Console.WriteLine(" nombre : " + nombre + " edad  : " + edad + " ¿trabajas? : " + trabajo + " ¿estudias? " + estudio + "");
        }   
    }
}