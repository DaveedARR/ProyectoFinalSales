using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sales.Application.Contracts.Services;
using Sales.Application.Models;

namespace Sales.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReporteController : ControllerBase
    {
        private readonly IReporteService _repository;

        public ReporteController(IReporteService repository)
        {
            _repository = repository;
        }
        [HttpGet("VentaPorDiaReporte")]
        public async Task<ActionResult<List<VentasPorDiaReporteDto>>> VentaPorDiaReporte(DateTime fecha_dia)
        {
            try
            {
                var result = await _repository.VentasPorDiaReporte_Service(fecha_dia);
                return Ok(result);
            }
            catch
            {
                return BadRequest("No se encontro ningun reporte");
            }

        }
        [HttpGet("VentaPorRangoDeporte")]
        public async Task<ActionResult<List<VentasPorRangoReporteDto>>> VentaPorRangoReporte(DateTime fecha_inicial, DateTime fecha_final)
        {
            try
            {
                var result = await _repository.VentasPorRangoReporte_Service(fecha_inicial, fecha_final);
                return Ok(result);
            }
            catch
            {
                return BadRequest("No se encontro ningun reporte");
            }

        }
    }
}
