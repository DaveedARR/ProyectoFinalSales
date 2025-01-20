using Sales.Application.Models;

namespace Sales.Application.Contracts.Repositories
{
    public interface IReporteRepository
    {
        Task<List<VentasPorDiaReporteDto>> VentasPorDiaReporte(DateTime fecha_dia);
        Task<List<VentasPorRangoReporteDto>> VentasPorRangoReporte(DateTime fecha_inicial, DateTime fecha_final);
    }
}
