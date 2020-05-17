using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    public class CuentasChequesAlias
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroCuenta { get; set; }

        public int TipoCuenta { get; set; }

        [StringLength(60)]
        public string Descripcion { get; set; }

        public int IdCuentaCheques { get; set; }
    }
}