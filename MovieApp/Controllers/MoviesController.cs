using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        [HttpGet]
        public ActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddMovie(Movie m)
        {
            if (ModelState.IsValid)
            {
                ViewBag.MovieDetails =
                    $"Movie Title: {m.title}" + "<br/> <br/>" +
                    $"Release Date: {m.releaseDate.ToString("MMMM yyyy")}" + "<br/> <br/>" +
                    $"Genre: {m.genre}" + "<br/> </br>" +
                    $"Price: {m.price.ToString("C")}" + "<br/> <br/>" +
                    $"Is movie discounted:? {m.isMovieDiscounted()}";
                return View("ShowMovie");
            }
            else
            {
                return View();
            }
        }
    }
}