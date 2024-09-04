using System;

namespace Laboratorio2
{
    public static class Solucion1
    {
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
    }
}