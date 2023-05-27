namespace AppConsola;

public class Veterinaria
{
    public string Nombre { get; set; } = string.Empty;
    private List<Cliente> Clientes { get; set; }

    public Veterinaria(string nombre)
    {
        Nombre = nombre;
        Clientes = new List<Cliente>();
    }

    public void AgregarCliente(Cliente cliente){
        Clientes.Add(cliente);
    }

    public void MostrarClientes()
    {
        foreach (var item in Clientes)
        {
            Console.WriteLine($"el cliente con nombre {item.Nombre}");
            foreach (var m in item.ObtenerMascotas())
            {
                Console.WriteLine($"la mascota con nombre {m.Nombre}, con raza {m.Raza}");
            }
        }
    }
}
