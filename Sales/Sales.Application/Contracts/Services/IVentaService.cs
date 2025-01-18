using Sales.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Contracts.Services
{
    public interface IVentaService
    {
        Task<bool> RegistrarVenta(RegistrarVentaDto ventaDto);
        Task<bool> CancelarVenta(int idVenta);
        Task<bool> ModificarVenta(ModificarVentaDto modificarVentaDto);
    }
}
