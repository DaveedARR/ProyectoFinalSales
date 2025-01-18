using Microsoft.EntityFrameworkCore;
using Sales.Application.Contracts.Repositories;
using Sales.Domain.Entities;
using Sales.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Infrastructure.Repository
{
 public class CajaRepository: ICajaRepository
 {
  private ApplicationDbContext _context;

  public CajaRepository(ApplicationDbContext context)
  {
   _context = context;
  }
  public async Task<List<Caja>> ListarCaja()
  {
   return await _context.Cajas.ToListAsync();
  }
  public async Task<bool> InsertarCaja(Caja caja)
  {
   try
   {
    await _context.Cajas.AddAsync(caja);
    await _context.SaveChangesAsync();
    return true;
   }
   catch 
   {
    return false;
   }
  }

  public async Task<bool> ModificarCaja(DateTime fechaapertura, DateTime fechacierre, decimal montoinicial, decimal montofinal)
  {
   var caja = await _context.Cajas.FirstOrDefaultAsync();

   if (caja == null)
   {
    throw new Exception("No se encontró ningún registro en la tabla Cajas.");
   }

   caja.FechaApertura = fechaapertura;
   caja.FechaCierre = fechacierre;
   caja.MontoInicial = montoinicial;
   caja.MontoFinal = montofinal;

   await _context.SaveChangesAsync();

   return true;

  }
  public async Task<bool> CierreCaja(string changeestado)
  {
   var caja = await _context.Cajas.FirstOrDefaultAsync();

   if (caja == null)
   {
    throw new Exception("No se encontró ningún registro en la tabla Cajas.");
   }

   caja.EstadoCaja = changeestado;

   await _context.SaveChangesAsync();

   return true;

  }
 }
}
