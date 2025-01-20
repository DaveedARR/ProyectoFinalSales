using System.ComponentModel.DataAnnotations;

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
