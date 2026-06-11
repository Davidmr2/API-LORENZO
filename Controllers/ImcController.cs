using Microsoft.AspNetCore.Mvc;

namespace PracticaAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ImcController : ControllerBase
	{
		[HttpGet("calcular")]
		public IActionResult Calcular(double peso, double altura)
		{
			double imc = peso / (altura * altura);

			string categoria;

			if (imc < 18.5)
				categoria = "Bajo peso";
			else if (imc < 25)
				categoria = "Normal";
			else if (imc < 30)
				categoria = "Sobrepeso";
			else
				categoria = "Obesidad";

			return Ok(new
			{
				peso,
				altura,
				imc = Math.Round(imc, 2),
				categoria
			});
		}
	}
}