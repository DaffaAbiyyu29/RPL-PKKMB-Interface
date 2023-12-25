using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace PKKMB_Interface.Models
{
	public class PermissionsPolicyMiddleware
	{
		private readonly RequestDelegate _next;

		public PermissionsPolicyMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			// Lakukan operasi middleware di sini

			// Panggil delegasi berikutnya dalam pipeline
			await _next(context);
		}
	}
}
