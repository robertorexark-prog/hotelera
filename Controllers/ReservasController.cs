using Microsoft.AspNetCore.Mvc;

namespace hotelera.Controllers;

public class ReservasController : Controller
{
    // Carga Views/Reservas/Index.cshtml
    public IActionResult Index()
    {
        return View();
    }
}
