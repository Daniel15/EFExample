using System.Configuration;
using System.Data;
using System.Data.Entity;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;

namespace Daniel15.EFTest
{
    public class MyDbConfiguration : DbConfiguration
    {
		public MyDbConfiguration()
		{
			var dataSet = (DataSet)ConfigurationManager.GetSection("system.data");
			dataSet.Tables[0].Rows.Add(
				"MySQL Data Provider",
				".Net Framework Data Provider for MySQL",
				"MySql.Data.MySqlClient",
				typeof(MySqlClientFactory).AssemblyQualifiedName
			);

			SetProviderServices("MySql.Data.MySqlClient", new MySqlProviderServices());
			SetDefaultConnectionFactory(new MySqlConnectionFactory());
		}
	}
}
