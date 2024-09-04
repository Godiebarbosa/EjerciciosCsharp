using System;
namespace Laboratorio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Solucion1.imprimeNumeros1a10();
            Solucion2.SumarNumeros1a5();
            Solucion3.Imprimir10NumPares();
            Solucion4.ImrpimeTablaDeMultiplicar();
            Solucion5.ImprimirElementosDeUnArreglo();
            Solucion6.ContarLetrasEnUnaPalabra();
            Solucion7.InvertirUnaCadena();
            Solucion8.ImprimirLosNúmerosImparesEntre1Y20();
            Solucion9.CalcularElFactorialDeUnNúmero();
            Solucion10.MostrarUnaFiguraDeAsteriscos();
            Solucion11.ImprimirNúmerosDel1Al10While();
            Solucion12.SumarNúmerosHastaQueElUsuarioIngrese0();
            Solucion13.ContarHastaUnNúmeroDadoPorElUsuario();
            Solucion14.EncontrarElMayorNúmeroIngresadoPorElUsuario();
            Solucion15.ContarCuántasVecesApareceUnNúmero();
            Solucion16.SumarNúmerosIngresadosHastaQueElUsuarioIngrese0();
            Solucion17.AdivinarUnNúmeroHastaAcertar();
            Solucion18.DeterminarElDíaDeLaSemana();
            Solucion19.OperacionesBásicasDeCalculad();

        }
        //1
        public static void imprimeNumeros1a10()
        {
            for(int i = 1 ; i <= 10; i++)
            {
                Console.WriteLine(i);//C mayusculas W mayuscula L mayuscula o tira error.
            }
        }
        //2
        public static void SumarNumeros1a5()
        {
                int suma = 0; // Inicializamos una variable para almacenar la suma.
                for (int i = 1; i <= 5; i++) // Iteramos desde 1 hasta 5.
            {
                suma += i; // Suma acumulada: suma = suma + i.
            }
                Console.WriteLine($"La suma es: {suma}");
        }
        //3
        public static void Imprimir10NumPares()
        { 
        for (int i = 1; i <= 10; i++)
            {
            Console.WriteLine(i * 2);
            }
        }
        //4
        public static void ImrpimeTablaDeMultiplicar()
        {
            int numero = 3;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        //5
        public static void ImprimirElementosDeUnArreglo()
        {
            int[] numeros = { 1, 2, 3, 4, 5 }; // Declaramos un arreglo de enteros.
            for (int i = 0; i < numeros.Length; i++) // Iteramos desde 0 hastala longitud del arreglo.
            {
                Console.WriteLine(numeros[i]);
            }
        }
        //6
        public static void ContarLetrasEnUnaPalabra()
    
        {
        string palabra = "Hola"; // Declaramos una cadena de texto.
        int contador = 0; // Inicializamos un contador.
        for (int i = 0; i < palabra.Length; i++)
            {
                contador++; // Incrementamos el contador por cada letra.
            }
        Console.WriteLine($"La palabra tiene {contador} letras.");
        }
        //7
        public static void InvertirUnaCadena()
        {
            string texto = "Hola";
            string invertido = "";
            for (int i = texto.Length - 1; i >= 0; i--) // Comenzamos desde el último carácter.
            {
                invertido += texto[i]; // Agregamos cada letra al inicio del texto invertido.
            }
            {
                Console.WriteLine(invertido);
            }
        }
        //8
        public static void ImprimirLosNúmerosImparesEntre1Y20()
        {
            for(int i = 1 ; i <= 20 ; i += 2)
            {
                Console.WriteLine(i);
            }
            
        }
        //9
        public static void CalcularElFactorialDeUnNúmero()
        {
            int numero = 5;
            int factorial = 1;
        
            for (int i = 1 ; i <= numero; i++)
            {
                //multiplicamos el valor actual de factorial por i
                factorial*=i;
            }
        }
        //10
        public static void MostrarUnaFiguraDeAsteriscos()
        {
            int filas = 5;
            for (int i = 1 ; i <= filas; i++)
            {
                //Bucle anidado que imprime los asteriscos
                for (int j= 1; j<= i; j++)
                {
                    Console.WriteLine("*");
                }
            //imprime una nueva linea al final de cada fila
            Console.WriteLine();
            }
        }
        //11
        public static void ImprimirNúmerosDel1Al10While()
        {
            int i=1;//inicializamos i en 1
            //mientras i sea menor o igual a 10
            while (i<=10)
            {
                Console.WriteLine(i);
                i++; //Incrementamos i en 1
            }
        }
        //12
        public static void SumarNúmerosHastaQueElUsuarioIngrese0()
        {
            //variable para almacenar la suma.
            int suma = 0;
            int numero;

            Console.Write("ingrese un numero (0 para terminar):");
            //convertimos el texto a numero
            numero = int.Parse(Console.ReadLine());
            //El bucle se ejecuta mientras el numero no sea 0
            while (numero != 0 )
            {
                suma += numero;
                Console.Write("Ingrese otro numnero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());
            }
        Console.WriteLine($"La suma total es : {suma}");
        }
        //13
        public static void ContarHastaUnNúmeroDadoPorElUsuario()
        {
            Console.Write("Ingrese un numero: ");
            //convertimos el texto ingresado a numero
            int n = int.Parse(Console.ReadLine());
            //Inicializamos i en 1
            int i =1 ; 
            //Mientras i sea menor o igual a n
            while(i<=n)
            {
                Console.WriteLine(i);
                i++;//Incrementamos i en 1
            }
        }
        //14
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
        //15
        public static void ContarCuántasVecesApareceUnNúmero()
        {
            int contador = 0;
            int numero;

            Console.WriteLine("Ingrese un numero(0 para terminar): ");
            numero = int.Parse(Console.ReadLine());

            while(numero != 0)
            {
                //comprobamos si el numero es 5
                if(numero==5)
            
                {
                    contador++;
                }
                Console.Write("Ingrese otro numero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"El numero 5 fue ingresado {contador} veces");
        }
        //16
        public static void SumarNúmerosIngresadosHastaQueElUsuarioIngrese0()
        {
            int suma = 0;
            int numero ;
            do
            {
                Console.Write("ingrese un numero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
            }
            while (numero != 0);
            Console.WriteLine($"La suma total es : {suma}");
        }
        //17
        public static void AdivinarUnNúmeroHastaAcertar()
        {
            //establecemos un numero secreto
            int numerosecreto = 7;
            int intento;
            do
            {
                Console.Write("Adivine el numero secreto: ");
                intento = int.Parse(Console.ReadLine());
                if (intento != numerosecreto)
                {
                    Console.WriteLine("incorrecto, intentelo de nuevo");
                }
            } 
            while (intento != numerosecreto);

            Console.WriteLine("¡Correcto! has adivinado el numero secreto.");
        }  
        //18
        public static void DeterminarElDíaDeLaSemana()
        {
            Console.Write("ingrese un numero del 1 al 7 para el dia de la semana");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                Console.WriteLine("Lunes");
                break;
                case 2:
                Console.WriteLine("Martes");
                break;
                case 3:
                Console.WriteLine("Miercoles");
                break;
                case 4:
                Console.WriteLine("Jueves");
                break;
                case 5:
                Console.WriteLine("Viernes");
                break;
                case 6:
                Console.WriteLine("Sabado");
                break;
                case 7:
                Console.WriteLine("Domingo");
                break;
            }
        }
        //19
        public static void OperacionesBásicasDeCalculad()
        {
            Console.Write("Ingrese el primer numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("ingrese una operacion ( +, -, *, /): ");
            char operacion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (operacion)
            {
                case '+':
                Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
                break;
                case '-':
                Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
                break;
                case '*':
                Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2}");
                break;
                case '/':
                    if(num2 !=0)
                    {
                        Console.WriteLine($"Resultado {num1} / {num2} = {num1 / num2}");
                    } 
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    break;
                    default:
                Console.WriteLine("Operación no válida");
                break;
            }
        }
    }

}