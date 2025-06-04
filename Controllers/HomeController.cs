using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SALADEESCAPE_HOSPITAL.Models;

namespace SALADEESCAPE_HOSPITAL.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Salas sala = new Salas();
        HttpContext.Session.SetString("sala", Objeto.ObjectToString(sala));
        return View();
    }
    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }
    public IActionResult Jugar()
    {
        return View("Sala1");
    }
    public IActionResult Sala2()
    {
        Salas sala =Objeto.StringToObject<Salas>(HttpContext.Session.GetString("sala"));
        sala.llaveSala1=true;
        HttpContext.Session.SetString("sala", Objeto.ObjectToString(sala));
        return View("Sala2");
    }
    public IActionResult Sala3()
    {
        Salas sala =Objeto.StringToObject<Salas>(HttpContext.Session.GetString("sala"));
        sala.luzSala2=true;
        HttpContext.Session.SetString("sala", Objeto.ObjectToString(sala));
        return View("Sala3");
    }
    public IActionResult Codigo(int num){
        Salas sala =Objeto.StringToObject<Salas>(HttpContext.Session.GetString("sala"));
        sala.numIngresado=num;
        string palabra=sala.mismoNum();
        HttpContext.Session.SetString("sala", Objeto.ObjectToString(sala));
        return View(palabra);
    }
    
}
