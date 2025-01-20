using Sales.Domain.Entities;

namespace Sales.Application.Contracts.Services
{
    public interface ICajaService
    {
        Task<List<Caja>> ListarCaja_Service();
        Task<bool> InsertarCaja_Service(Caja caja);
        Task<bool> CierreCaja_Service(string changeestado);
        Task<bool> ModificarCaja_Service(DateTime fechaapertura, DateTime fechacierre, decimal montoinicial, decimal montofinal);
    }
}
