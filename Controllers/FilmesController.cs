using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaApp.Models;

namespace MinhaApp.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adcionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adcionar(Filme filme)
        {
            if (ModelState.IsValid) return Json(filme);
            else
                foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            return View(filme);
        }

    }
}