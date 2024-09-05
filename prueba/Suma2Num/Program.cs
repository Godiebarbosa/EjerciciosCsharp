using System;
namespace Program1
{
    class Program   
    {
        static void Main(string[] args)
        {

        }
        //Suma Dos Numeros
        static void Main()
        {
            Console.WriteLine("Dijite el primer numero a sumar");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Dijite el segundo numero a sumar");
            int i2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i} + {i2} = {i + i2} ");
        }
    }
}