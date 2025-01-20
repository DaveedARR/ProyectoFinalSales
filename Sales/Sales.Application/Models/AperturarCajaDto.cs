using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Models
{
    public class AperturarCajaDto
    {
        public DateTime FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }
        public decimal MontoInicial { get; set; }
        public string EstadoCaja { get; set; } = string.Empty;
    }
}
