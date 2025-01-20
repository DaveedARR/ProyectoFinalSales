using Sales.Application.Contracts.Repositories;
using Sales.Application.Contracts.Services;
using Sales.Application.Models;
using Sales.Domain.Entities;
using Sales.Infrastructure.Gateway.Payment;

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

            try
            {
                var venta = new Venta
                {
                    FechaVenta = ventaDto.FechaVenta,
                    TotalVenta = ventaDto.TotalVenta,
                    EstadoVenta = ventaDto.EstadoVenta
                };
                await _repository.RegistrarVenta(venta);
                
                
                PagoDto pago = new PagoDto
                {
                    DescripcionPago = "asdas ",
                    FechaPago = DateTime.UtcNow,
                    IdEstadoPago = 1,
                    IdTipoPago = 1,
                    IdUsuario = 1,
                    
                    IdVenta =1,
                    Monto = (int)venta.TotalVenta,
                    ReferenciaPago = "referencia"

                };

                await _repository.RegistrarPago(pago);


                return true;
            }
            catch (Exception)
            {
                return false;
              
            }
          

             
            return false ;
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
