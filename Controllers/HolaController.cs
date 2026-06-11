using Microsoft.AspNetCore.Mvc;

namespace PracticaAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class HolaController : ControllerBase
	{
		[HttpGet("saludo")]
		public IActionResult Saludo(string nombre)
		{
			return Ok(new
			{
				mensaje = $"Bienvenido {nombre}"
			});
		}
	}
}