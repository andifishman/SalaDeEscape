using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SALADEESCAPE_HOSPITAL.Models;
using Newtonsoft.Json;

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
        return View();
    }
    public IActionResult Tutorial()
    {
        return View("Tutorial");
    }
    public IActionResult Jugar()
    {
        Salas sala = new Salas();
        HttpContext.Session.SetString("sala", Objeto.ObjectToString(sala));
        return View("Sala1");
    }
    public IActionResult Sala2()
    {
        Salas sala =Objeto.StringToObject<Salas>(HttpContext.Session.GetString("sala"));
        sala.llaveTrue();
        HttpContext.Session.SetString("sala", Objeto.ObjectToString(sala));
        return View("Sala2");
    }
    public IActionResult Sala3()
    {
        Salas sala =Objeto.StringToObject<Salas>(HttpContext.Session.GetString("sala"));
        sala.luzTrue();
        HttpContext.Session.SetString("sala", Objeto.ObjectToString(sala));
        return View("Sala3");
    }
    public IActionResult Codigo(int num)
    {
        Salas sala =Objeto.StringToObject<Salas>(HttpContext.Session.GetString("sala"));
        sala.num(num);
        string palabra=sala.mismoNum();
        HttpContext.Session.SetString("sala", Objeto.ObjectToString(sala));
        return View(palabra);
    }
    public IActionResult Sala4(string palabra)
    {
        Salas sala =Objeto.StringToObject<Salas>(HttpContext.Session.GetString("sala"));
        sala.palabra(palabra);
        string palabraSala4=sala.mismaPalabra();
        HttpContext.Session.SetString("sala", Objeto.ObjectToString(sala));
        return View(palabraSala4);
    }
    
}
