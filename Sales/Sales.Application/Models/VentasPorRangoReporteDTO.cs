using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Models
{
    public class VentasPorRangoReporteDTO
    {
        public DateTime Fecha { get; set; }
        public decimal TotalVentas { get; set; }
        public int NumeroDeVentas { get; set; }
    }
}
