using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    [Table("RubrosNIF")]
    public class RubrosNIF
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(20)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        public int? Nivel { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }

        [StringLength(200)]
        public string NombreIdioma { get; set; }

        [StringLength(100)]
        public string DescripcionNivel { get; set; }

        [StringLength(100)]
        public string DescripcionNivelIdioma { get; set; }
    }
}