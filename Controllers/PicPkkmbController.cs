using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class PicPkkmbController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Route("/PicPkkmb/Update/{pic_nokaryawan}")]
		public IActionResult Update(string pic_nokaryawan)
		{
			ViewBag.pic_nokaryawan = pic_nokaryawan;
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

		[Route("picpkkmb/dashboard")]
		public IActionResult Dashboard()
		{
			return View();
		}
	}
}
