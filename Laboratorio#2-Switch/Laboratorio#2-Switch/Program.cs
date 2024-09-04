using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamada a cada método para ejecutar los ejercicios
            Solucion1.ConversorDeUnidades();
            Solucion2.MenuMatematico();
            Solucion3.Calificación();
        }
            //1
        public static void ConversorDeUnidades()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Conversor de Unidades de Longitud:");
                Console.WriteLine("1. Metros a Centímetros");
                Console.WriteLine("2. Metros a Pulgadas");
                Console.WriteLine("3. Metros a Pies");
                Console.WriteLine("4. Centímetros a Metros");
                Console.WriteLine("5. Pulgadas a Metros");
                Console.WriteLine("6. Pies a Metros");
                Console.WriteLine("7. Salir");
                Console.Write("Elige una opción: ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                    Console.Write("Introduce la cantidad en metros: ");
                    double metros = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{metros} metros son {metros * 100} centímetros.");
                    break;
                    case 2:
                    Console.Write("Introduce la cantidad en metros: ");
                    metros = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{metros} metros son {metros * 39.3701} pulgadas.");
                    break;
                    case 3:
                    Console.Write("Introduce la cantidad en metros: ");
                    metros = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{metros} metros son {metros * 3.28084} pies.");
                    break;
                    case 4:
                    Console.Write("Introduce la cantidad en centímetros: ");
                    double centimetros = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{centimetros} centímetros son {centimetros / 100} metros.");
                    break;
                    case 5:
                    Console.Write("Introduce la cantidad en pulgadas: ");
                    double pulgadas = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{pulgadas} pulgadas son {pulgadas / 39.3701} metros.");
                    break;
                    case 6:
                    Console.Write("Introduce la cantidad en pies: ");
                    double pies = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{pies} pies son {pies / 3.28084} metros.");
                    break;
                    case 7:
                    continuar = false;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                    default:
                    Console.WriteLine("Opción no válida.");
                    break;
                }
            Console.WriteLine();
            }
        }
             //2
               public static void MenuMatematico()
        {
        bool continuar = true;
        while (continuar)
            {
            Console.WriteLine("Menú de Operaciones Matemáticas:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.Write("Introduce el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            switch (opcion)
                {
                case 1:
                Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                break;
                case 2:
                Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                break;
                case 3:
                Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                break;
                case 4:
                if (num2 != 0)
                {
                Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                Console.WriteLine("Error: División por cero.");
                }
                break;
                case 5:
                continuar = false;
                Console.WriteLine("Saliendo del programa...");
                break;
                default:
                Console.WriteLine("Opción no válida.");
                break;
                }
            Console.WriteLine();
            }
        }
            //3
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