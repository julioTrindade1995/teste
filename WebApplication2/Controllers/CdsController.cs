using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
	public class CdsController : Controller
	{
		//
		// GET: /Movies/random
		public ActionResult Random()
		{
			var cds = new Cds() { nome = "Black Album", estilo =" Metal"};
			
			return View(cds);
		}
	}
}