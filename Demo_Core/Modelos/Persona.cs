namespace Demo_Core.Modelos;

public enum EstadoPersona
{
    Feliz = 0,
    Triste,
    Enojado
}

public class Persona
{
    public int IdPersona { get; set; }
    public string? Nombre { get; set; }
    public EstadoPersona Estado { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();
}
