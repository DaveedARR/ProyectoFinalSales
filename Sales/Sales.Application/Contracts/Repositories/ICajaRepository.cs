using Sales.Application.Models;
using Sales.Domain.Entities;

namespace Sales.Application.Contracts.Repositories
{
    public interface ICajaRepository
    {
        Task<List<Caja>> ListarCaja();
        Task<bool> InsertarCaja(Caja Caja);
        Task<bool> CierreCaja(string changeestado);
        Task<bool> ModificarCaja(ModificarCajaDto modificarCajaDto);
    }
}
