using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace PKKMB_Interface.Controllers
{
	public class AbsensiController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Route("Absensi/TambahAbsensi/{kmk_idkelompok}")]
		public IActionResult Tambah(string kmk_idkelompok)
		{
			if (HttpContext.Request.Cookies["token"] != null)
			{
				string userToken = HttpContext.Request.Cookies["token"];
				ViewBag.UserToken = userToken;

				var handler = new JwtSecurityTokenHandler();
				var jsonToken = handler.ReadToken(userToken) as JwtSecurityToken;
				var userId = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "id")?.Value;
				var userName = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "name")?.Value;
				var userRole = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "role")?.Value;

				if (userRole == "Fasilitator")
				{
					ViewBag.UserId = userId;
					ViewBag.UserName = userName;
					ViewBag.UserRole = userRole;
					ViewBag.kmk_idkelompok = kmk_idkelompok;
					return View();
				}
				else
				{
					return RedirectToAction("Index", "Home");
				}
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
		}
	}
}
