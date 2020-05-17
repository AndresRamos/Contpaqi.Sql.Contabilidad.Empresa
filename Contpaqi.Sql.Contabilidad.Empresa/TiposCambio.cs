using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    [Table("TiposCambio")]
    public class TiposCambio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int Moneda { get; set; }

        public DateTime Fecha { get; set; }

        public double? TipoCambio { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public int Tipo { get; set; }
    }
}