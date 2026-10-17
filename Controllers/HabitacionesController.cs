using Microsoft.AspNetCore.Mvc;
using hotelera.Models;

namespace hotelera.Controllers;

public class HabitacionesController : Controller
{
    // Carga Views/Habitaciones/Index.cshtml
    public IActionResult Index()
    {
        return View();
    }

    // Carga Views/Habitaciones/Detalle.cshtml (botón "Ver detalle" del inicio)
    public IActionResult Detalle(int id)
    {
        var tipo = HomeController.HabitacionesDestacadas.FirstOrDefault(h => h.IdTipoHab == id);
        if (tipo == null)
        {
            return NotFound();
        }

        return View(tipo);
    }
}
