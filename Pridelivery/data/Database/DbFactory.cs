using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pridelivery.Repository.Database
{
    public abstract class DbFactory
    {

        public static async Task<MySqlDataReader> runQueryCommand(string sql, MySqlConnection connection)
        {
            var query = connection.CreateCommand();
            query.CommandText = sql;
            var reader = await query.ExecuteReaderAsync();
            if (!reader.HasRows)
            {
                throw new NullReferenceException("data not found");
            }
            return reader;
        }

        public static async Task<bool> runNonQueryCommand(string sql, MySqlConnection connection)
        {
            var query = connection.CreateCommand();
            var transacion = await Task.Run(() => connection.BeginTransaction());
            query.Connection = connection;
            query.Transaction = transacion;
            try
            {
                query.CommandText = sql;
                await query.ExecuteNonQueryAsync();
                await Task.Run(() => transacion.Commit());
                return true;
            }
            catch (Exception ex)
            {
                transacion.Rollback();
                throw ex;
            }
        }
        public static async Task<bool> runNonQueryCommand(List<String> sql, MySqlConnection connection)
        {
            var query = connection.CreateCommand();
            var transacion = await Task.Run(() => connection.BeginTransaction());
            query.Connection = connection;
            query.Transaction = transacion;
            try
            {
                foreach(var queryItem in sql)
                {
                    query.CommandText = queryItem;
                    await query.ExecuteNonQueryAsync();
                }         
                await Task.Run(() => transacion.Commit());
                return true;
            }
            catch (Exception ex)
            {
                transacion.Rollback();
                throw ex;
            }
        }
    }
}
