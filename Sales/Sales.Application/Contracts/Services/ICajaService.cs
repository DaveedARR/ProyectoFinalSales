using Sales.Application.Models;
using Sales.Domain.Entities;

namespace Sales.Application.Contracts.Services
{
    public interface ICajaService
    {
        Task<List<Caja>> ListarCaja_Service();
        Task<bool> InsertarCaja_Service(AperturarCajaDto aperturarCajaDto);
        Task<bool> CierreCaja_Service(string changeestado);
        Task<bool> ModificarCaja_Service(ModificarCajaDto modificarCajaDto);
    }
}
