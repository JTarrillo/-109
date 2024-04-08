namespace DatatableNetCore.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
    }
}
