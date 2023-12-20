using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class JamMinusController : Controller
	{
		[Route("jamminus/tambahjamminus/{nls_idnilaisikap}")]
		public IActionResult tambahjamminus(string nls_idnilaisikap)
		{
			ViewBag.nls_idnilaisikap = nls_idnilaisikap;
			return View();
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
