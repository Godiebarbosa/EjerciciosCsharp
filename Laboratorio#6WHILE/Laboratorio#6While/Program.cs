using System;
class Program   
{
    static void Main()
    {
        //Mensaje Inicial
        Console.WriteLine("¡Bienvenido al juego de adivinanza!");
        bool i = false;
        //Bucle do-while para asegurarse de que el usuario juegue almenos una vez
    do
    {
        //Genera un numero secreto aleatorio entre 1 y 10 
        Random random = new Random();
        int numeroSecreto = random.Next(1, 11 );
        //Genera un numero entre 1 y 10
        int intento = 0; // Variable para almacenar la adivinaza si el numero ha sido adivinado
        bool adivinado = false; // Bandera para verificar si el numero ha sido adivinado
        //Bucle while para permitir multiples intentos
        while(!adivinado)
        {
            Console.Write("Adinvina el numero (entre 1 y 10): ");
            intento = int.Parse(Console.ReadLine()); //Leer la adivinanza del usuario

            //Comprobar si la adivinanza es correcta
            if (intento == numeroSecreto)
            {
                Console.WriteLine("¡Felicidades! Has adivinado el numero secreto.");
                adivinado = true;//salir del bucle while
            }
            else
            {
                Console.WriteLine("Intenta de nuevo.");

            }
        }
        //menu de opciones usando switch
        Console.WriteLine("¿Quieres jugar otra vez? (s/n): ");
        char jugarDeNuevo = Console.ReadKey().KeyChar;//Lerr la opcion del usuario
        Console.WriteLine();
        
        switch(jugarDeNuevo)
        {
            case 's':
            case 'S':
            Console.WriteLine("¡Vamos a jugar otra vez!");
            break;
            case 'n':
            case 'N':
            Console.WriteLine("¡Gracias por jugar! Hasta la proxima.");
            i = true;
            break;
            default:
            Console.WriteLine("Opcion no valida, Salir del juego.");
            i = true;
            jugarDeNuevo ='n' ; //Salir del juego si la opcion no es valida
            break;

        }
    } 
    
    while (i == false  ||i == false  );
    //Condicion para repetir el juego
    }
}