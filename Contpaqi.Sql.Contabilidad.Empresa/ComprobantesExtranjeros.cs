using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    public class ComprobantesExtranjeros
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(36)]
        public string NumeroDeFactura { get; set; }

        [StringLength(30)]
        public string TaxID { get; set; }

        public double MontoTotal { get; set; }

        public int? IdMoneda { get; set; }

        public double? TipoCambio { get; set; }

        [StringLength(2)]
        public string MetodoDePago { get; set; }

        public int? IdProveedor { get; set; }

        [StringLength(36)]
        public string Guid { get; set; }
    }
}