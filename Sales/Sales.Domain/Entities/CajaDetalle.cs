using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales.Domain.Entities
{
    public class CajaDetalle
    {
        [Key]
        public int IdCajaDetalle { get; set; }
        [Required]
        public string DetalleMovimiento { get; set; } = string.Empty;
        [Required]
        public decimal? CantidadIngreso { get; set; }
        [Required]
        public decimal? CantidadGasto { get; set; }
        [Required]
        public string TipoPago { get; set; } = string.Empty;
        [Required]
        public DateTime FechaMovimiento { get; set; }
        public int IdCaja { get; set; }

        [ForeignKey("IdCaja")]
        public Caja? Caja { get; set; }
    }
}
