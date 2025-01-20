using Sales.Application.Contracts.Repositories;
using Sales.Application.Contracts.Services;
using Sales.Application.Models;
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
        public async Task<bool> InsertarCaja_Service(AperturarCajaDto aperturarCajaDto)
        {
            //return await _cajaRepository.InsertarCaja(aperturarCajaDto);
            var caja = new Caja
            {
                FechaApertura = aperturarCajaDto.FechaApertura,
                FechaCierre = aperturarCajaDto.FechaCierre,
                MontoInicial = aperturarCajaDto.MontoInicial,
                EstadoCaja = aperturarCajaDto.EstadoCaja
            };
            return await _cajaRepository.InsertarCaja(caja);
        }

        public async Task<bool> CierreCaja_Service(string changeestado)
        {
            return await _cajaRepository.CierreCaja(changeestado);
        }

        public async Task<bool> ModificarCaja_Service(ModificarCajaDto modificarCajaDto)
        {
            return await _cajaRepository.ModificarCaja(modificarCajaDto);
        }

    }
}
