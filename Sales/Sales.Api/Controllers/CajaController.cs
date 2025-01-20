using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sales.Application.Contracts.Services;
using Sales.Application.Models;
using Sales.Application.Services;
using Sales.Domain.Entities;

namespace Sales.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CajaController : ControllerBase
    {
        private readonly ICajaService _service;

        public CajaController(ICajaService service)
        {
            _service = service;
        }
        [HttpGet("ListarCaja")]
        public async Task<ActionResult<List<Caja>>> Listar()
        {
            try
            {
                return await _service.ListarCaja_Service();

            }
            catch
            {
                return BadRequest("Error el registro de caja no existe");
            }
        }
        [HttpPost("AperturaCaja")]
        public async Task<ActionResult> Insertar([FromForm] AperturarCajaDto aperturarCajaDto)
        {
            try
            {
                await _service.InsertarCaja_Service(aperturarCajaDto);
                return Ok("Caja Registrada Exitosamente");
            }
            catch
            {
                return BadRequest("Error al momento de registrar");
            }

        }
        [HttpPut("ModificarCaja")]
        public async Task<ActionResult> Modificar([FromForm] ModificarCajaDto modificarCajaDto)
        {
            var result = await _service.ModificarCaja_Service(modificarCajaDto);
            return result ? Ok("Caja modificada exitosamente") : BadRequest("No se pudo modificar la caja");
        }
        [HttpPost("CierreCaja")]
        public async Task<ActionResult> Cierre(string changeestado)
        {
            try
            {
                await _service.CierreCaja_Service(changeestado);
                return Ok("Cambiado Exitosamente");
            }
            catch
            {
                return BadRequest("Error al momento de Cambiar");
            }
        }
    }
}
