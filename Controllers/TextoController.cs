using Microsoft.AspNetCore.Mvc;

namespace PracticaAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class TextoController : ControllerBase
	{
		[HttpGet("contar")]
		public IActionResult Contar(string texto)
		{
			int palabras = texto.Split(' ',
				StringSplitOptions.RemoveEmptyEntries).Length;

			int caracteres = texto.Length;

			int vocales = texto.Count(c =>
				"aeiouAEIOUáéíóúÁÉÍÓÚ".Contains(c));

			return Ok(new
			{
				texto,
				palabras,
				caracteres,
				vocales
			});
		}

		[HttpGet("invertir")]
		public IActionResult Invertir(string texto)
		{
			char[] arreglo = texto.ToCharArray();

			Array.Reverse(arreglo);

			return Ok(new
			{
				original = texto,
				invertido = new string(arreglo)
			});
		}
	}
}