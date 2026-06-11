using Microsoft.AspNetCore.Mvc;

namespace PracticaAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class PropinaController : ControllerBase
	{
		[HttpGet("calcular")]
		public IActionResult Calcular(decimal monto, decimal porcentaje)
		{
			decimal propina = monto * porcentaje / 100;
			decimal total = monto + propina;

			return Ok(new
			{
				monto,
				porcentaje,
				propina,
				total
			});
		}
	}
}