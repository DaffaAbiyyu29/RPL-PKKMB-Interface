using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class PicPkkmbController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Route("picpkkmb/update/{pic_npk}")]
		public IActionResult Update(string pic_npk)
		{
			ViewBag.pic_npk = pic_npk;
			return View();
		}

		[Route("picpkkmb/loginpic")]
		public IActionResult LoginPic()
		{
			Response.Cookies.Delete(".AspNetCore.Session");
			ViewBag.role = "Pic";
			return View();
		}

		[Route("picpkkmb/daftarpic")]
		public IActionResult DaftarAkunPic()
		{
			return View();
		}

		[Route("picpkkmb/resetpasswordpic")]
		public IActionResult LupaPasswordPic()
		{
			return View();
		}

		[Route("picpkkmb/panitiaksk")]
		public IActionResult PanitiaKSK()
		{
			return View();
		}

		[Route("picpkkmb/jadwal")]
		public IActionResult Jadwal()
		{
			return View();
		}

		[Route("picpkkmb/kelompok")]
		public IActionResult Kelompok()
		{
			return View();
		}

		[Route("picpkkmb/ruangan")]
		public IActionResult Ruangan()
		{
			return View();
		}

		[Route("picpkkmb/tugas")]
		public IActionResult Tugas()
		{
			return View();
		}

		[Route("picpkkmb/absensi")]
		public IActionResult Absensi()
		{
			return View();
		}

		[Route("picpkkmb/jamplus")]
		public IActionResult JamPlus()
		{
			return View();
		}

		[Route("picpkkmb/jamminus")]
		public IActionResult JamMinus()
		{
			return View();
		}

		[Route("picpkkmb/sikap")]
		public IActionResult Sikap()
		{
			return View();
		}

		[Route("picpkkmb/kelulusan")]
		public IActionResult Kelulusan()
		{
			return View();
		}

		[Route("picpkkmb/evaluasi")]
		public IActionResult Evaluasi()
		{
			return View();
		}
	}
}
