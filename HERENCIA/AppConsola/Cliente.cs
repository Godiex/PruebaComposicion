namespace AppConsola;

public class Cliente
{
    public string Nombre { get; private set; } = string.Empty;
    public string Direcccion { get; set; } = string.Empty;
    private List<string> Telefonos { get; set; }
    private List<string> Correos { get; set; }
    private List<Mascota> Mascotas { get; set; }

    public Cliente(string nombre, string direcccion, List<Mascota> mascotas)
    {
        Direcccion = direcccion;
        Nombre = nombre;
        Telefonos = new List<string>();
        Correos = new List<string>();
        Mascotas = mascotas;
    }

    public void AgregarTelefonos(string telefono){
        Telefonos.Add(telefono);
    }

    public void AgregarCorreo(string correo){
        Correos.Add(correo);
    }

    public List<Mascota> ObtenerMascotas(){
        return Mascotas;
    }
}
