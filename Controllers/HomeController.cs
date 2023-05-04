using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

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
    public IActionResult GuardarIndumentaria(string Equipo, string Medias, string Pantalon, string Remera)
    {
        if(Equipo == string.Empty || Medias == string.Empty || Pantalon == string.Empty || Remera == string.Empty)
        {
            ViewBag.Error = true;
            return RedirectToAction("SelecIndumentaria");
        }
        else
        {
            Indumentaria ind = new Indumentaria(Medias, Pantalon, Remera);
            Equipos.IngresarIndumentaria(Equipo,ind);
            return RedirectToAction("Index");
        }
    }
}
