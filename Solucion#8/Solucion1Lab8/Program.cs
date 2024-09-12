using System; // Importamos la librería básica de C# para trabajar con la consola

// Definimos la clase Estudiante
public class Estudiante
{
    // Campos privados para almacenar los datos de cada estudiante
    private int id; // Almacena el identificador único del estudiante
    private string nombre; // Almacena el nombre del estudiante
    private int edad; // Almacena la edad del estudiante
    private double promedio; // Almacena el promedio de calificaciones del estudiante

    // Métodos para obtener y modificar (Get y Set) los campos privados

    // Método que devuelve el valor de id
    public int GetId()
    {
        return id;
    }

    // Método para establecer el valor de id
    public void SetId(int value)
    {
        id = value; // Asigna el valor que se pasa como argumento a id
    }

    // Método que devuelve el valor de nombre
    public string GetNombre()
    {
        return nombre;
    }

    // Método para establecer el valor de nombre
    public void SetNombre(string value)
    {
        nombre = value; // Asigna el valor que se pasa como argumento a nombre
    }

    // Método que devuelve el valor de edad
    public int GetEdad()
    {
        return edad;
    }

    // Método para establecer el valor de edad
    public void SetEdad(int value)
    {
        // Validación básica: si la edad es negativa, no se permite
        if (value < 0)
        {
            Console.WriteLine("La edad no puede ser negativa.");
        }
        else
        {
            edad = value; // Asigna el valor que se pasa como argumento a edad
        }
    }

    // Método que devuelve el valor de promedio
    public double GetPromedio()
    {
        return promedio;
    }

    // Método para establecer el valor de promedio
    public void SetPromedio(double value)
    {
        // Validación básica: si el promedio es negativo, no se permite
        if (value < 0)
        {
            Console.WriteLine("El promedio no puede ser negativo.");
        }
        else
        {
            promedio = value; // Asigna el valor que se pasa como argumento a promedio
        }
    }

    // Método para mostrar la información del estudiante
    public void MostrarInfo()
    {
        // Imprimimos todos los datos del estudiante en la consola
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Promedio: {promedio}");
    }
}
