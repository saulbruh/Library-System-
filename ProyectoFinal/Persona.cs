public class Persona
{
  public string nombre;
  public string apellido;
  public string direccion;
  public string email;
  public string telefono;
  public string id;

  public Persona(string nombre, string apellido, string direccion, string email, string telefono, string id)
  {
    this.nombre = nombre;
    this.apellido = apellido;
    this.direccion = direccion;
    this.email = email;
    this.telefono = telefono;
    this.id = id;
  }

  public string Nombre
  {
    get {return nombre;}
    set {nombre = value;}
  }

  public string Apellido
  {
    get {return apellido;}
    set {apellido = value;}
  }

  public string Direccion
  {
    get {return direccion;}
    set {direccion = value;}
  }

  public string Email
  {
    get {return email;}
    set {email = value;}
  }

  public string Telefono
  {
    get {return telefono;}
    set {telefono = value;}
  }

  public string Id
  {
    get {return id;}
    set {id = value;}
  }

  public virtual void MostrarInformacion()
  {
    Console.WriteLine("Nombre: {0}", nombre);
    Console.WriteLine("Apellido: {0}", apellido);
    Console.WriteLine("Dirrecion: {0}", direccion);
    Console.WriteLine("Email: {0}", email);
    Console.WriteLine("Telefono: {0}", telefono);
    Console.WriteLine("Id: {0}", id);
  }
}