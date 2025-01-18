using Sales.Application.Models;
using Sales.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Contracts.Repositories
{
    public interface IVentaRepository
    {
        Task<bool> RegistrarVenta(Venta venta);
        Task<bool> CancelarVenta(int idVenta);
        Task<bool> ModificarVenta(ModificarVentaDto modificarVentaDto);
    }
}
