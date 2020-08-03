using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    public class DispersionesPagos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(36)]
        public string UUID { get; set; }

        [Required]
        [StringLength(36)]
        public string UUIDRep { get; set; }

        [Required]
        [StringLength(36)]
        public string GuidRef { get; set; }

        public int NumNodoPago { get; set; }

        public DateTime FechaPago { get; set; }

        public double TotalPago { get; set; }

        public double TipoCambio { get; set; }

        public double TotalPagoComprobante { get; set; }
    }
}