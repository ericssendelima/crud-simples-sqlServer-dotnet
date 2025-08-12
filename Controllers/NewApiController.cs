using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class NewApiController : ControllerBase
  {
    [HttpGet("ObterDataHoraAtual")]
    public IActionResult ObterDataHora()
    {
      var obj = new
      {
        Data = DateTime.Now.ToLongDateString(),
        Hora = DateTime.Now.ToLongTimeString()
      };

      return Ok(obj);
    }

    [HttpGet("Apresentar/{nome}")]
    public IActionResult Apresentar(string nome)
    {
      var msg = $"Olá {nome}, seja bem vindo!";
      return Ok(new { msg });
    }
  }
}
