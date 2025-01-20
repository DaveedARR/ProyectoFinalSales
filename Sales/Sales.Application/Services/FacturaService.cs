using Sales.Application.Contracts.Repositories;
using Sales.Application.Contracts.Services;
using Sales.Application.Models;

namespace Sales.Application.Services
{
    public class FacturaService : IFacturaService
    {
        private readonly IFacturaRepository _repository;

        public FacturaService(IFacturaRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> EmitirFactura(EmitirFacturaDto emitirFacturaDto)
        {
            return await _repository.EmitirFactura(emitirFacturaDto);
        }

        public async Task<bool> AnularFactura(int idFactura)
        {
            return await _repository.AnularFactura(idFactura);
        }
    }
}
