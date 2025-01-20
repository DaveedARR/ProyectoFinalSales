using Sales.Application.Models;

namespace Sales.Application.Contracts.Services
{
    public interface IVentaService
    {
        Task<bool> RegistrarVenta(RegistrarVentaDto ventaDto);
        Task<bool> CancelarVenta(int idVenta);
        Task<bool> ModificarVenta(ModificarVentaDto modificarVentaDto);
    }
}
