using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class AkunController : Controller
	{
		[Route("/Akun/Login")]
		public IActionResult Login()
		{
			return View();
		}

		public IActionResult DaftarAkun()
		{
			return View();
		}

		public IActionResult LupaKataSandi()
		{
			return View();
		}

		[Route("/Akun/Ubah/{username}")]
		public IActionResult UbahAkun(string username)
		{
			ViewBag.username = username;
			return View();
		}
	}
}
