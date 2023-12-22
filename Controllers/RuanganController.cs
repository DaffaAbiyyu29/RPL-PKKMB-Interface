using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class RuanganController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult tambahruangan()
		{
			return View();
		}

		[Route("ruangan/ubahruangan/{rng_idruangan}")]
		public IActionResult ubahruangan(string rng_idruangan)
		{
			ViewBag.rng_idruangan = rng_idruangan;
			return View();
		}
	}
}
