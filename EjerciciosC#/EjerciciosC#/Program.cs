using System;

namespace EjerciciosC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamada a cada método para ejecutar los ejercicios
            Solucion1.DatosPersonales();
            Solucion2.OperacionesMatematicas();
            Solucion3.MediaDeTresNumeros();
            Solucion4.MinutosAHoras();
            Solucion5.SueldoConComision();
            Solucion6.DescuentoEnCompra();
            Solucion7.DistanciaEntreNumeros();
            Solucion8.RaizCuadradaYCubica();
            Solucion9.InvertirNumeroDosCifras();
            Solucion10.IntercambiarValores();
        }

        // 1. Solicitar Datos Personales
        static void DatosPersonales()
        {
            /// Muestra un mensaje en la consola solicitando el nombre del usuario
            Console.Write("¿Cuál es tu nombre?");
            /// Declara una variable 'nombre' y almacena la entrada del usuario
            string nombre = Console.ReadLine();
            /// Muestra un mensaje en la consola solicitando la edad del usuario
            Console.Write("¿Cual es tu edad?");
            /// Declara una variable 'edad', convierte la entrada a entero y la almacena
            int edad = int.Parse(Console.ReadLine());
            /// Muestra un mensaje en la consola preguntando si el usuario trabaja
            Console.Write("¿trabajas?");
            /// Declara una variable 'trabajo' y almacena la respuesta del usuario
            string trabajo = Console.ReadLine();
            /// Muestra un mensaje en la consola preguntando si el usuario estudia
            Console.Write("¿Estudias?");
            /// Declara una variable 'estudio' y almacena la respuesta del usuario
            string estudio = Console.ReadLine();
            /// Muestra en la consola los datos recolectados formateados en una línea
            Console.WriteLine(" nombre : " + nombre + " edad  : " + edad + " ¿trabajas? : " + trabajo + " ¿estudias? " + estudio + "");
        }

        // 2. Calcular Operaciones Matemáticas
        static void OperacionesMatematicas()
        {
            /// Imprime el mensaje "Ingresa el primer número: " en la consola
            Console.Write("Ingresa el primer número: ");
            /// Declara una variable 'num1' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num1 = double.Parse(Console.ReadLine());
            /// Imprime el mensaje "Ingresa el segundo número: " en la consola
            Console.Write("Ingresa el segundo número: ");
            /// Declara una variable 'num2' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num2 = double.Parse(Console.ReadLine());   
            /// Realiza la suma de 'num1' y 'num2' y muestra el resultado en la consola
            Console.WriteLine("Suma: " + (num1 + num2));
            /// Realiza la resta de 'num1' y 'num2' y muestra el resultado en la consola
            Console.WriteLine("Resta: " + (num1 - num2));
            /// Realiza la multiplicación de 'num1' y 'num2' y muestra el resultado en la consola
            Console.WriteLine("Multiplicación: " + (num1 * num2));
            /// Verifica si 'num2' es diferente de cero antes de realizar la división
            if (num2 != 0)
            {
                /// Realiza la división de 'num1' entre 'num2' y muestra el resultado en la consola
                Console.WriteLine("División: " + (num1 / num2));
            }
            else
            {
                /// Imprime un mensaje indicando que no se puede dividir entre cero
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }

        // 3. Calcular Media de Tres Números
        static void MediaDeTresNumeros()
                {
            /// Imprime el mensaje "Ingresa el primer número: " en la consola
            Console.Write("Ingresa el primer número: ");
            /// Declara una variable 'num1' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num1 = double.Parse(Console.ReadLine());
            /// Imprime el mensaje "Ingresa el segundo número: " en la consola
            Console.Write("Ingresa el segundo número: ");
            /// Declara una variable 'num2' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num2 = double.Parse(Console.ReadLine());
            /// Imprime el mensaje "Ingresa el tercer número: " en la consola
            Console.Write("Ingresa el tercer número: ");
            /// Declara una variable 'num3' de tipo double y lee la entrada del usuario, convirtiéndola a double
            double num3 = double.Parse(Console.ReadLine());
            /// Calcula la media de los tres números sumándolos y dividiéndolos entre 3
            double media = (num1 + num2 + num3) / 3;
            /// Imprime el resultado de la media en la consola
            Console.WriteLine("La media de los tres números es: " + media);
        }

        // 4. Convertir Minutos a Horas
        static void MinutosAHoras()
             {
            /// Imprime el mensaje "Ingresa una cantidad de minutos: " en la consola
            Console.Write("Ingresa una cantidad de minutos: ");
            /// Declara una variable 'minutos' de tipo int y lee la entrada del usuario, convirtiéndola a un entero
            int minutos = int.Parse(Console.ReadLine());
            /// Calcula el número de horas dividiendo los minutos entre 60
            int horas = minutos / 60;
            /// Calcula los minutos restantes usando el operador módulo para obtener el resto de la división
            int minutosRestantes = minutos % 60;
            /// Imprime el resultado en la consola, mostrando la cantidad de horas y minutos restantes
            Console.WriteLine(minutos + " minutos son " + horas + " horas y " + minutosRestantes + " minutos.");
        }

        // 5. Calcular Sueldo con Comisión
        static void SueldoConComision()
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

        // 6. Calcular Descuento en Compra
        static void DescuentoEnCompra()
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

        // 7.Calcular Distancia entre Números
        static void DistanciaEntreNumeros()
        {
            Console.Write("Ingresa el primer número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double distancia = Math.Abs(num1 - num2);
            Console.WriteLine("La distancia entre los dos números es: " + distancia);
        }
        
        // 8.  Calcular Raíz Cuadrada y Cúbica
        static void RaizCuadradaYCubica()
        {
            Console.Write("Ingresa un número: ");
            double num = double.Parse(Console.ReadLine());

            double raizCuadrada = Math.Sqrt(num);
            double raizCubica = Math.Cbrt(num);

            Console.WriteLine("La raíz cuadrada de " + num + " es: " + raizCuadrada);
            Console.WriteLine("La raíz cúbica de " + num + " es: " + raizCubica);
        }
        
        // 9. Invertir Número de Dos Cifras
        static void InvertirNumeroDosCifras()
        {
            Console.Write("Ingresa un número de dos cifras: ");
            string numero = Console.ReadLine();

            if (numero.Length == 2)
            {
                string invertido = new string(numero.Reverse().ToArray());
                Console.WriteLine("El número invertido es: " + invertido);
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número de dos cifras.");
            }
        }
        // 10.Intercambiar Valores
        static void IntercambiarValores()
        {
            Console.Write("Ingresa el valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de B: ");
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Después del intercambio, el valor de A es: " + a);
            Console.WriteLine("Después del intercambio, el valor de B es: " + b);
        } 
    }
}