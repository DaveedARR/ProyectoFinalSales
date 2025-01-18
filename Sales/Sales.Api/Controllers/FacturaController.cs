using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sales.Application.Contracts.Services;
using Sales.Application.Models;

namespace Sales.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService _facturaService;

        public FacturaController(IFacturaService facturaService)
        {
            _facturaService = facturaService;
        }

        [HttpPost("EmitirFactura")]
        public async Task<ActionResult> EmitirFactura([FromForm] EmitirFacturaDto emitirFacturaDto)
        {
            var result = await _facturaService.EmitirFactura(emitirFacturaDto);
            return result ? Ok("Factura emitida exitosamente") : BadRequest("No se pudo emitir la factura");
        }
    }
}
