using Microsoft.AspNetCore.Mvc;

namespace hotelera.Controllers;

public class PerfilController : Controller
{
    // Carga Views/Perfil/Index.cshtml
    public IActionResult Index()
    {
        return View();
    }
}
