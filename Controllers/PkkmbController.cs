using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class PkkmbController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		
		public IActionResult TambahTahun()
		{
			return View();
		}

		[Route("/Pkkmb/UbahTahun/{pkm_idPkkmb}")]
		public IActionResult UbahTahun(string pkm_idPkkmb)
		{
			ViewBag.pkm_idPkkmb = pkm_idPkkmb;
			return View();
		}
	}
}
