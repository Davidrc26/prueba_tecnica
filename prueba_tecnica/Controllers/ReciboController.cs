using Aplicacion.CasosUso;
using Microsoft.AspNetCore.Mvc;

namespace prueba_tecnica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReciboController
    {
        private readonly ICrearReciboMateriaPrima _crearReciboMateriaPrima;

        public ReciboController(ICrearReciboMateriaPrima crearReciboMateriaPrima)
        {
            _crearReciboMateriaPrima = crearReciboMateriaPrima;
        }

        [HttpPost]
        public async Task<IActionResult> CrearReciboMateriaPrima([FromBody] Aplicacion.dtos.ReciboDto request)
        {
            var result = await _crearReciboMateriaPrima.CrearReciboMateriaPrima(request);
            return new OkObjectResult(result);
        }
    }
}
