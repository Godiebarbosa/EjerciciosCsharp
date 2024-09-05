using System;
namespace Program1
{
    public static class calculadora
    {
        public  static void Calculadora()
        {
            Console.WriteLine("Dijite Operacion a utililizar");
            string operacion = Console.ReadLine(":");
            Console.Write("1 = suma");
            Console.Write("2 = resta");
            Console.Write("3 = multiplicacion");
            Console.Write("4 = division");

            Console.WriteLine("Dijite el primer numero a sumar");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dijite el segundo numero a sumar");
            int num2 = int.Parse(Console.ReadLine());
            switch(operacion)//evalua la operacion +,-,*,/
            {
                case 1:
                Console.WriteLine($"resultado: {num1} + {num2} = {num1 + num2}");
                break;
                case 2:
                Console.WriteLine($"resultado: {num1} - {num2} = {num1 - num2}");
                break;
                case 3:
                Console.WriteLine($"resultado: {num1} + {num2} = {num1 }");
                break;
                case 4:
                if (num2 != 0) //Verifica que no haya division por cero
                {
                    Console.WriteLine($"Resultado: {num1} / {num2} {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: Division por cero no permitida.");
                }
                break;
            default:
            Console.WriteLine("Operacion Invalida");
            break;
            }
        }
    }
}