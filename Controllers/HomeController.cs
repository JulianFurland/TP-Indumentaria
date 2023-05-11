using Microsoft.AspNetCore.Mvc;

namespace TP4.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.DicEquipos = Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        return View();
    }
    public IActionResult GuardarIndumentaria(string Equipo, int Medias, int Pantalon, int Remera)
    {
        Indumentaria ind = new Indumentaria(Equipos.ListaMedias[Medias-1], Equipos.ListaPantalones[Pantalon-1], Equipos.ListaRemeras[Remera-1]);
        Equipos.IngresarIndumentaria(Equipo,ind);
        return RedirectToAction("Index");
        
    }
}
