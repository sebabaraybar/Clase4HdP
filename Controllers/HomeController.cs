using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Clase4.Models;
using Clase4.Models;
using Proyecto1.Services;

namespace Clase4.Controllers;

public class HomeController : Controller
{
    public HomeController(ILogger<HomeController> logger)
    {
    }

    public IActionResult Index()
    {
        var model = new List<Movie>();
        model = MovieService.GetAll();
        return View(model);
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
}
