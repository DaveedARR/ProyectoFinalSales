using Sales.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Contracts.Repositories
{
    public interface IFacturaRepository
    {
        Task<bool> EmitirFactura(EmitirFacturaDto emitirFacturaDto);
    }
}
