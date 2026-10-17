namespace hotelera.Models;

// Tarjeta de habitación que se muestra en el inicio.
// Refleja tipos_habitacion (+ la foto de galeria_fotos); por ahora se llena con datos simulados.
public class HabitacionDestacadaViewModel
{
    public int IdTipoHab { get; set; }
    public string NombreTipo { get; set; } = "";
    public string? Descripcion { get; set; }
    public int CapacidadMaxima { get; set; }
    public decimal PrecioBase { get; set; }
    public string? UrlImagen { get; set; }
}
