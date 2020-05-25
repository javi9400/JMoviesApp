using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JMoviesApp.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JMoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        private JMoviesAppContext _context;
        public MoviesController(JMoviesAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public IActionResult Details(int id)
        {
            var movie = _context.Movies.Include(x=>x.Genre).SingleOrDefault(x => x.Id == id);

            return View(movie);
        }

    }
}