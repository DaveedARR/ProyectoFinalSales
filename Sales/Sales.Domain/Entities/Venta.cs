using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Entities
{
    public class Venta
    {
        [Key]
        public int IDVenta { get; set; }
        [Required]
        public DateTime FechaVenta { get; set; }
        [Required]
        public decimal TotalVenta { get; set; }
        [Required]
        [MaxLength(20)]
        public string EstadoVenta { get; set; } = string.Empty;
    }
}
