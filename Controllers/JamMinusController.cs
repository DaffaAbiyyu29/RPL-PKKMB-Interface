using Microsoft.AspNetCore.Mvc;
using PKKMB_Interface.Models;
using System.IdentityModel.Tokens.Jwt;

namespace PKKMB_Interface.Controllers
{
	public class JamMinusController : Controller
	{
		private readonly ValidateToken _valid;

		public JamMinusController(ValidateToken validateToken)
		{
			_valid = validateToken;
		}

		[Route("jamminus/tambahjamminus/{nls_idnilaisikap}")]
		public IActionResult tambahjamminus(string nls_idnilaisikap)
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
		public IActionResult Index()
		{
			return View();
		}
	}
}
