public class Bibliotecario : Persona
{
  private string puesto;

  public Bibliotecario(string nombre, string apellido, string direccion, string email, string telefono, string id, string puesto) : base(nombre, apellido, direccion, email, telefono, id)
  {
    this.puesto = puesto;
  }

  public string Puesto
  {
    get {return puesto;}
    set {puesto = value;}
  }

  public override void MostrarInformacion()
  {
    Console.WriteLine($"Bibliotecario: {nombre} {apellido}, Dirreccion: {direccion}, Email: {email}, Telefono: {telefono}, ID: {id}, Puesto: {puesto}");
  }
}