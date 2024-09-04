using System;

namespace EjerciciosC
{
    public static class Solucion5
    {
        public static void SueldoConComision()
        {
            /// Imprime el mensaje "Ingresa el salario base del vendedor: " en la consola
            Console.Write("Ingresa el salario base del vendedor: ");
            /// Declara una variable 'sueldoBase' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double sueldoBase = double.Parse(Console.ReadLine());
            /// Imprime el mensaje "Ingresa el monto total de ventas: " en la consola
            Console.Write("Ingresa el monto total de ventas: ");
            /// Declara una variable 'ventas' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double ventas = double.Parse(Console.ReadLine());
            /// Calcula la comisión como el 10% de las ventas y la almacena en la variable 'comision'
            double comision = ventas * 0.10;
            /// Calcula el salario total sumando el sueldo base y la comisión
            double salarioTotal = sueldoBase + comision;
            /// Imprime la comisión calculada en la consola
            Console.WriteLine("La comisión es: " + comision);
            /// Imprime el salario total calculado en la consola
            Console.WriteLine("El salario total es: " + salarioTotal);
        }
    }
}