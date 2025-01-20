using Microsoft.EntityFrameworkCore;
using Sales.Application.Contracts.Repositories;
using Sales.Application.Models;
using Sales.Domain.Entities;
using Sales.Infrastructure.Context;
using Sales.Infrastructure.Gateway.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Infrastructure.Repository
{
    public class VentaRepository : IVentaRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly PaymentService _paymentService;

        public VentaRepository(ApplicationDbContext context, PaymentService paymentService)
        {
            _context = context;
            _paymentService = paymentService;
        }


        public async Task<bool> RegistrarPago(PagoDto pago)
        {
            try
            {
                await _paymentService.RegisterPaymentAsync(pago);
                return true;
            }
            catch
            {
                return false;
            }
        }



        public async Task<bool> RegistrarVenta(Venta venta)
        {
            try
            {
                await _context.Ventas.AddAsync(venta);
                await _context.SaveChangesAsync();

                

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> CancelarVenta(int idVenta)
        {
            var result = await _context.Ventas.FindAsync(idVenta);
            if (result == null || result.EstadoVenta == "Cancelada") return false;

            result.EstadoVenta = "Cancelada";
            _context.Ventas.Update(result);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ModificarVenta(ModificarVentaDto modificarVentaDto)
        {
            var result = await _context.Ventas.FindAsync(modificarVentaDto!.IDVenta);
            if (result == null) return false;

            result.EstadoVenta = modificarVentaDto.EstadoVenta;
            result.IdProducto = modificarVentaDto.IdProducto;
            result.Cantidad = modificarVentaDto.Cantidad;
            result.TotalVenta = modificarVentaDto.TotalVenta;

            _context.Ventas.Update(result);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
