using Microsoft.AspNetCore.Mvc;
using Sales.Application.Contracts.Services;
using Sales.Domain.Entities;

namespace Sales.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CajaController : ControllerBase
    {
        private readonly ICajaService _repository;

        public CajaController(ICajaService repository)
        {
            _repository = repository;
        }
        [HttpGet("ListarCaja")]
        public async Task<ActionResult<List<Caja>>> Listar()
        {
            try
            {
                return await _repository.ListarCaja_Service();

            }
            catch
            {
                return BadRequest("Error el registro de caja no existe");
            }
        }
        [HttpPost("AperturaCaja")]
        public async Task<ActionResult> Insertar(Caja caja)
        {
            try
            {
                await _repository.InsertarCaja_Service(caja);
                return Ok("Caja Registrada Exitosamente");
            }
            catch
            {
                return BadRequest("Error al momento de registrar");
            }

        }
        [HttpPut("ModificarCaja")]
        public async Task<ActionResult> Modificar(DateTime fechaapertura, DateTime fechacierre, decimal montoinicial, decimal montofinal)
        {
            var respuesta = await _repository.ModificarCaja_Service(fechaapertura, fechacierre, montoinicial, montofinal);
            if (respuesta) { return Ok("Modificado Exitosamente"); }
            else { return BadRequest("Error al momento de modificar"); }
        }
        [HttpPost("CierreCaja")]
        public async Task<ActionResult> Cierre(string changeestado)
        {
            try
            {
                await _repository.CierreCaja_Service(changeestado);
                return Ok("Cambiado Exitosamente");
            }
            catch
            {
                return BadRequest("Error al momento de Cambiar");
            }
        }
    }
}
