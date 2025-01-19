using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Models
{
    public class RegistrarVentaDto
    {
        public DateTime FechaVenta { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "El total de la venta debe ser mayor a 0")]
        public decimal TotalVenta { get; set; }
        public string EstadoVenta { get; set; } = string.Empty;
    }
}