using System.ComponentModel.DataAnnotations;

namespace Sales.Application.Models
{
    public class EmitirFacturaDto
    {
        public int NumeroFactura { get; set; }
        public int IdVenta { get; set; }
    }
}
