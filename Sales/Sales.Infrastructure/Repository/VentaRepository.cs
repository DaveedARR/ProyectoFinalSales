using Microsoft.EntityFrameworkCore;
using Sales.Application.Contracts.Repositories;
using Sales.Application.Models;
using Sales.Domain.Entities;
using Sales.Infrastructure.Context;
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

        public VentaRepository(ApplicationDbContext context)
        {
            _context = context;
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

            result.FechaVenta = modificarVentaDto.FechaVenta;
            result.TotalVenta = modificarVentaDto.TotalVenta;
            result.EstadoVenta = modificarVentaDto.EstadoVenta;

            _context.Ventas.Update(result);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
