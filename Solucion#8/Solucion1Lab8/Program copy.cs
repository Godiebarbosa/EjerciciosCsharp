using System;
class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto Estudiante y asignar valores
        Estudiante estudiante1 = new Estudiante();
        estudiante1.SetId(1);
        estudiante1.SetNombre("Juan Pérez");
        estudiante1.SetEdad(20);
        estudiante1.SetPromedio(4.5);

        // Mostrar la información del primer estudiante
        estudiante1.MostrarInfo();

        // Crear otro objeto Estudiante con diferentes valores
        Estudiante estudiante2 = new Estudiante();
        estudiante2.SetId(2);
        estudiante2.SetNombre("María Gómez");
        estudiante2.SetEdad(22);
        estudiante2.SetPromedio(4.8);

        // Mostrar la información del segundo estudiante
        estudiante2.MostrarInfo();
    }
}
