using FilmDB.Logic;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        FilmManager filmManager = new FilmManager();
        
        public IActionResult Index()
        {
            var random = new Random();
            var film = new FilmModel()
            {

                Title = $"Rambo{random.Next(1, 100)}",
                Year = 1999
            };
            filmManager.AddFilm(film);
            return View();
        }
    }
}
