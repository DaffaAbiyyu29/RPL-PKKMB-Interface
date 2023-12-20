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

		[Route("mahasiswabaru/loginmahasiswa")]
		public IActionResult LoginMahasiswa()
		{
			Response.Cookies.Delete(".AspNetCore.Session");
			ViewBag.role = "Mahasiswa";
			ViewBag.url = _configuration.GetSection("AppSettings:url").Value;
			return View();
		}

		[Route("mahasiswabaru/daftarmahasiswa")]
		public IActionResult DaftarAkunMahasiswa()
		{
			return View();
		}

		[Route("mahasiswabaru/resetpasswordmahasiswa")]
		public IActionResult LupaPasswordMahasiswa()
		{
			return View();
		}

		[Route("mahasiswabaru/jadwalpkkmb")]
		public IActionResult Jadwal()
		{
			return View();
		}

		[Route("mahasiswabaru/tugas")]
		public IActionResult Tugas()
		{
			return View();
		}

		[Route("mahasiswabaru/absensi")]
		public IActionResult Absensi()
		{
			return View();
		}

		[Route("mahasiswabaru/jamplus")]
		public IActionResult JamPlus()
		{
			return View();
		}

		[Route("mahasiswabaru/jamminus")]
		public IActionResult JamMinus()
		{
			return View();
		}

		[Route("mahasiswabaru/sikap")]
		public IActionResult Sikap()
		{
			return View();
		}

		[Route("mahasiswabaru/kelompok")]
		public IActionResult Kelompok()
		{
			return View();
		}

		[Route("mahasiswabaru/evaluasi")]
		public IActionResult Evaluasi()
		{
			return View();
		}

		[Route("mahasiswabaru/kelulusan")]
		public IActionResult Kelulusan()
		{
			return View();
		}

		[Route("mahasiswabaru/sarankritik")]
		public IActionResult TambahSaranKritik()
		{
			return View();
		}
	}
}
