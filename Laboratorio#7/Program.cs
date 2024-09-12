using System;
namespace Lab7
{
    class Program
    {
        public static void Main()
        {
            Solucion1.GenerarLaSecuenciaFibonacci();
            Solucion2.EncontrarElNúmeroPrimoMásCercano();
            Solucion3.SumarDigitosDeUnNumero();
            Solucion4.FactorialRecursivo();
            Solucion5.DibujarUnTriánguloInversoDeAsteriscos();
            Solucion6.NúmeroPalíndromo();
            Solucion7.JuegoDeAdivinanzaConIntentosLimitados();
            Solucion8.MenúInteractivoDeOperacionesMatemáticas();
            Solucion9.SumaDeLosNúmerosPrimosEntre1yn();
            Solucion10.ContarLaFrecuenciaDeCaracteresEnUnaPalabra();
        }
        //1
        public static void GenerarLaSecuenciaFibonacci()
            {
            int v1 = 1;
            int v2 = 2;
            //Mostar el primer numero en 0
            Console.WriteLine(v1);
            //en este caso generamos hasta 15
                for(int i = 0; i < 13; i ++);
                {
                    int temp = v1;
                    v1 = v2;
                    v2 = temp + v1;
                    Console.WriteLine(v1);
                }    
            }
        //2
         public static void EncontrarElNúmeroPrimoMásCercano()
        {
            Console.WriteLine("Ingrese un número:");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                int candidato = num;

                while (candidato > 1)
                {
                    if (EsPrimo(candidato))
                    {
                        Console.WriteLine($"El número primo más cercano menor o igual a {num} es {candidato}");
                        return;
                    }
                    candidato--;
                }

                Console.WriteLine("No hay números primos menores o iguales al número ingresado.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }

        private static bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        //3
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
    
        //4
        public static void FactorialRecursivo()
        {

        }
        //5
        public static void DibujarUnTriánguloInversoDeAsteriscos()
        {
        }
        //6
        public static void NúmeroPalíndromo()
        {
        }
        //7
        public static void JuegoDeAdivinanzaConIntentosLimitados()
        {
        }
        //8
        public static void MenúInteractivoDeOperacionesMatemáticas()
        {
        }
        //9
        public static void SumaDeLosNúmerosPrimosEntre1yn()
        {
        }
        //10
        public static void ContarLaFrecuenciaDeCaracteresEnUnaPalabra()
        {
        }
    }
}