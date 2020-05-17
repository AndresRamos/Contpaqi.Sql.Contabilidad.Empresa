using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    [Table("MovimientosAsiento")]
    public class MovimientosAsiento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int NumeroMovto { get; set; }

        public int IdAsiento { get; set; }

        public int? IdConceptoCta { get; set; }

        public int? IdCuenta { get; set; }

        public int? TipoMovto { get; set; }

        public int? ImporteBase { get; set; }

        public int? Referencia { get; set; }

        [StringLength(30)]
        public string TextoReferencia { get; set; }

        public int? Concepto { get; set; }

        [StringLength(100)]
        public string TextoConcepto { get; set; }

        [StringLength(50)]
        public string IdSegmentoNegocio { get; set; }

        public bool? ConcentrarMovimientos { get; set; }

        [StringLength(100)]
        public string FormulaCuenta { get; set; }

        [StringLength(500)]
        public string FormulaImporte { get; set; }

        [StringLength(500)]
        public string FormulaImporteME { get; set; }

        [StringLength(50)]
        public string IdDiario { get; set; }

        public int? OpcionSegmento { get; set; }
    }
}