using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Infrastructure.Gateway.Payment
{
    public class PagoDto
    {
        public int Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string? ReferenciaPago { get; set; }
        public string? DescripcionPago { get; set; }
        public int IdTipoPago { get; set; }
        public int IdUsuario { get; set; }
        public int IdEstadoPago { get; set; }
        public int IdVenta { get; set; }
    }
}
