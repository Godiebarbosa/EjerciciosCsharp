using System;

namespace Lab7
{
    public static class Solucion8
    {
        public static void MenúInteractivoDeOperacionesMatemáticas() 
    {
        int opcion;
        do
        {
            Console.WriteLine("Menú de Operaciones Matemáticas:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion >= 1 && opcion <= 5)
            {
                Console.Write("Introduce el primer número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Introduce el segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;
                    case 4:
                        if (num2 != 0)
                            Console.WriteLine($"Resultado: {num1 / num2}");
                        else
                            Console.WriteLine("No se puede dividir por cero.");
                        break;
                    case 5:
                        Console.WriteLine($"Resultado: {Math.Pow(num1, num2)}");
                        break;
                }
            }
            else if (opcion != 6)
            {
                Console.WriteLine("Opción no válida.");
            }

        } while (opcion != 6);
        Console.WriteLine("Programa finalizado.");
    }
}
       
    }
    }
}