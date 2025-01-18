using Sales.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Contracts.Services
{
 public interface IReporteService
 {
  Task<List<VentasPorDiaReporteDto>> VentasPorDiaReporte_Service(DateTime fecha_dia);
  Task<List<VentasPorRangoReporteDto>> VentasPorRangoReporte_Service(DateTime fecha_inicial, DateTime fecha_final);
 }
}
