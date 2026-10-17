using System.ComponentModel.DataAnnotations;

namespace hotelera.Models;

// Datos que necesita Views/Home/Index.cshtml: el buscador del banner y las tarjetas
public class HomeIndexViewModel
{
    public BusquedaHabitacionViewModel Busqueda { get; set; } = new();
    public List<HabitacionDestacadaViewModel> Habitaciones { get; set; } = new();

    // true cuando el usuario ya envió el buscador
    public bool HayBusqueda { get; set; }
}

// Campos del buscador rápido (fechas y huéspedes)
public class BusquedaHabitacionViewModel
{
    [Display(Name = "Llegada")]
    [DataType(DataType.Date)]
    public DateTime? FechaEntrada { get; set; }

    [Display(Name = "Salida")]
    [DataType(DataType.Date)]
    public DateTime? FechaSalida { get; set; }

    [Display(Name = "Huéspedes")]
    [Range(1, 10, ErrorMessage = "Elige entre 1 y 10 huéspedes.")]
    public int Huespedes { get; set; } = 2;
}
