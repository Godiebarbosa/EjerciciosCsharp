using System;
namespace Program1
{
    public static class sum2num
    {
        public static void imprimeNumeros1a10()
        {
            Console.WriteLine("Dijite el primer numero a sumar");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Dijite el segundo numero a sumar");
            int i2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i} + {i2} = {i + i2} ");
        }
    }
    
}