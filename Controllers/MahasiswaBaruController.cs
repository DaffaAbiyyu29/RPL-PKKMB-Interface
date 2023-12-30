using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace PKKMB_Interface.Controllers
{
	public class MahasiswaBaruController : Controller
	{
		private readonly IConfiguration _configuration;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public MahasiswaBaruController(IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
		{
			_configuration = configuration;
			_httpContextAccessor = httpContextAccessor;
		}

		[Route("Mahasiswa")]
		public IActionResult Index()
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

				if (userRole == "Mahasiswa")
				{
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
			else
			{
				return RedirectToAction("Index", "Home");
			}
		}

		[Route("Mahasiswa/Dashboard")]
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

				if (userRole == "Mahasiswa")
				{
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
			else
			{
				return RedirectToAction("Index", "Home");
			}
		}

		[Route("Mahasiswa/Evaluasi")]
		public IActionResult Evaluasi()
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

				if (userRole == "Mahasiswa")
				{
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
			else
			{
				return RedirectToAction("Index", "Home");
			}
		}

		[Route("Mahasiswa/KirimEvaluasi")]
		public IActionResult KirimEvaluasi()
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

				if (userRole == "Mahasiswa")
				{
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
			else
			{
				return RedirectToAction("Index", "Home");
			}
		}
	}
}
