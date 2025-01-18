using Microsoft.EntityFrameworkCore;
using Sales.Application.Contracts.Repositories;
using Sales.Application.Models;
using Sales.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Infrastructure.Repository
{
 public class ReporteRepository: IReporteRepository
 {
  private ApplicationDbContext _context;

  public ReporteRepository(ApplicationDbContext context)
  {
   _context = context;
  }

  public async Task<List<VentasPorDiaReporteDto>> VentasPorDiaReporte(DateTime fecha_dia)
  {
   var result = await _context.Ventas
       .Where(v => v.FechaVenta.Date == fecha_dia.Date)
       .Select(v => new VentasPorDiaReporteDto
       {
        Fecha = v.FechaVenta,
        TotalVentas = v.TotalVenta,
        EstadoVenta = v.EstadoVenta
       })
       .ToListAsync();

   if (!result.Any())
   {
    throw new Exception($"No se encontraron ventas para la fecha: {fecha_dia:yyyy-MM-dd}");
   }
   return result;
  }

  public async Task<List<VentasPorRangoReporteDto>> VentasPorRangoReporte(DateTime fecha_inicial, DateTime fecha_final)
  {
   var result = await _context.Ventas
       .Where(v => v.FechaVenta.Date >= fecha_inicial.Date && v.FechaVenta.Date <= fecha_final.Date)
       .GroupBy(v => v.FechaVenta.Date)
       .Select(g => new VentasPorRangoReporteDto
       {
        Fecha = g.Key,
        TotalVentas = g.Sum(v => v.TotalVenta),
        NumeroDeVentas = g.Count()
       })
       .ToListAsync();
   if (!result.Any())
   {
    throw new Exception($"No se encontraron ventas dentro del rango de fecha incial: {fecha_inicial:yyyy-MM-dd} y fecha final: {fecha_final:yyyy-MM-dd}");
   }
   return result;
  }
 }
}
