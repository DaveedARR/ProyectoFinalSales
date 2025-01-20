using Sales.Application.Contracts.Repositories;
using Sales.Application.Contracts.Services;
using Sales.Domain.Entities;

namespace Sales.Application.Services
{
    public class CajaService : ICajaService
    {
        private ICajaRepository _cajaRepository;
        public CajaService(ICajaRepository cajaRepository)
        {
            _cajaRepository = cajaRepository;
        }
        public async Task<List<Caja>> ListarCaja_Service()
        {
            return await _cajaRepository.ListarCaja();
        }
        public async Task<bool> InsertarCaja_Service(Caja caja)
        {
            return await _cajaRepository.InsertarCaja(caja);
        }

        public async Task<bool> CierreCaja_Service(string changeestado)
        {
            return await _cajaRepository.CierreCaja(changeestado);
        }

        public async Task<bool> ModificarCaja_Service(DateTime fechaapertura, DateTime fechacierre, decimal montoinicial, decimal montofinal)
        {
            return await _cajaRepository.ModificarCaja(fechaapertura, fechacierre, montoinicial, montofinal);
        }

    }
}
