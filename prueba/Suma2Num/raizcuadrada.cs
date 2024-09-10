using System;

namespace Program1
{
    public static class RaizCuadrada
    {
        public static void CalcularRaizCuadrada()
        {
            Console.WriteLine("Ingrese el número del cual desea obtener la raíz cuadrada:");
            // Leer la entrada del usuario y convertirla a un tipo double
            double numero = double.Parse(Console.ReadLine());

            // Calcular la raíz cuadrada usando Math.Sqrt
            double resultado = Math.Sqrt(numero);

            // Mostrar el resultado
            Console.WriteLine($"La raíz cuadrada de {numero} es {resultado}");
        }
    }
}
