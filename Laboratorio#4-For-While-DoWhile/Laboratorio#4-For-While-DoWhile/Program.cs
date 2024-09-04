using System;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamada a cada método para ejecutar los ejercicios
            Solucion1.Imprime1a5();
            Solucion2.Suma1aumentandoa10();
            Solucion3.TablasDeMultiplicar();
            Solucion4.ContarNumPositivosDig();
            Solucion5.Piramide();
        }
        //1
            public static void Imprime1a5()
        {
            static void Main() // Define el método 'Main', que es el punto de entrada de la aplicación.
            {
                for (int i = 1; i <= 5; i++) // Inicia un bucle 'for' que se ejecutará mientras 'i' sea menor o igual a 5.
                { 
                    Console.WriteLine(i); // Muestra el valor actual de 'i' en la consola.
                }
            }   
        }
        //2
        public static void Suma1aumentandoa10()
        {
            int suma = 0; // Declara una variable llamada 'suma' y la inicializa en 0. Esta variable almacenará la suma total.
            int i = 1; // Declara una variable llamada 'i' y la inicializa en 1. 'i' se usará como contador.

            while(i <= 10) // Inicia un bucle 'while' que se ejecutará mientras 'i' sea menor o igual a 10.
            {
                suma += i; // Suma el valor actual de 'i' a 'suma'. Es equivalente a 'suma = suma + i'.
                i++; // Incrementa el valor de 'i' en 1. Es equivalente a 'i = i + 1'.
            } 
            
            {
                Console.WriteLine($"la suma de los numeros es: {suma}"); // Muestra el resultado de la suma en la consola.
            }
        }
        //3
        public static void TablasDeMultiplicar()
        {
            int numero = 1; // Declara una variable 'numero' y la inicializa en 1.
            Console.WriteLine("tabla del 1"); // Muestra el texto "tabla del 1" en la consola.
            for (int i = 1; i <= 10; i++) // Bucle 'for' que va de 1 a 10.
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}"); // Imprime la multiplicación del número 1 con cada valor de 'i'.
            }

            int numero2 = 2; // Declara una variable 'numero2' y la inicializa en 2.
            Console.WriteLine("tabla del 2"); // Muestra el texto "tabla del 2" en la consola.
            for (int i = 1; i <= 10; i++) // Bucle 'for' que va de 1 a 10.
            {
                Console.WriteLine($"{numero2} x {i} = {numero2 * i}"); // Imprime la multiplicación del número 2 con cada valor de 'i'.
            }

            int numero3 = 3; // Declara una variable 'numero3' y la inicializa en 3.
            Console.WriteLine("tabla del 3"); // Muestra el texto "tabla del 3" en la consola.
            for (int i = 1; i <= 10; i++) // Bucle 'for' que va de 1 a 10.
            {
                Console.WriteLine($"{numero3} x {i} = {numero3 * i}"); // Imprime la multiplicación del número 3 con cada valor de 'i'.
            }

            int numero4 = 4; // Declara una variable 'numero4' y la inicializa en 4.
            Console.WriteLine("tabla del 4"); // Muestra el texto "tabla del 4" en la consola.
            for (int i = 1; i <= 10; i++) // Bucle 'for' que va de 1 a 10.
            {
                Console.WriteLine($"{numero4} x {i} = {numero4 * i}"); // Imprime la multiplicación del número 4 con cada valor de 'i'.
            }

            int numero5 = 5; // Declara una variable 'numero5' y la inicializa en 5.
            Console.WriteLine("tabla del 5"); // Muestra el texto "tabla del 5" en la consola.
            for (int i = 1; i <= 10; i++) // Bucle 'for' que va de 1 a 10.
            {
                Console.WriteLine($"{numero5} x {i} = {numero5 * i}"); // Imprime la multiplicación del número 5 con cada valor de 'i'.
            }

            int numero6 = 6; // Declara una variable 'numero6' y la inicializa en 6.
            Console.WriteLine("tabla del 6"); // Muestra el texto "tabla del 6" en la consola.
            for (int i = 1; i <= 10; i++) // Bucle 'for' que va de 1 a 10.
            {
                Console.WriteLine($"{numero6} x {i} = {numero6 * i}"); // Imprime la multiplicación del número 6 con cada valor de 'i'.
            }

            int numero7 = 7; // Declara una variable 'numero7' y la inicializa en 7.
            Console.WriteLine("tabla del 7"); // Muestra el texto "tabla del 7" en la consola.
            for (int i = 1; i <= 10; i++) // Bucle 'for' que va de 1 a 10.
            {
                Console.WriteLine($"{numero7} x {i} = {numero7 * i}"); // Imprime la multiplicación del número 7 con cada valor de 'i'.
            }

            int numero8 = 8; // Declara una variable 'numero8' y la inicializa en 8.
            Console.WriteLine("tabla del 8"); // Muestra el texto "tabla del 8" en la consola.
            for (int i = 1; i <= 10; i++) // Bucle 'for' que va de 1 a 10.
            {
                Console.WriteLine($"{numero8} x {i} = {numero8 * i}"); // Imprime la multiplicación del número 8 con cada valor de 'i'.
            }

            int numero9 = 9; // Declara una variable 'numero9' y la inicializa en 9.
            Console.WriteLine("tabla del 9"); // Muestra el texto "tabla del 9" en la consola.
            for (int i = 1; i <= 10; i++) // Bucle 'for' que va de 1 a 10.
            {
                Console.WriteLine($"{numero9} x {i} = {numero9 * i}"); // Imprime la multiplicación del número 9 con cada valor de 'i'.
            }
        }
        //4
        public static void ContarNumPositivosDig()
        {
            int numero; // Declara una variable entera llamada 'numero' para almacenar el número ingresado por el usuario.
            int contador = 0; // Declara una variable entera llamada 'contador' y la inicializa en 0. Esta variable cuenta los números positivos ingresados.

            do // Inicia un bucle 'do-while', que se ejecuta al menos una vez y repite mientras la condición al final sea verdadera.
            {
                Console.Write("Ingresa un número (negativo para terminar): "); // Muestra un mensaje pidiendo al usuario que ingrese un número.
                numero = int.Parse(Console.ReadLine()); // Lee una línea de texto ingresada por el usuario, la convierte a un entero y la guarda en la variable 'numero'.
                
                if (numero >= 0) // Verifica si el número ingresado es mayor o igual a 0.
                {
                    contador++; // Si es positivo (o cero), incrementa el contador en 1.
                }
            } while (numero >= 0); // El bucle se repite mientras 'numero' sea mayor o igual a 0.

            // Una vez que el usuario ingresa un número negativo, se sale del bucle y se ejecuta la siguiente línea.
            Console.WriteLine("Total de números positivos ingresados: " + contador); // Muestra el total de números positivos ingresados en la consola.
        }
        //5
         public static void Piramide()
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
            }
        }
    }    
}