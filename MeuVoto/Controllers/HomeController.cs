using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeuVoto.Controllers
{
	public class HomeController : Controller
	{
		private string Logado { get; set; }

		#region Eventos Get
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Error()
		{
			return View();
		}
		public IActionResult Login()
		{
			return View();
		}
		public IActionResult Login([FromBody]object model)
		{
			return View();
		}
		#endregion

		public void Votar()
		{

		}
		[HttpPost]
		public IActionResult Login([FromBody]object model)
		{
			return View();
		}
	}
}
