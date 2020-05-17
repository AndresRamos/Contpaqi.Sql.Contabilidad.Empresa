using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    public class DocumentosAdministrativos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(36)]
        public string UUID { get; set; }

        [StringLength(30)]
        public string CodigoPersona { get; set; }

        [StringLength(20)]
        public string CodigoAsiento { get; set; }

        [StringLength(20)]
        public string CodigoTipoOperacion { get; set; }

        [StringLength(30)]
        public string CodigoResponsableGasto { get; set; }

        [StringLength(20)]
        public string CodigoSegmentoNegocio { get; set; }
    }
}