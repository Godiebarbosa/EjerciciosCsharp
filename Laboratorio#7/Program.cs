using System;
namespace Lab7
{
    class Program
    {
        public static void Main()
        {
            Solucion1.GenerarLaSecuenciaFibonacci();
            Solucion2.EncontrarElNúmeroPrimoMásCercano();
            Solucion3.SumarDígitosDeUnNúmero();
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
                for(int i = 0; i <= 13; i ++);
                {
                    int temp = v1;
                    v1 = v2;
                    v2 = temp + v1;

                    Console.WriteLine($"{v1}");
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
        public static void SumarDígitosDeUnNúmero()
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
            Console.Write("Introduce un número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                // Verifica si el número es impar
                if (numero % 2 != 0)
                {
                    // Calcula y muestra el factorial si el número es impar
                    long resultado = CalcularFactorial(numero);
                    Console.WriteLine($"El factorial de {numero} es {resultado}.");
                }
                else
                {
                    // Muestra un mensaje si el número es par
                    Console.WriteLine("No se calcula el factorial de números pares.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }

        // Función para calcular el factorial de un número usando recursión
        static long CalcularFactorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * CalcularFactorial(n - 1);
        }
        //5
  public static void DibujarUnTriánguloInversoDeAsteriscos()
        {
            {
            int n = 5; // Define una variable entera 'n' que representa el número de niveles de la pirámide.
            
            // Inicia un bucle 'for' que itera desde 1 hasta 'n' (inclusive), para cada nivel de la pirámide.
            for (int i = 1; i <= n; i++)
            {
                // Imprimir espacios. Este bucle 'for' imprime espacios antes de los asteriscos en cada línea.
                // La cantidad de espacios disminuye a medida que 'i' aumenta, para centrar la pirámide.
                for (int j = n; j > i; j--)
                {
                    Console.Write(" "); // Imprime un espacio sin saltar de línea.
                }
                
                // Imprimir asteriscos. Este bucle 'for' imprime los asteriscos en cada línea.
                // La cantidad de asteriscos es siempre un número impar: 1, 3, 5, etc.
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*"); // Imprime un asterisco sin saltar de línea.
                }
                
                // Imprime una nueva línea después de cada nivel de la pirámide.
                Console.WriteLine();
        //6
 public static void NúmeroPalíndromo()
        {
                        Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());
            int original = numero, invertido = 0;
            while (numero > 0)
            {
                int digito = numero % 10;
                invertido = invertido * 10 + digito;
                numero /= 10;
            }
            if (original == invertido)
            {
                Console.WriteLine("El número es palíndromo.");
            }
            else
            {
                Console.WriteLine("El número no es palíndromo.");
            }
        }
        //7
public static void JuegoDeAdivinanzaConIntentosLimitados()
        {
            Random rand = new Random();
            int numeroSecreto = rand.Next(1, 101);
            int intentos = 0;
            int maxIntentos = 10;
            int adivinanza;
            
            do
            {
                Console.Write("Adivina el número (1-100): ");
                adivinanza = int.Parse(Console.ReadLine());
                intentos++;
                
                if (adivinanza > numeroSecreto)
                    Console.WriteLine("Demasiado alto.");
                else if (adivinanza < numeroSecreto)
                    Console.WriteLine("Demasiado bajo.");
                
            } while (adivinanza != numeroSecreto && intentos < maxIntentos);

            if (adivinanza == numeroSecreto)
                Console.WriteLine("¡Has adivinado!");
            else
                Console.WriteLine("Has perdido. El número era " + numeroSecreto);
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