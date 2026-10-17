using Microsoft.AspNetCore.Mvc;

namespace hotelera.Controllers;

public class ServiciosController : Controller
{
    // Carga Views/Servicios/Index.cshtml
    public IActionResult Index()
    {
        return View();
    }
}
