using Microsoft.AspNetCore.Mvc;
using PKKMB_Interface.Models;
using System.IdentityModel.Tokens.Jwt;

namespace PKKMB_Interface.Controllers
{
	public class JamPlusMinusController : Controller
	{
		private readonly ValidateToken _valid;

		public JamPlusMinusController(ValidateToken validateToken)
		{
			_valid = validateToken;
		}

		public IActionResult Index()
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

					ViewBag.UserId = userId;
					ViewBag.UserName = userName;
					ViewBag.UserRole = userRole;

					return View();
				}
			}

			return RedirectToAction("Index", "Home");
		}

		[Route("JamPlusMinus/TambahJam")]
		public IActionResult TambahJam(string nls_idnilaisikap)
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

					if (userRole == "Fasilitator")
					{
						ViewBag.UserId = userId;
						ViewBag.UserName = userName;
						ViewBag.UserRole = userRole;

						ViewBag.nls_idnilaisikap = nls_idnilaisikap;
						return View();
					}
				}
			}

			return RedirectToAction("Index", "Home");
		}

		[Route("JamPlusMinus/DetailJam/{dtj_nopendaftaran}")]
		public IActionResult DetailJam(string dtj_nopendaftaran)
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

					if (userRole == "Fasilitator" || userRole == "KSK" || userRole == "PIC PKKMB" || userRole == "Mahasiswa")
					{
						ViewBag.UserId = userId;
						ViewBag.UserName = userName;
						ViewBag.UserRole = userRole;

						ViewBag.dtj_nopendaftaran = dtj_nopendaftaran;
						return View();
					}
				}
			}

			return RedirectToAction("Index", "Home");
		}

		[Route("JamPlusMinus/UbahJam/{dtj_idjam}/{dtj_nopendaftaran}")]
		public IActionResult UbahJam(string dtj_idjam, string dtj_nopendaftaran)
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

					if (userRole == "Fasilitator")
					{
						ViewBag.UserId = userId;
						ViewBag.UserName = userName;
						ViewBag.UserRole = userRole;

						ViewBag.dtj_idjam = dtj_idjam;
						ViewBag.dtj_nopendaftaran = dtj_nopendaftaran;
						return View();
					}
				}
			}

			return RedirectToAction("Index", "Home");
		}
	}
}
