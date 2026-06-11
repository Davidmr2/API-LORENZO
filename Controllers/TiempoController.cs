using Microsoft.AspNetCore.Mvc;

namespace PracticaAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class TiempoController : ControllerBase
	{
		[HttpGet("formatear")]
		public IActionResult Formatear(int segundos)
		{
			int horas = segundos / 3600;
			int minutos = (segundos % 3600) / 60;
			int seg = segundos % 60;

			string formato =
				$"{horas:D2}:{minutos:D2}:{seg:D2}";

			return Ok(new
			{
				horas,
				minutos,
				segundos = seg,
				formato
			});
		}
	}
}