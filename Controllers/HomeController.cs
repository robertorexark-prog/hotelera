using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hotelera.Models;

namespace hotelera.Controllers;

public class HomeController : Controller
{
    // Habitaciones simuladas mientras no nos conectamos a SQL Server.
    // Cuando exista el DbContext, cambiar por una consulta a tipos_habitacion.
    public static readonly List<HabitacionDestacadaViewModel> HabitacionesDestacadas = new()
    {
        new HabitacionDestacadaViewModel
        {
            IdTipoHab = 1,
            NombreTipo = "Sencilla",
            Descripcion = "Habitación cómoda para 1 persona. Ideal para viajes rápidos de negocios.",
            CapacidadMaxima = 1,
            PrecioBase = 800m
        },
        new HabitacionDestacadaViewModel
        {
            IdTipoHab = 2,
            NombreTipo = "Doble Estándar",
            Descripcion = "Perfecta para parejas o amigos. Espacio amplio y amenidades completas.",
            CapacidadMaxima = 2,
            PrecioBase = 1500m
        },
        new HabitacionDestacadaViewModel
        {
            IdTipoHab = 3,
            NombreTipo = "Suite Presidencial",
            Descripcion = "Máximo lujo y confort. Incluye sala de estar y vista panorámica.",
            CapacidadMaxima = 4,
            PrecioBase = 3500m
        }
    };

    // Inicio: banner con buscador rápido + cuadrícula de tipos de habitación.
    // El buscador envía por GET a esta misma acción y filtra por capacidad.
    public IActionResult Index([Bind(Prefix = "Busqueda")] BusquedaHabitacionViewModel busqueda)
    {
        var hayBusqueda = Request.Query.ContainsKey("Busqueda.Huespedes");

        if (hayBusqueda && busqueda.FechaEntrada.HasValue && busqueda.FechaSalida.HasValue
            && busqueda.FechaSalida <= busqueda.FechaEntrada)
        {
            ModelState.AddModelError("Busqueda.FechaSalida", "La salida debe ser posterior a la llegada.");
        }

        var habitaciones = HabitacionesDestacadas.AsEnumerable();
        if (hayBusqueda && ModelState.IsValid)
        {
            habitaciones = habitaciones.Where(h => h.CapacidadMaxima >= busqueda.Huespedes);
        }

        var modelo = new HomeIndexViewModel
        {
            Busqueda = busqueda,
            Habitaciones = habitaciones.ToList(),
            HayBusqueda = hayBusqueda && ModelState.IsValid
        };

        return View(modelo);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    // Carga Views/Home/Reservas.cshtml
    public IActionResult Reservas()
    {
        return View();
    }

    // Carga Views/Home/Dashboard.cshtml
    public IActionResult Dashboard()
    {
        return View();
    }
}
