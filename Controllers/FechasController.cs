using Microsoft.AspNetCore.Mvc;

namespace PracticaAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class FechasController : ControllerBase
	{
		[HttpGet("diferencia")]
		public IActionResult Diferencia(DateTime desde, DateTime hasta)
		{
			int dias = (hasta - desde).Days;

			return Ok(new
			{
				desde,
				hasta,
				dias
			});
		}

		[HttpGet("agregar")]
		public IActionResult Agregar(DateTime fecha, int dias)
		{
			DateTime nuevaFecha = fecha.AddDays(dias);

			return Ok(new
			{
				fechaOriginal = fecha,
				diasAgregados = dias,
				nuevaFecha
			});
		}
	}
}