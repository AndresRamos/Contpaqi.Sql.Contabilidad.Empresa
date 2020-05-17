using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contpaqi.Sql.Contabilidad.Empresa
{
    public class AsignacionesDigitos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? RowVersion { get; set; }

        public int IdCuenta { get; set; }

        public int? IdDigito1 { get; set; }

        public int? IdDigito2 { get; set; }

        [StringLength(20)]
        public string TimeStamp { get; set; }
    }
}