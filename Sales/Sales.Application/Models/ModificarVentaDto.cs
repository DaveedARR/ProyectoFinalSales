using System.ComponentModel.DataAnnotations;

namespace Sales.Application.Models
{
    public class ModificarVentaDto
    {
        [Key]
        public int IDVenta { get; set; }
        [Required]
        public DateTime FechaVenta { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El total de la venta debe ser mayor a 0")]
        public decimal TotalVenta { get; set; }
        [Required]
        [MaxLength(20)]
        public string EstadoVenta { get; set; } = string.Empty;
    }
}
