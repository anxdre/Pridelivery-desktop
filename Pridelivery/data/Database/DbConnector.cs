using System;
using MySqlConnector;

namespace Pridelivery.Repository
{
    public class DbConnector
    {
        private string username;
        private string password;
        private string database;
        private MySqlSslMode sslMode;
        private UInt16 port;
        private string server;
        private MySqlConnection sqlConnection;

        //singleton instance
        private static readonly Lazy<DbConnector> instance = new Lazy<DbConnector>(() => new DbConnector());

        private DbConnector()
        {
            this.username = "anxdre";
            this.password = "the port gt3";
            this.database = "pridelivery";
            this.sslMode = MySqlSslMode.Required;
            this.port = 3306;
            this.server = "localhost";
        }

        public static DbConnector Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public MySqlConnection openConnectionAsync()
        {
            if (sqlConnection == null)
            {
                var builder = new MySqlConnectionStringBuilder
                {
                    Server = this.server,
                    UserID = this.username,
                    Password = this.password,
                    Database = this.database,
                    Port = this.port,
                    SslMode = this.sslMode
                };
                var connection = new MySqlConnection(builder.ConnectionString);
                sqlConnection = connection;
                connection.OpenAsync();
            }
            else if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.OpenAsync();
            }

            return sqlConnection;
        }
    }
}
