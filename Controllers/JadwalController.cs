using Microsoft.AspNetCore.Mvc;
using PKKMB_Interface.Models;
using System.IdentityModel.Tokens.Jwt;

namespace PKKMB_Interface.Controllers
{
	public class JadwalController : Controller
	{
		private readonly ValidateToken _valid;

		public JadwalController(ValidateToken validateToken)
		{
			_valid = validateToken;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Tambah()
		{
			if (HttpContext.Request.Cookies["token"] != null)
			{
				string userToken = HttpContext.Request.Cookies["token"];

				if (_valid.ValidateTokenFromCookies(userToken))
				{
					ViewBag.UserToken = userToken;

					var handler = new JwtSecurityTokenHandler();
					var jsonToken = handler.ReadToken(userToken) as JwtSecurityToken;
					var userId = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "id")?.Value;
					var userName = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "name")?.Value;
					var userRole = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "role")?.Value;

					if (userRole == "KSK")
					{
						ViewBag.UserId = userId;
						ViewBag.UserName = userName;
						ViewBag.UserRole = userRole;

						return View();
					}
				}
			}

			return RedirectToAction("Index", "Home");
		}

		[Route("jadwal/ubah/{jdl_idjadwal}")]
		public IActionResult ubah(string jdl_idjadwal)
		{
			if (HttpContext.Request.Cookies["token"] != null)
			{
				string userToken = HttpContext.Request.Cookies["token"];

				if (_valid.ValidateTokenFromCookies(userToken))
				{
					ViewBag.UserToken = userToken;

					var handler = new JwtSecurityTokenHandler();
					var jsonToken = handler.ReadToken(userToken) as JwtSecurityToken;
					var userId = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "id")?.Value;
					var userName = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "name")?.Value;
					var userRole = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "role")?.Value;

					if (userRole == "KSK")
					{
						ViewBag.UserId = userId;
						ViewBag.UserName = userName;
						ViewBag.UserRole = userRole;

						ViewBag.jdl_idjadwal = jdl_idjadwal;
						return View();
					}
				}
			}

			return RedirectToAction("Index", "Home");
		}
	}
}
