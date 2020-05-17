using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    public class CodigoProductos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(1000)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public string RFC { get; set; }

        [Required]
        [StringLength(100)]
        public string NoIdentificacion { get; set; }

        public int? IdTipoOperacion { get; set; }

        [StringLength(30)]
        public string SegContCodigoProducto1 { get; set; }

        [StringLength(30)]
        public string SegContCodigoProducto2 { get; set; }

        [StringLength(30)]
        public string SegContCodigoProducto3 { get; set; }

        [StringLength(30)]
        public string SegContCodigoProducto4 { get; set; }

        [StringLength(30)]
        public string SegContCodigoProducto5 { get; set; }

        [StringLength(30)]
        public string SegContCodigoProducto6 { get; set; }

        [StringLength(30)]
        public string SegContCodigoProducto7 { get; set; }

        public int? SistOrig { get; set; }
    }
}