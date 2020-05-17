using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    [Table("TiposOperacion")]
    public class TiposOperacion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(30)]
        public string SegContTipoOperacion1 { get; set; }

        [StringLength(30)]
        public string SegContTipoOperacion2 { get; set; }

        [StringLength(30)]
        public string SegContTipoOperacion3 { get; set; }

        [StringLength(30)]
        public string SegContTipoOperacion4 { get; set; }

        [StringLength(30)]
        public string SegContTipoOperacion5 { get; set; }

        [StringLength(30)]
        public string SegContTipoOperacion6 { get; set; }

        [StringLength(30)]
        public string SegContTipoOperacion7 { get; set; }
    }
}