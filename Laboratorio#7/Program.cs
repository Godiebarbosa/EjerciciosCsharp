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
            int v1 = 0;
            int v2 = 1;
            //Mostar el primer numero en 0
            Console.WriteLine(v1);
            //en este caso generamos hasta 15
                for(int i = 0; i < 15; i ++);
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
         
        }
        //3
        public static void SumarDígitosDeUnNúmero()
        {
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