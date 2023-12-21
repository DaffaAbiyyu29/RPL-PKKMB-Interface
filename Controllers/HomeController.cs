using Microsoft.AspNetCore.Mvc;
using PKKMB_Interface.Models;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;

namespace PKKMB_Interface.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			/*string token = Request.Cookies["token"];

			if (token != null)
			{
				var handler = new JwtSecurityTokenHandler();
				var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

				if (jsonToken != null)
				{
					// Create a dictionary to store claims
					var claimsDictionary = new Dictionary<string, object>();

					foreach (var claim in jsonToken.Claims)
					{
						// Store each claim in the dictionary
						claimsDictionary[claim.Type] = claim.Value;
					}

					// Add the dictionary to ViewBag
					ViewBag.Claims = claimsDictionary;
				}
				else
				{
					ViewBag.ErrorMessage = "Invalid JWT token";
				}
			}
			else
			{
				ViewBag.ErrorMessage = "Token cookie not found";
			}*/

			return View();
		}

		public IActionResult Dashboard()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Login", "Access");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}