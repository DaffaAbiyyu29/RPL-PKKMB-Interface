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
			return View();
		}

		public IActionResult Dashboard()
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

				ViewBag.UserId = userId;
				ViewBag.UserName = userName;
				ViewBag.UserRole = userRole;
				return View();
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
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