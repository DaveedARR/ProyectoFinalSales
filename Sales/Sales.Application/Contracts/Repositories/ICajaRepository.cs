using Sales.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Contracts.Repositories
{
 public interface ICajaRepository
 {
  Task<List<Caja>> ListarCaja();
  Task <bool>InsertarCaja(Caja caja);
  Task<bool> CierreCaja(string changeestado);
  Task<bool> ModificarCaja(DateTime fechaapertura, DateTime fechacierre, decimal montoinicial, decimal montofinal);
 }
}
