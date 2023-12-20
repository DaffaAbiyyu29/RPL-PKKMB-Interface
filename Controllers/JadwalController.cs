using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class JadwalController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Tambah()
		{
			return View();
		}

		[Route("jadwal/ubah/{jdl_idjadwal}")]
		public IActionResult ubah(string jdl_idjadwal)
		{
			ViewBag.jdl_idjadwal = jdl_idjadwal;
			return View();
		}
	}
}
