namespace Demo_Core.Modelos
{
    public class Contacto
    {
        public int IdContactoPersona { get; set; }
        public int? IdPersona { get; set; }
        public Persona? Individuo { get; set; }
        public string? Numero { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
    }
}
