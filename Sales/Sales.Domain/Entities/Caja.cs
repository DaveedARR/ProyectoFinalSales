using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Entities
{
    public class Caja
    {
        [Key]
        public int IDCaja { get; set; }
        [Required]
        public DateTime FechaApertura { get; set; }
        public DateTime? FechaCierre { get; set; }
        [Required]
        public decimal MontoInicial { get; set; }
        public decimal? MontoFinal { get; set; }
        [Required]
        public string EstadoCaja { get; set; } = string.Empty;
        public ICollection<CajaDetalle>? CajaDetalles { get; set; }
    }
}
