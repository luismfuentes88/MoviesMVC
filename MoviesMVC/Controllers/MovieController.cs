using MoviesMVC.Models;
using MoviesMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesMVC.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer() { Name = "Customer 1" },
                new Customer() { Name = "Customer 2" },
                new Customer() { Name = "Customer 3" },
                new Customer() { Name = "Customer 4" },
                //new Customer() { Name = "Customer 5" },
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/release/{year}/{month}")]
        public ActionResult GetByReleaseDate(int year, string month)
        {
            return Content(String.Format("{0}/{1}", year, month));
        }
    }
}