using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PKKMB_Interface.Models
{
	public class ValidateToken
	{
		public bool ValidateTokenFromCookies(string jwtToken)
		{
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.UTF8.GetBytes("UEtLTUIgQXN0cmEgUG9seXRlY2huaWM=");

			var validationParameters = new TokenValidationParameters
			{
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey(key),
				ValidateIssuer = false, // Set to true if you want to validate the issuer
				ValidateAudience = false, // Set to true if you want to validate the audience
				ValidateLifetime = true, // Set to true if you want to validate the expiration time
				ClockSkew = TimeSpan.Zero // Set the clock skew to zero to account for time differences
			};

			SecurityToken validatedToken;
			try
			{
				ClaimsPrincipal principal = tokenHandler.ValidateToken(jwtToken, validationParameters, out validatedToken);
				// You can access the claims from the principal variable if needed
				// e.g., var userId = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
				return true; // Token is valid
			}
			catch (Exception ex)
			{
				// Token validation failed
				return false;
			}
		}
	}
}
