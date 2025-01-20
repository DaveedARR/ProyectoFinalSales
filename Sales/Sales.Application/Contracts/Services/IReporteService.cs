using Sales.Application.Models;

namespace Sales.Application.Contracts.Services
{
    public interface IReporteService
    {
        Task<List<VentasPorDiaReporteDto>> VentasPorDiaReporte_Service(DateTime fecha_dia);
        Task<List<VentasPorRangoReporteDto>> VentasPorRangoReporte_Service(DateTime fecha_inicial, DateTime fecha_final);
    }
}
