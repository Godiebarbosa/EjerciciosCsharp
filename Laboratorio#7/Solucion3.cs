using System;

namespace Lab7
{
    public static class Solucion3
    {
        public static void SumarDigitosDeUnNumero()
        {
            int num;  // Variable para almacenar el número ingresado por el usuario
            
            do
            {
                // Solicita al usuario que ingrese un número entero
                Console.Write("Digite un número entero (0 para salir): ");
                
                // Lee la entrada del usuario como una cadena
                string entrada = Console.ReadLine();
                
                // Intenta convertir la cadena a un número entero
                // Si la conversión falla, num se establece en 0
                if (!int.TryParse(entrada, out num))
                {
                    // Si la entrada no es un número entero, muestra un mensaje de error
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
                    continue; // Vuelve al inicio del bucle para pedir la entrada nuevamente
                }

                // Si el número ingresado no es 0, calcula y muestra la suma de los dígitos
                if (num != 0)
                {
                    int suma = SumarDigitos(num); // Llama a la función SumarDigitos para calcular la suma
                    Console.WriteLine($"La suma de los dígitos del número {num} es {suma}.");
                }
                
            } while (num != 0); // El bucle se repite hasta que el usuario ingrese 0
        }

        // Función para calcular la suma de los dígitos de un número entero
        static int SumarDigitos(int numero)
        {
            int suma = 0; // Variable para almacenar la suma de los dígitos
            
            // Mientras el número sea mayor que 0
            while (numero > 0)
            {
                // Suma el último dígito del número a la variable suma
                suma += numero % 10;
                // Elimina el último dígito del número
                numero /= 10;
            }
            
            // Devuelve la suma total de los dígitos
            return suma;
        }
    }
}
