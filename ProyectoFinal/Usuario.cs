public class Usuario : Persona
{
  private string tipoUsuario;

  public Usuario(string nombre, string apellido, string direccion, string email, string telefono, string id, string tipoUsuario) : base(nombre, apellido, direccion, email, telefono, id)
  {
    this.tipoUsuario = tipoUsuario;
  }

  public string TipoUsuario
  {
    get{ return tipoUsuario; }
    set{ tipoUsuario = value; }
  }

  public override void MostrarInformacion()
  {
    Console.WriteLine($"{tipoUsuario}: {nombre} {apellido}, Direccion: {direccion}, Email: {email}, Telefono: {telefono}, ID: {id}");
  }
}