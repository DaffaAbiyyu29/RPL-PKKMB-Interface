using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class PanitiaKesekretariatanController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult VerifikasiKSK()
		{
			return View();
		}
	}
}
