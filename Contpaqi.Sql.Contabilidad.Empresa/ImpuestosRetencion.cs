using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    [Table("ImpuestosRetencion")]
    public class ImpuestosRetencion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public int IdRetencion { get; set; }

        [StringLength(2)]
        public string Impuesto { get; set; }

        public double? BaseRet { get; set; }

        public double? MontoRet { get; set; }

        public int? TipoPagoRet { get; set; }

        [Required]
        [StringLength(36)]
        public string Guid { get; set; }
    }
}