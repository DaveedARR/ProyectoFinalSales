using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sales.Application.Contracts.Services;
using Sales.Application.Models;

namespace Sales.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IVentaService _ventaService;

        public VentaController(IVentaService ventaService)
        {
            _ventaService = ventaService;
        }

        [HttpPost("RegistrarVenta")]
        public async Task<ActionResult> RegistrarVenta([FromForm] RegistrarVentaDto ventaDto)
        {
            var result = await _ventaService.RegistrarVenta(ventaDto);
            return result ? Ok("Venta registrada exitosamente") : BadRequest("No se pudo registrar la venta");
        }

        [HttpPost("CancelarVenta")]
        public async Task<ActionResult> CancelarVenta([FromForm] int idVenta)
        {
            var result = await _ventaService.CancelarVenta(idVenta);
            return result ? Ok("Venta cancelada exitosamente") : BadRequest("No se pudo cancelar la venta");
        }

        [HttpPut("ModificarVenta")]
        public async Task<ActionResult> ModificarVenta([FromForm] ModificarVentaDto modificarVentaDto)
        {
            var result = await _ventaService.ModificarVenta(modificarVentaDto);
            return result ? Ok("Venta modificada exitosamente") : BadRequest("No se pudo modificar la venta");
        }
    }
}
