using Sales.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Contracts.Services
{
    public interface IFacturaService
    {
        Task<bool> EmitirFactura(EmitirFacturaDto emitirFacturaDto);
    }
}
