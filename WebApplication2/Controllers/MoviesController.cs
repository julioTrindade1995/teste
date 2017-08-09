using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/random
        public ActionResult Random()
        {
            var movie = new Movie() { nome = "shrek" };
            return View(movie);
        }
	}
}