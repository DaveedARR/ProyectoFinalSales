using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Application.Models
{
    public class EmitirFacturaDto
    {
        [Required]
        public int NumeroFactura { get; set; }
        [Required]
        public int IdVenta { get; set; }
    }
}
