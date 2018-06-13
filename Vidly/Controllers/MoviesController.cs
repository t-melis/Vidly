using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }
        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };

        //    //return View(movie);
        //    //return HttpNotFound();

        //    var customers = new List<Customer>()
        //    {
        //        new Customer() { Name = "Customer1" },
        //        new Customer() { Name = "Customer2" }
        //    };

        //    var randomMovieViewModel = new RandomMovieViewModel()
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };

        //    return View(randomMovieViewModel);
        //}

        //public ActionResult Edit(int id)
        //{
        //    return Content("id = " + id);
        //}


        // GET movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(string.Format("pageIndex={0}&sortBY={1}", pageIndex, sortBy));
        //}



        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{ Id = 1, Name = "Shrek" },
                new Movie{ Id = 2, Name = "Wall-e" }
            };
        }


    }
}