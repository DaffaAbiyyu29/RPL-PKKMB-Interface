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
	}
}
