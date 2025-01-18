using Sales.Application.Contracts.Repositories;
using Sales.Application.Contracts.Services;
using Sales.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Services
{
 public class ReporteService: IReporteService
 {
  private IReporteRepository _reporteRepository;

  public ReporteService(IReporteRepository reporteRepository)
  {
   _reporteRepository = reporteRepository;
  }
  public async Task<List<VentasPorDiaReporteDto>> VentasPorDiaReporte_Service(DateTime fecha_dia)
  {
   return await _reporteRepository.VentasPorDiaReporte(fecha_dia);
  }

  public async Task<List<VentasPorRangoReporteDto>> VentasPorRangoReporte_Service(DateTime fecha_inicial, DateTime fecha_final)
  {
   return await _reporteRepository.VentasPorRangoReporte(fecha_inicial, fecha_final);
  }
 }
}
