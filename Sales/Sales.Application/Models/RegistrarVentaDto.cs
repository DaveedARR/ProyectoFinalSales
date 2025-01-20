using System.ComponentModel.DataAnnotations;

namespace Sales.Application.Models
{
    public class RegistrarVentaDto
    {
        public DateTime FechaVenta { get; set; }
        public string EstadoVenta { get; set; } = string.Empty;
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal TotalVenta { get; set; }
    }
}