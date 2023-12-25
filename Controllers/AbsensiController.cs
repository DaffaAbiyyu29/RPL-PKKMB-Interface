using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
    public class AbsensiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Absensi/Create/{abs_idabsensi}")]
        public IActionResult Create(string abs_idabsensi)
        {
            ViewBag.abs_idabsensi = abs_idabsensi;
            return View();
        }
    }
}
