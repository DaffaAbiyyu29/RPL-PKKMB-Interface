using Microsoft.AspNetCore.Mvc;
using PKKMB_Interface.Models;
using System.IdentityModel.Tokens.Jwt;

namespace PKKMB_Interface.Controllers
{
	public class AkunController : Controller
	{
		private readonly ValidateToken _valid;

		public AkunController(ValidateToken validateToken)
		{
			_valid = validateToken;
		}

		[Route("/Akun/Login")]
		public IActionResult Login()
		{
			return View();
		}

		public IActionResult DaftarAkun()
		{
			return View();
		}

		public IActionResult LupaKataSandi()
		{
			return View();
		}

		public IActionResult ResetKataSandi()
		{
			if (HttpContext.Request.Cookies["VerifyEmail"] != null)
			{
				string userToken = HttpContext.Request.Cookies["VerifyEmail"];

				if (_valid.ValidateTokenFromCookies(userToken))
				{
					ViewBag.UserToken = userToken;

					var handler = new JwtSecurityTokenHandler();
					var jsonToken = handler.ReadToken(userToken) as JwtSecurityToken;
					var userId = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "id")?.Value;
					var userName = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "name")?.Value;
					var userRole = jsonToken?.Claims?.FirstOrDefault(claim => claim.Type == "role")?.Value;

					ViewBag.UserId = userId;
					ViewBag.UserName = userName;
					ViewBag.UserRole = userRole;

					return View();
				}
			}

			return RedirectToAction("Index", "Home");
		}

		[Route("/Akun/Ubah/{username}")]
		public IActionResult UbahAkun(string username)
		{
			ViewBag.username = username;
			return View();
		}
	}
}
