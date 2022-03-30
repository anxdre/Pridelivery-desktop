using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pridelivery.Repository.Database
{
    public abstract class DbFactory
    {

        public static async Task<MySqlDataReader> runQueryCommand(string sql,MySqlConnection connection)
        {
            var query = connection.CreateCommand();
            query.CommandText = sql;
            try
            {
                var reader = await query.ExecuteReaderAsync();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<int> runNonQueryCommand(string sql, MySqlConnection connection)
        {
            var query = new MySqlCommand(sql, connection);
            var data = await query.ExecuteNonQueryAsync();
            return data;
        }

        //public static async runNonQueryCommand(string sql, MySqlConnection connection)
        //{
        //    await connection.OpenAsync();
        //    var query = connection.CreateCommand();
        //    var transacion = await Task.Run(() => connection.BeginTransaction());
        //    query.Connection = connection;
        //    query.Transaction = transacion;
        //    try
        //    {
        //        query.CommandText = sql;
        //        await query.ExecuteNonQueryAsync();
        //        await Task.Run(() => transacion.Commit());

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }
}
