namespace AppConsola;

public class Mascota
{
    public string Nombre { get; private set; } = string.Empty;
    public string Especie { get; private set; } = string.Empty;
    public string Raza { get; private set; } = string.Empty;
    public DateTime FechaNacimiento { get; set;}
    public bool TieneAlergia { get; private set; }
    public bool TieneTratamientoMedico {get; private set;}
    public string DescripcionMedica { get; set; } = string.Empty;

    public Mascota(string nombre, string especie, string raza, DateTime fecha, bool tieneAlergia, bool tieneTratamientoMedico, string descripcionMedica)
    {
        Nombre = nombre;
        Especie = especie;
        Raza = raza;
        FechaNacimiento = fecha;
        TieneAlergia = tieneAlergia;
        TieneTratamientoMedico = tieneTratamientoMedico;
        DescripcionMedica = descripcionMedica;
    }
}
