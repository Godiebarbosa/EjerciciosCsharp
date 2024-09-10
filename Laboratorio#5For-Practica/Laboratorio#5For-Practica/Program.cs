using System;
namespace Laboratorio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamada a cada uno de los métodos que realizan diferentes operaciones
            Solucion1.imprimeNumeros1a10(); // Imprime números del 1 al 10
            Solucion2.SumarNumeros1a5(); // Suma números del 1 al 5
            Solucion3.Imprimir10NumPares(); // Imprime los primeros 10 números pares
            Solucion4.ImrpimeTablaDeMultiplicar(); // Imprime la tabla de multiplicar del 3
            Solucion5.ImprimirElementosDeUnArreglo(); // Imprime los elementos de un arreglo
            Solucion6.ContarLetrasEnUnaPalabra(); // Cuenta las letras de una palabra
            Solucion7.InvertirUnaCadena(); // Invierte una cadena de texto
            Solucion8.ImprimirLosNúmerosImparesEntre1Y20(); // Imprime los números impares entre 1 y 20
            Solucion9.CalcularElFactorialDeUnNúmero(); // Calcula el factorial de un número
            Solucion10.MostrarUnaFiguraDeAsteriscos(); // Muestra una figura de asteriscos en forma de triángulo
            Solucion11.ImprimirNúmerosDel1Al10While(); // Imprime números del 1 al 10 usando un bucle while
            Solucion12.SumarNúmerosHastaQueElUsuarioIngrese0(); // Suma números hasta que el usuario ingrese 0
            Solucion13.ContarHastaUnNúmeroDadoPorElUsuario(); // Cuenta hasta un número dado por el usuario
            Solucion14.EncontrarElMayorNúmeroIngresadoPorElUsuario(); // Encuentra el mayor número ingresado por el usuario
            Solucion15.ContarCuántasVecesApareceUnNúmero(); // Cuenta cuántas veces aparece el número 5 ingresado por el usuario
            Solucion16.SumarNúmerosIngresadosHastaQueElUsuarioIngrese0(); // Suma números hasta que el usuario ingrese 0
            Solucion17.AdivinarUnNúmeroHastaAcertar(); // El usuario adivina un número hasta acertarlo
            Solucion18.DeterminarElDíaDeLaSemana(); // Determina el día de la semana según un número ingresado
            Solucion19.OperacionesBásicasDeCalculad(); // Realiza operaciones básicas de calculadora (suma, resta, multiplicación, división)
        }

        // 1. Imprime los números del 1 al 10
        public static void imprimeNumeros1a10()
        {
            for(int i = 1 ; i <= 10; i++) // Itera desde 1 hasta 10
            {
                Console.WriteLine(i); // Imprime el valor actual de i
            }
        }

        // 2. Suma los números del 1 al 5 y muestra el resultado
        public static void SumarNumeros1a5()
        {
            int suma = 0; // Inicializa una variable para almacenar la suma
            for (int i = 1; i <= 5; i++) // Itera desde 1 hasta 5
            {
                suma += i; // Suma el valor actual de i a la suma acumulada
            }
            Console.WriteLine($"La suma es: {suma}"); // Muestra la suma total
        }

        // 3. Imprime los primeros 10 números pares
        public static void Imprimir10NumPares()
        { 
            for (int i = 1; i <= 10; i++) // Itera 10 veces
            {
                Console.WriteLine(i * 2); // Imprime el número par correspondiente
            }
        }

        // 4. Imprime la tabla de multiplicar del número 3
        public static void ImrpimeTablaDeMultiplicar()
        {
            int numero = 3; // Define el número para la tabla de multiplicar
            for (int i = 1; i <= 10; i++) // Itera desde 1 hasta 10
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}"); // Imprime la multiplicación
            }
        }

        // 5. Imprime los elementos de un arreglo de enteros
        public static void ImprimirElementosDeUnArreglo()
        {
            int[] numeros = { 1, 2, 3, 4, 5 }; // Declara un arreglo de enteros
            for (int i = 0; i < numeros.Length; i++) // Itera sobre el arreglo
            {
                Console.WriteLine(numeros[i]); // Imprime cada elemento del arreglo
            }
        }

        // 6. Cuenta las letras de una palabra e imprime el total
        public static void ContarLetrasEnUnaPalabra()
        {
            string palabra = "Hola"; // Define la palabra a contar
            int contador = 0; // Inicializa un contador
            for (int i = 0; i < palabra.Length; i++) // Itera sobre cada letra de la palabra
            {
                contador++; // Incrementa el contador por cada letra
            }
            Console.WriteLine($"La palabra tiene {contador} letras."); // Muestra el total de letras
        }

        // 7. Invierte una cadena de texto y la imprime
        public static void InvertirUnaCadena()
        {
            string texto = "Hola"; // Define la cadena de texto
            string invertido = ""; // Inicializa una cadena vacía para el texto invertido
            for (int i = texto.Length - 1; i >= 0; i--) // Itera desde el último carácter al primero
            {
                invertido += texto[i]; // Agrega cada carácter al inicio de la cadena invertida
            }
            Console.WriteLine(invertido); // Imprime la cadena invertida
        }

        // 8. Imprime los números impares entre 1 y 20
        public static void ImprimirLosNúmerosImparesEntre1Y20()
        {
            for(int i = 1 ; i <= 20 ; i += 2) // Itera desde 1 hasta 20, incrementando de 2 en 2
            {
                Console.WriteLine(i); // Imprime el número impar actual
            }
        }

        // 9. Calcula el factorial de un número (en este caso, 5)
        public static void CalcularElFactorialDeUnNúmero()
        {
            int numero = 5; // Define el número para calcular el factorial
            int factorial = 1; // Inicializa el valor del factorial
            for (int i = 1 ; i <= numero; i++) // Itera desde 1 hasta el número dado
            {
                factorial *= i; // Multiplica el valor actual de factorial por i
            }
            Console.WriteLine($"El factorial de {numero} es: {factorial}"); // Imprime el resultado (Este Console.WriteLine estaba ausente en el código original)
        }

        // 10. Imprime una figura de asteriscos en forma de triángulo
        public static void MostrarUnaFiguraDeAsteriscos()
        {
            int filas = 5; // Define el número de filas para el triángulo
            for (int i = 1 ; i <= filas; i++) // Itera sobre cada fila
            {
                for (int j = 1; j <= i; j++) // Imprime los asteriscos en la fila actual
                {
                    Console.WriteLine("*"); // Imprime un asterisco
                }
                Console.WriteLine(); // Imprime una nueva línea al final de cada fila
            }
        }

        // 11. Imprime números del 1 al 10 usando un bucle while
        public static void ImprimirNúmerosDel1Al10While()
        {
            int i = 1; // Inicializa i en 1
            while (i <= 10) // Mientras i sea menor o igual a 10
            {
                Console.WriteLine(i); // Imprime el valor de i
                i++; // Incrementa i en 1
            }
        }

        // 12. Suma números hasta que el usuario ingrese 0
        public static void SumarNúmerosHastaQueElUsuarioIngrese0()
        {
            int suma = 0; // Variable para almacenar la suma
            int numero; // Variable para almacenar el número ingresado

            Console.Write("Ingrese un número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine()); // Convierte el texto ingresado en un número
            while (numero != 0) // Mientras el número no sea 0
            {
                suma += numero; // Suma el número ingresado a la suma acumulada
                Console.Write("Ingrese otro número (0 para terminar): ");
                numero = int.Parse(Console.ReadLine()); // Lee el siguiente número
            }
            Console.WriteLine($"La suma total es: {suma}"); // Imprime la suma total
        }

        // 13. Cuenta desde 1 hasta un número dado por el usuario
        public static void ContarHastaUnNúmeroDadoPorElUsuario()
        {
            Console.Write("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine()); // Convierte el texto ingresado en un número
            int i = 1; // Inicializa el contador en 1
            while (i <= n) // Mientras i sea menor o igual a n
            {
                Console.WriteLine(i); // Imprime el valor de i
                i++; // Incrementa i en 1
            }
        }

        // 14. Encuentra el mayor número entre los ingresados por el usuario, hasta que se ingrese un 0
        public static void EncontrarElMayorNúmeroIngresadoPorElUsuario()
        {
            int mayor = int.MinValue; // Inicializa con el valor mínimo posible de un entero
            int numero; // Variable para almacenar el número ingresado

            Console.Write("Ingrese un número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine()); // Convierte el texto ingresado en un número
            while (numero != 0) // Mientras el número no sea 0
            {
                if (numero > mayor) // Si el número ingresado es mayor que el actual valor de mayor
                {
                    mayor = numero; // Actualiza el valor de mayor
                }
                Console.Write("Ingrese otro número (0 para terminar): ");
                numero = int.Parse(Console.ReadLine()); // Lee el siguiente número
            }
            Console.WriteLine($"El número mayor ingresado es: {mayor}"); // Imprime el número mayor encontrado
        }

        // 15. Cuenta cuántas veces se ingresa el número 5
        public static void ContarCuántasVecesApareceUnNúmero()
        {
            int contador = 0; // Inicializa un contador
            int numero; // Variable para almacenar el número ingresado

            Console.Write("Ingrese un número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine()); // Convierte el texto ingresado en un número
            while (numero != 0) // Mientras el número no sea 0
            {
                if (numero == 5) // Si el número ingresado es 5
                {
                    contador++; // Incrementa el contador
                }
                Console.Write("Ingrese otro número (0 para terminar): ");
                numero = int.Parse(Console.ReadLine()); // Lee el siguiente número
            }
            Console.WriteLine($"El número 5 se ingresó {contador} veces."); // Imprime cuántas veces se ingresó el número 5
        }

        // 16. Suma números ingresados por el usuario hasta que ingrese 0
        public static void SumarNúmerosIngresadosHastaQueElUsuarioIngrese0()
        {
            int suma = 0; // Variable para almacenar la suma
            int numero; // Variable para almacenar el número ingresado

            Console.Write("Ingrese un número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine()); // Convierte el texto ingresado en un número
            while (numero != 0) // Mientras el número no sea 0
            {
                suma += numero; // Suma el número ingresado a la suma acumulada
                Console.Write("Ingrese otro número (0 para terminar): ");
                numero = int.Parse(Console.ReadLine()); // Lee el siguiente número
            }
            Console.WriteLine($"La suma total es: {suma}"); // Imprime la suma total
        }

        // 17. El usuario adivina un número hasta acertar
        public static void AdivinarUnNúmeroHastaAcertar()
        {
            int numeroSecreto = 7; // Define el número secreto a adivinar
            int adivinanza; // Variable para almacenar el número ingresado por el usuario

            Console.Write("Adivine el número secreto: ");
            adivinanza = int.Parse(Console.ReadLine()); // Convierte el texto ingresado en un número
            while (adivinanza != numeroSecreto) // Mientras la adivinanza sea incorrecta
            {
                Console.WriteLine("¡Incorrecto! Intenta nuevamente.");
                Console.Write("Adivine el número secreto: ");
                adivinanza = int.Parse(Console.ReadLine()); // Lee el siguiente intento
            }
            Console.WriteLine("¡Correcto! Adivinaste el número secreto."); // Imprime un mensaje de éxito cuando acierte
        }

        // 18. Determina el día de la semana según un número ingresado
        public static void DeterminarElDíaDeLaSemana()
        {
            Console.Write("Ingrese un número (1-7): ");
            int dia = int.Parse(Console.ReadLine()); // Convierte el texto ingresado en un número
            switch (dia) // Evalúa el número ingresado
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Número inválido");
                    break;
            }
        }

        // 19. Realiza operaciones básicas de calculadora (suma, resta, multiplicación, división)
        public static void OperacionesBásicasDeCalculad()
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine()); // Lee el primer número

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine()); // Lee el segundo número

            Console.WriteLine("Elija una operación: (+, -, *, /)");
            string operacion = Console.ReadLine(); // Lee la operación seleccionada

            switch (operacion) // Evalúa la operación seleccionada
            {
                case "+":
                    Console.WriteLine($"Resultado: {num1 + num2}"); // Suma
                    break;
                case "-":
                    Console.WriteLine($"Resultado: {num1 - num2}"); // Resta
                    break;
                case "*":
                    Console.WriteLine($"Resultado: {num1 * num2}"); // Multiplicación
                    break;
                case "/":
                    if (num2 != 0) // Verifica que no haya división por cero
                    {
                        Console.WriteLine($"Resultado: {num1 / num2}"); // División
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero no permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Operación inválida");
                    break;
            }
        }
    }
}
