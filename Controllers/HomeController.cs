using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinhaApp.Models;

namespace MinhaApp.Controllers;
[Route("")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        var filme = new Filme
        {
            Titulo = "Velozes e Furiosos",
            DataLancamento = DateTime.Now,
            Avaliacao = 4,
            Genero = "Drama",
            Valor = 100,
        };
        // return RedirectToAction("Privacy", filme);
        return View("Index");
    }

    [Route("privacy")]
    public IActionResult Privacy(Filme filme)
    {
        if (ModelState.IsValid)
        {
            return View("Privacy");

            // return Json(filme);
        }
        else
            foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
        return View("Privacy");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [Route("error")]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
