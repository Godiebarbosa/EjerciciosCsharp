using System;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamada a cada método para ejecutar los ejercicios
            Solucion1.DiaDeLaSemana();
            Solucion2.CalcularYError();
            Solucion3.Calificación();
            Solucion4.CalculadoraMenu();
            Solucion5.EstacionesDelAño();
        }

        // 1. Día De La Semana desde lunes de 1 a domingo 7
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

        // 2. Calculadora con manejo de errores
        public static void CalcularYError()
        {
            Console.Write("Introduce el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Introduce un operador (+, -, *, /): ");
            char operador = char.Parse(Console.ReadLine());

            switch (operador)
            {
                case '+':
                    Console.WriteLine($"Resultado: {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Resultado: {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Resultado: {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"Resultado: {num1 / num2}");
                    else
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    break;
                default:
                    Console.WriteLine("Operador no válido.");
                    break;
            }
        }

        // 3. Calificación
        public static void Calificación()
        {
            Console.Write("Introduce una calificación del 1 al 10: ");
            int calificacion = int.Parse(Console.ReadLine());

            switch (calificacion)
            {
                case 10:
                case 9:
                    Console.WriteLine("Excelente");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Muy Bien");
                    break;
                case 6:
                    Console.WriteLine("Bien");
                    break;
                case 5:
                    Console.WriteLine("Suficiente");
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                    Console.WriteLine("Insuficiente");
                    break;
                default:
                    Console.WriteLine("Calificación no válida.");
                    break;
            }
        }

        // 4. Menú de Calculadora
        public static void CalculadoraMenu()
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Elige una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("Introduce el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado de la suma: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado de la resta: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado de la multiplicación: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine($"Resultado de la división: {num1 / num2}");
                    else
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        // 5. Estaciones del Año
        public static void EstacionesDelAño()
        {
            
            Console.WriteLine("Primavera es el número 1");  
            Console.WriteLine("Verano es el número 2");
            Console.WriteLine("Otoño es el número 3"); 
            Console.WriteLine("Invierno es el número 4");  
            Console.Write("Introduce un número del 1 al 4: ");
            int estacion = int.Parse(Console.ReadLine());

            switch (estacion)
            {
                case 1:
                    Console.WriteLine("Primavera");
                    break;
                case 2:
                    Console.WriteLine("Verano");
                    break;
                case 3:
                    Console.WriteLine("Otoño");
                    break;
                case 4:
                    Console.WriteLine("Invierno");
                    break;
                default:
                    Console.WriteLine("Número no válido. Debe ser entre 1 y 4.");
                    break;
            }
        }
    }
}
