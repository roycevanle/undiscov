using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!", ID = 2 };
            return View(movie);
        }

        /*public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        } */

        /* public ActionResult Index(int? pageIndex, string sortBy)
         {
             if(!pageIndex.HasValue)
             {
                 pageIndex = 1;C:\Users\rle\Documents\Visual Studio 2015\Projects\Vidly\Vidly\Models\Movie.cs
             }
             if (String.IsNullOrWhiteSpace(sortBy))
             {
                 sortBy = "Name";
             }
             return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
         }*/
        
            [Route("movies/released/{year}/{month:regex(\\d{4}0}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}