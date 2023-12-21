using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
	public class MahasiswaBaruController : Controller
	{
		private readonly IConfiguration _configuration;

		public MahasiswaBaruController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public IActionResult Index()
		{
			ViewBag.url = _configuration.GetSection("AppSettings:url").Value;
			return View();
		}

		[Route("mahasiswabaru/update/{mhs_nopendaftaran}")]
		public IActionResult Update(string mhs_nopendaftaran)
		{
			ViewBag.mhs_nopendaftaran = mhs_nopendaftaran;
			return View();
		}

		[Route("mahasiswabaru/dashboard")]
		public IActionResult Dashboard()
		{
			return View();
		}
	}
}
