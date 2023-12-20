using Microsoft.AspNetCore.Mvc;

namespace PKKMB_Interface.Controllers
{
    public class SikapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult tambahnilaisikap()
        {
            return View();
        }

        [Route("sikap/ubahnilaisikap/{nls_idnilaisikap}")]
        public IActionResult ubahnilaisikap(string nls_idnilaisikap)
        {
            ViewBag.nls_idnilaisikap = nls_idnilaisikap;
            return View();
        }
    }
}