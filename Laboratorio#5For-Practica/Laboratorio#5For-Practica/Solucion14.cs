using System;

namespace Laboratorio5
{
    public static class Solucion14
    {
        public static void EncontrarElMayorNúmeroIngresadoPorElUsuario()
        {
            //inicializamos con el valor
            //mas bajo posible de un entero 
            int mayor = int.MinValue;
            int numero;

            Console.Write("Ingrese un numero (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());

            while(numero != 0)
            {
                //comparamos el numero
                //ingresado con el numero
                //mayor actual
                if (numero > mayor)
                {
                    //actualizamos el mayor si 
                    // el numero ingresado es mas grande
                    mayor = numero; 
                }
                Console.Write("ingrese otro numero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());
            }    
            Console.WriteLine($"El numero mayor es : {mayor}");
        }
    }
}