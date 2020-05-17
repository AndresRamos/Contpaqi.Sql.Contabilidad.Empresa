using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    public class Conceptos
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

        [StringLength(20)]
        public string TimeStamp { get; set; }

        public int? SistOrig { get; set; }
    }
}