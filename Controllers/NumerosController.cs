using Microsoft.AspNetCore.Mvc;

namespace PracticaAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class NumerosController : ControllerBase
	{
		[HttpGet("analizar")]
		public IActionResult Analizar(int n)
		{
			bool esPar = n % 2 == 0;

			bool esPrimo = true;

			if (n <= 1)
			{
				esPrimo = false;
			}
			else
			{
				for (int i = 2; i <= Math.Sqrt(n); i++)
				{
					if (n % i == 0)
					{
						esPrimo = false;
						break;
					}
				}
			}

			string signo;

			if (n > 0)
				signo = "Positivo";
			else if (n < 0)
				signo = "Negativo";
			else
				signo = "Cero";

			return Ok(new
			{
				numero = n,
				esPar,
				esPrimo,
				signo
			});
		}
	}
}