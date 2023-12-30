using Microsoft.AspNetCore.Mvc;
using PKKMB_Interface.Models;
using System.IdentityModel.Tokens.Jwt;

namespace PKKMB_Interface.Controllers
{
	public class SikapController : Controller
	{
		private readonly ValidateToken _valid;

		public SikapController(ValidateToken validateToken)
		{
			_valid = validateToken;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult tambahnilaisikap()
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

		[Route("sikap/ubahnilaisikap/{nls_idnilaisikap}")]
		public IActionResult ubahnilaisikap(string nls_idnilaisikap)
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

						ViewBag.nls_idnilaisikap = nls_idnilaisikap;
						return View();
					}
				}
			}

			return RedirectToAction("Index", "Home");
		}
	}
}