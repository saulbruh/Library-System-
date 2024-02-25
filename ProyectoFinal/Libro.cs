public class Libro
{
  public string titulo;
  public string autor;
  public string editorial;
  public int anioPublicacion;
  public string edicion;
  public string isbn;
  public bool prestamo;

  public Libro(string titulo, string autor, string editorial, int anioPublicacion, string edicion, string isbn)
  {
    this.titulo = titulo;
    this.autor = autor;
    this.editorial = editorial;
    this.anioPublicacion = anioPublicacion;
    this.edicion = edicion;
    this.isbn = isbn;
    this.prestamo = false;
  }

  public string Titulo
  {
    get {return titulo;}
    set {titulo=value;}
  }

  public string Autor
  {
    get {return autor;}
    set {autor=value;}
  }

  public string Editorial
  {
    get {return editorial;}
    set {editorial=value;}
  }

  public int AnioPublicacion
  {
    get {return anioPublicacion;}
    set {anioPublicacion=value;}
  }

  public string Edicion
  {
    get {return edicion;}
    set {edicion=value;}
  }

  public string Isbn
  {
    get {return isbn;}
    set {isbn=value;}
  }

  public bool Prestamo
  {
    get {return prestamo;}
    set {prestamo=value;}
  }

  public void MostrarInformacion()
  {
    Console.WriteLine($"Libro: {titulo}, Autor: {autor}, Editorial: {editorial}, Anio de Publicacion: {anioPublicacion}, Edicion: {edicion}, ISBN: {isbn}, Prestado: {prestamo}");
  }
}