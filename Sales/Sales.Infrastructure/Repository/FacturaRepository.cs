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
    public class FacturaRepository : IFacturaRepository
    {
        private readonly ApplicationDbContext _context;

        public FacturaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> EmitirFactura(EmitirFacturaDto emitirFacturaDto)
        {
            var venta = await _context.Ventas.FindAsync(emitirFacturaDto.IdVenta);
            if (venta == null || venta.EstadoVenta != "Completada") return false;

            var factura = new Factura
            {
                FechaEmision = DateTime.UtcNow,
                NumeroFactura = emitirFacturaDto.NumeroFactura,
                EstadoFactura = "Emitida",
                IdVenta = emitirFacturaDto.IdVenta
            };

            _context.Facturas.Add(factura);
            await _context.SaveChangesAsync();
            return true;
        } 
    }
}
