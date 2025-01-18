using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Entities
{
    public class Factura
    {
        [Key]
        public int IDFactura { get; set; }
        [Required]
        public DateTime FechaEmision { get; set; }
        [Required]
        public int NumeroFactura { get; set; }
        [Required]
        public string EstadoFactura { get; set; } = string.Empty;
        [Required]
        public int IdVenta { get; set; }
        [ForeignKey("IdVenta")]
        public Venta? Venta { get; set; }
    }
}