using System.Threading.Tasks;
using MySqlConnector;

namespace Pridelivery.Repository.Database
{
    public abstract class DbFactory
    {
        private static DbConnector connection = DbConnector.Instance;

        public static async Task<MySqlDataReader> runQueryCommand(string sql)
        {
            var query = new MySqlCommand(sql, connection.openConnectionAsync());
            var data = await query.ExecuteReaderAsync();
            return data;
        }

        public static async Task<int> runNonQueryCommand(string sql)
        {
            var query = new MySqlCommand(sql, connection.openConnectionAsync());
            var data = await query.ExecuteNonQueryAsync();
            return data;
        }
    }
}
