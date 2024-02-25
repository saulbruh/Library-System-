public class Biblioteca
{
  private List<Libro> libros = new List<Libro>();
  private List<Persona> personas = new List<Persona>();

  public void AgregarLibro(Libro libro)
  {
    libros.Add(libro);
  }

  public void EliminarLibro(Libro libro)
  {
    libros.Remove(libro);
  }

  public void AgregarPersona(Persona persona)
  {
    personas.Add(persona);
  }

  public void EliminarPersona(Persona persona)
  {
    personas.Remove(persona);
  }

  public void MostrarLibros()
  {
    Console.WriteLine("Lista de libros:");

    foreach(Libro libro in libros)
    {
      libro.MostrarInformacion();
    }
  }

  public void MostrarPersonas()
  {
    Console.WriteLine("Lista de personas:");

    foreach (Persona persona in personas)
    {
      persona.MostrarInformacion();
    }
  }

  public void PrestarLibro(Libro libro, Usuario usuario)
  {
    if(!libro.prestamo)
    {
      libro.prestamo = true;
      Console.WriteLine($"{usuario.Nombre} {usuario.Apellido} ha tomado prestado el libro: {libro.Titulo}");
    }

    else
    {
      Console.WriteLine("El libro ya esta prestado");
    }
  }

  public void DevolverLibro(Libro libro, Usuario usuario)
  {
    if(libro.prestamo)
    {
      libro.prestamo = false;
      Console.WriteLine($"{usuario.nombre} {usuario.apellido} ha devuelto el libro {libro.titulo}");
    }

    else
    {
      Console.WriteLine("El libro no estaba prestado.");
    }
  }
}