using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class TugasController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult TambahTugas()
		{
			return View();
		}

		[Route("Tugas/UbahTugas/{tgs_idtugas}")]
		public IActionResult UbahTugas(string tgs_idtugas)
		{
			ViewBag.tgs_idtugas = tgs_idtugas;
			return View();
		}

		public IActionResult PengumpulanTugas()
		{
			return View();
		}
	}
}
