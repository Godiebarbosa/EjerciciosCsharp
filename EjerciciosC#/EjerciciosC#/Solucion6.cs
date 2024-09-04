using System;

namespace EjerciciosC
{
    public static class Solucion6
    {
        public static void DescuentoEnCompra()
        {
            /// Imprime el mensaje "Ingresa el monto total de la compra: " en la consola
            Console.Write("Ingresa el monto total de la compra: ");
            /// Declara una variable 'montoCompra' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double montoCompra = double.Parse(Console.ReadLine());
            /// Calcula el descuento como el 15% del monto total de la compra
            double descuento = montoCompra * 0.15;
            /// Calcula el monto final restando el descuento del monto total de la compra
            double montoFinal = montoCompra - descuento;
            /// Imprime el descuento calculado en la consola
            Console.WriteLine("El descuento es: " + descuento);
            /// Imprime el monto final calculado en la consola
            Console.WriteLine("El monto final a pagar es: " + montoFinal);
        }
    }
}