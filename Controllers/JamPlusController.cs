using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class JamPlusController : Controller
	{
		[Route("jamplus/tambahjamplus/{nls_idnilaisikap}")]
		public IActionResult tambahjamplus(string nls_idnilaisikap)
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
