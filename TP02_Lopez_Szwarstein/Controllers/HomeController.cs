using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP02.Models;

namespace TP02.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        //Grupo.InicializarGrupo();
        // GrupoNuevo = Grupo.devolverGrupo();
        // ViewBag.GrupoNuevo = GrupoNuevo;
        // Grupo.InicializarGrupo();
        ViewBag.grupo = Grupo.devolverGrupo();
        if(ViewBag.grupo.Count == 0){
             Grupo.InicializarGrupo(); 
             ViewBag.grupo = Grupo.devolverGrupo();
        }
        return View();
    }
    public IActionResult SelectIntegrantes(int dni){
            ViewBag.IntegranteDP = Grupo.Integrantes[dni].DatosPersonales;
            ViewBag.DNI = dni;
        return View();
    } 
    public IActionResult InfoDatosFamiliares(int dni){    
        ViewBag.DatosFamiliares= Grupo.Integrantes[dni].DatosFamiliares;
        return View();

    }
    public IActionResult InfoDatosInteres(int dni){
        ViewBag.DatosIntereses = Grupo.Integrantes[dni].DatosIntereses;
        return View();
    }
}


