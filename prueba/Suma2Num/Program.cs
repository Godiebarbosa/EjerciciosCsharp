using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum2Num();
            Calculadora();
            CalcularRaizCuadrada();
        }

        // Suma Dos Numeros
        static void Sum2Num()
        {
            try
            {
                Console.WriteLine("Digite el primer numero a sumar:");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero a sumar:");
                int i2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{i} + {i2} = {i + i2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero.");
            }
        }

        // Calculadora de todas las operaciones
        static void Calculadora()
        {
            try
            {
                Console.WriteLine("Digite la operación a utilizar:");
                Console.WriteLine("1 = suma");
                Console.WriteLine("2 = resta");
                Console.WriteLine("3 = multiplicación");
                Console.WriteLine("4 = división");
                
                int operacion = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite el primer número:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el segundo número:");
                int num2 = int.Parse(Console.ReadLine());
                
                switch (operacion)
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
                            Console.WriteLine($"Resultado: {num1} / {num2} = {(double)num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: División por cero no permitida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Operación inválida.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número entero.");
            }
        }

        // Calcular la raíz cuadrada
        public static void CalcularRaizCuadrada()
        {
            try
            {
                Console.WriteLine("Ingrese el número del cual desea obtener la raíz cuadrada:");
                double numero = double.Parse(Console.ReadLine());
                
                if (numero < 0)
                {
                    Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                }
                else
                {
                    double resultado = Math.Sqrt(numero);
                    Console.WriteLine($"La raíz cuadrada de {numero} es {resultado}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
            }
        }
    }
}
