using System; // Necesario para trabajar con la consola
using System.Collections.Generic; // Necesario para usar listas

// Definimos la clase Libro
public class Libro
{
    // Campos privados
    private int id;
    private string titulo;
    private string autor;
    private int anioPublicacion;
    private bool disponible;

    // Métodos para acceder y modificar los campos privados
    public int GetId() { return id; }
    public void SetId(int value) { id = value; }

    public string GetTitulo() { return titulo; }
    public void SetTitulo(string value) { titulo = value; }

    public string GetAutor() { return autor; }
    public void SetAutor(string value) { autor = value; }

    public int GetAnioPublicacion() { return anioPublicacion; }
    public void SetAnioPublicacion(int value) { anioPublicacion = value; }

    public bool IsDisponible() { return disponible; }
    public void SetDisponible(bool value) { disponible = value; }

    // Método para prestar el libro
    public void PrestarLibro()
    {
        if (disponible)
        {
            disponible = false;
            Console.WriteLine($"El libro '{titulo}' ha sido prestado.");
        }
        else
        {
            Console.WriteLine($"El libro '{titulo}' no está disponible.");
        }
    }

    // Método para devolver el libro
    public void DevolverLibro()
    {
        disponible = true;
        Console.WriteLine($"El libro '{titulo}' ha sido devuelto.");
    }

    // Método para mostrar la información del libro
    public void MostrarInfo()
    {
        Console.WriteLine($"ID: {id}, Título: {titulo}, Autor: {autor}, Año: {anioPublicacion}, Disponible: {disponible}");
    }
}
public class Biblioteca
{
    // Lista de libros en la biblioteca
    private List<Libro> libros;

    // Constructor
    public Biblioteca()
    {
        libros = new List<Libro>(); // Inicializamos la lista de libros
    }

    // Método para agregar un libro
    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro); // Agregamos el libro a la lista
        Console.WriteLine($"El libro '{libro.GetTitulo()}' ha sido agregado a la biblioteca.");
    }

    // Método para buscar un libro por título
    public Libro BuscarLibroPorTitulo(string titulo)
    {
        foreach (var libro in libros) // Recorremos la lista de libros
        {
            if (libro.GetTitulo().ToLower() == titulo.ToLower()) // Comparar títulos en minúsculas
            {
                return libro; // Devolvemos el libro si lo encontramos
            }
        }
        Console.WriteLine("Libro no encontrado.");
        return null; // Devolvemos null si no lo encontramos
    }

    // Método para mostrar todos los libros
    public void MostrarTodosLosLibros()
    {
        foreach (var libro in libros) // Recorremos la lista de libros
        {
            libro.MostrarInfo(); // Mostramos la información de cada libro
        }
    }

    // Método para prestar un libro por ID
    public void PrestarLibro(int id)
    {
        foreach (var libro in libros) // Recorremos la lista de libros
        {
            if (libro.GetId() == id) // Si encontramos el libro por ID
            {
                libro.PrestarLibro(); // Prestamos el libro
                return;
            }
        }
        Console.WriteLine("Libro no encontrado.");
    }

    // Método para devolver un libro por ID
    public void DevolverLibro(int id)
    {
        foreach (var libro in libros) // Recorremos la lista de libros
        {
            if (libro.GetId() == id) // Si encontramos el libro por ID
            {
                libro.DevolverLibro(); // Devolvemos el libro
                return;
            }
        }
        Console.WriteLine("Libro no encontrado.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Crear una nueva biblioteca
        Biblioteca biblioteca = new Biblioteca();

        // Crear libros
        Libro libro1 = new Libro();
        libro1.SetId(1);
        libro1.SetTitulo("Cien Años de Soledad");
        libro1.SetAutor("Gabriel García Márquez");
        libro1.SetAnioPublicacion(1967);
        libro1.SetDisponible(true);

        Libro libro2 = new Libro();
        libro2.SetId(2);
        libro2.SetTitulo("Don Quijote de la Mancha");
        libro2.SetAutor("Miguel de Cervantes");
        libro2.SetAnioPublicacion(1605);
        libro2.SetDisponible(true);

        // Agregar libros a la biblioteca
        biblioteca.AgregarLibro(libro1);
        biblioteca.AgregarLibro(libro2);

        // Mostrar todos los libros
        biblioteca.MostrarTodosLosLibros();

        // Prestar un libro
        biblioteca.PrestarLibro(1);

        // Devolver un libro
        biblioteca.DevolverLibro(1);
    }
}
