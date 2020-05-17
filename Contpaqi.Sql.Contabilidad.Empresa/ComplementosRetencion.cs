using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    [Table("ComplementosRetencion")]
    public class ComplementosRetencion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        [Required]
        [StringLength(2)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string Version { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string XMLComplemento { get; set; }

        public bool? EsActivo { get; set; }
    }
}