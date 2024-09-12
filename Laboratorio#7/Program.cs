using System;
using System.Collections.Generic;

namespace Lab7
{
    class Program
    {
        public static void Main()
        {
            // Llamada a los métodos para ejecutar cada funcionalidad
            GenerarLaSecuenciaFibonacci();
            EncontrarElNúmeroPrimoMásCercano();
            SumarDigitosDeUnNumero();
            FactorialRecursivo();
            DibujarUnTriánguloInversoDeAsteriscos();
            NúmeroPalíndromo();
            JuegoDeAdivinanzaConIntentosLimitados();
            MenúInteractivoDeOperacionesMatemáticas();
            SumaDeLosNúmerosPrimosEntre1yn();
            ContarLaFrecuenciaDeCaracteresEnUnaPalabra();
        }

        // 1. Generar la secuencia de Fibonacci
        public static void GenerarLaSecuenciaFibonacci()
        {
            int v1 = 1;
            int v2 = 2;

            // Mostrar el primer número de la secuencia
            Console.WriteLine(v1);

            // Generar los siguientes 14 números de la secuencia (hasta 15 en total)
            for (int i = 0; i < 14; i++)
            {
                int temp = v1;
                v1 = v2;
                v2 = temp + v1;

                Console.WriteLine($"{v1}");
            }
        }

        // 2. Encontrar el número primo más cercano menor o igual al ingresado
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

        // 3. Sumar los dígitos de un número
        public static void SumarDigitosDeUnNumero()
        {
            int num;

            do
            {
                Console.Write("Digite un número entero (0 para salir): ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out num))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
                    continue;
                }

                if (num != 0)
                {
                    int suma = SumarDigitos(num);
                    Console.WriteLine($"La suma de los dígitos del número {num} es {suma}.");
                }

            } while (num != 0);
        }

        // Función para calcular la suma de los dígitos de un número entero
        static int SumarDigitos(int numero)
        {
            int suma = 0;
            while (numero > 0)
            {
                suma += numero % 10;
                numero /= 10;
            }
            return suma;
        }

        // 4. Calcular el factorial de un número impar usando recursión
        public static void FactorialRecursivo()
        {
            Console.Write("Introduce un número: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero % 2 != 0)
                {
                    long resultado = CalcularFactorial(numero);
                    Console.WriteLine($"El factorial de {numero} es {resultado}.");
                }
                else
                {
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

        // 5. Dibujar un triángulo invertido de asteriscos
        public static void DibujarUnTriánguloInversoDeAsteriscos()
        {
        int n = 1; // Define una variable entera 'n' que representa el número de niveles de la pirámide.
            
            // Inicia un bucle 'for' que itera desde 1 hasta 'n' (inclusive), para cada nivel de la pirámide.
            for (int i = 5; i >= n; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        // 6. Verificar si un número es palíndromo
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

            // 7. Juego de adivinanza con intentos limitados
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

            // 8. Menú interactivo de operaciones matemáticas
            public static void MenúInteractivoDeOperacionesMatemáticas()
            {
                int opcion;
                do
                {
                    Console.WriteLine("Menú de Operaciones Matemáticas:");
                    Console.WriteLine("1. Suma");
                    Console.WriteLine("2. Resta");
                    Console.WriteLine("3. Multiplicación");
                    Console.WriteLine("4. División");
                    Console.WriteLine("5. Potencia");
                    Console.WriteLine("6. Salir");
                    Console.Write("Elige una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    if (opcion >= 1 && opcion <= 5)
                    {
                        Console.Write("Introduce el primer número: ");
                        double num1 = double.Parse(Console.ReadLine());

                        Console.Write("Introduce el segundo número: ");
                        double num2 = double.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine($"Resultado: {num1 + num2}");
                                break;
                            case 2:
                                Console.WriteLine($"Resultado: {num1 - num2}");
                                break;
                            case 3:
                                Console.WriteLine($"Resultado: {num1 * num2}");
                                break;
                            case 4:
                                if (num2 != 0)
                                    Console.WriteLine($"Resultado: {num1 / num2}");
                                else
                                    Console.WriteLine("No se puede dividir por cero.");
                                break;
                            case 5:
                                Console.WriteLine($"Resultado: {Math.Pow(num1, num2)}");
                                break;
                        }
                    }
                    else if (opcion != 6)
                    {
                        Console.WriteLine("Opción no válida.");
                    }

                } while (opcion != 6);
                Console.WriteLine("Programa finalizado.");
            }

            // 9. Sumar los números primos entre 1 y n
            public static void SumaDeLosNúmerosPrimosEntre1yn()
            {
                Console.Write("Introduce un número n: ");
                int n = int.Parse(Console.ReadLine());
                int sumaPrimos = 0;

                for (int i = 2; i <= n; i++)
                {
                    if (EsPrimo(i))
                    {
                        sumaPrimos += i;
                    }
                }

                Console.WriteLine($"La suma de los números primos entre 1 y {n} es: {sumaPrimos}");
            }

            // Función para verificar si un número es primo
            static bool siEsPrimo(int numero)
            {
                if (numero <= 1) return false;
                if (numero == 2) return true;
                if (numero % 2 == 0) return false;

                for (int i = 3; i * i <= numero; i += 2)
                {
                    if (numero % i == 0)
                        return false;
                }

                return true;
            }

            // 10. Contar la frecuencia de caracteres en una palabra
            public static void ContarLaFrecuenciaDeCaracteresEnUnaPalabra()
            {
                Console.Write("Introduce una palabra: ");
                string palabra = Console.ReadLine();
                Dictionary<char, int> frecuencias = new Dictionary<char, int>();

                foreach (char c in palabra)
                {
                    if (frecuencias.ContainsKey(c))
                    {
                        frecuencias[c]++;
                    }
                    else
                    {
                        frecuencias[c] = 1;
                    }
                }

                Console.WriteLine("Frecuencia de caracteres:");
                foreach (var par in frecuencias)
                {
                    Console.WriteLine($"{par.Key}: {par.Value}");
                }
            }
        }
    }