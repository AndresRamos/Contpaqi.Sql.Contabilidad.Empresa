using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    public class CuentasDeGastosYRetenciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(30)]
        public string NombreImpuesto { get; set; }

        public int IdCuentaContable { get; set; }

        public bool? AsignarAlNeto { get; set; }
    }
}