using Sales.Application.Models;
using Sales.Domain.Entities;

namespace Sales.Application.Contracts.Repositories
{
    public interface IVentaRepository
    {
        Task<bool> RegistrarVenta(Venta venta);
        Task<bool> CancelarVenta(int idVenta);
        Task<bool> ModificarVenta(ModificarVentaDto modificarVentaDto);
    }
}
