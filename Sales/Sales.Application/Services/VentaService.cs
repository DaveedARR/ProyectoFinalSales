using Sales.Application.Contracts.Repositories;
using Sales.Application.Contracts.Services;
using Sales.Application.Models;
using Sales.Domain.Entities;

namespace Sales.Application.Services
{
    public class VentaService : IVentaService
    {
        private readonly IVentaRepository _repository;

        public VentaService(IVentaRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> RegistrarVenta(RegistrarVentaDto ventaDto)
        {
            var venta = new Venta
            {
                FechaVenta = ventaDto.FechaVenta,
                TotalVenta = ventaDto.TotalVenta,
                EstadoVenta = ventaDto.EstadoVenta
            };
            return await _repository.RegistrarVenta(venta);
        }

        public async Task<bool> CancelarVenta(int idVenta)
        {
            return await _repository.CancelarVenta(idVenta);
        }

        public async Task<bool> ModificarVenta(ModificarVentaDto modificarVentaDto)
        {
            return await _repository.ModificarVenta(modificarVentaDto);
        }
    }
}
