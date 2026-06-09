using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Boletim.Models;

namespace Boletim.Controllers;

public class BoletimController : Controller
{
    private void PopulateNotas()
    {
        ViewBag.disciplina = new List<string>
        {
            "Desenvolvimento para internet",
            "Internet das Coisas",
            "Programação Front-End",
            "Arquitetura de Computadores"
        };

        ViewBag.nota = new List<double> { 9, 7.5, 5.0, 3.0 };
    }

    public IActionResult Index()
    {
        PopulateNotas();
        return View("Boletim");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Boletim()
    {
        PopulateNotas();
        return View();
    }
    
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}