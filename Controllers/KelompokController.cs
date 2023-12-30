using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class KelompokController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Route("Kelompok/TambahKelompok")]
		public IActionResult Tambah()
		{
			return View();
		}

		[Route("Kelompok/TambahAnggota/{kmk_idkelompok}")]
		public IActionResult TambahAnggota(string kmk_idkelompok)
		{
			ViewBag.kmk_idkelompok = kmk_idkelompok;
			return View();
		}

		[Route("Kelompok/UbahKelompok/{kmk_idkelompok}")]
		public IActionResult Ubah(string kmk_idkelompok)
		{
			ViewBag.kmk_idkelompok = kmk_idkelompok;
			return View();
		}

		[Route("Kelompok/DetailKelompok/{kmk_idkelompok}")]
		public IActionResult Detail(string kmk_idkelompok)
		{
			ViewBag.kmk_idkelompok = kmk_idkelompok;
			return View();
		}
	}
}
