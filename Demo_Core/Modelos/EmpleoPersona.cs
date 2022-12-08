namespace Demo_Core.Modelos;

public class EmpleoPersona
{
    public int IdEmpleoPersona { get; set; }
    public int? IdPersona { get; set; }
    public Persona? Empleado { get; set; }
    public int? IdEmpleo { get; set; }
    public Empleo? Trabajo { get; set; }
}
