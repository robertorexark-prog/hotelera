using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hotelera.Models;

namespace hotelera.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
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
