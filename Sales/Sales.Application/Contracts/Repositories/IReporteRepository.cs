using Sales.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Contracts.Repositories
{
 public interface IReporteRepository
 {
  Task<List<VentasPorDiaReporteDto>> VentasPorDiaReporte(DateTime fecha_dia);
  Task<List<VentasPorRangoReporteDto>> VentasPorRangoReporte(DateTime fecha_inicial, DateTime fecha_final);
 }
}
