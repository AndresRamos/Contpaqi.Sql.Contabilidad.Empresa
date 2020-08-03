using System;
using System.Data.SqlClient;

namespace Contpaqi.Sql.Contabilidad.Empresa.Factories
{
    public static class ContabilidadEmpresaDbContextFactory
    {
        public static ContabilidadEmpresaDbContext CreateInstance(string contpaqiConnectionString, string initialCatalog)
        {
            if (contpaqiConnectionString == null)
            {
                throw new ArgumentNullException(nameof(contpaqiConnectionString));
            }

            if (initialCatalog == null)
            {
                throw new ArgumentNullException(nameof(initialCatalog));
            }

            var connectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
            {
                InitialCatalog = initialCatalog
            };

            return new ContabilidadEmpresaDbContext(new SqlConnection(connectionStringBuilder.ToString()), true);
        }
    }
}