namespace Sales.Application.Models
{
    public class VentasPorDiaReporteDto
    {
        public DateTime Fecha { get; set; }
        public decimal TotalVentas { get; set; }
        public string EstadoVenta { get; set; } = string.Empty;
    }
}
