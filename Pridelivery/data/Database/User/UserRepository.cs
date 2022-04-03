using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySqlConnector;
using Pridelivery.Repository.Model;

namespace Pridelivery.Repository.Database.User
{
    public abstract class UserRepository
    {
        public static async Task<MySqlDataReader> getAuthentication(string email, string password, MySqlConnection connection)
        {
            var query = $"select * from user where email = '{email}' and password = SHA2('{password}', 512);";
            try
            {
                return await DbFactory.runQueryCommand(query, connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<MySqlDataReader> getProfileDetail(int id, MySqlConnection connection)
        {
            var query = $"select * from user where id = '{id}'";
            try
            {
                return await DbFactory.runQueryCommand(query, connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<bool> registerUser(UserProfile data, MySqlConnection connection)
        {
            var query = $"insert into user values( null ,'{data.Name}','{data.Email}','{data.Phone}',SHA2(\"{data.Password}\", 512), '{data.Role}', now());";
            return await DbFactory.runNonQueryCommand(query, connection);
        }

        public static async Task<bool> updateUser(UserProfile data, MySqlConnection connection)
        {
            var query = $"update user SET name = '{data.Name}', email = '{data.Email}', phonenumber = '{data.Phone}', role = '{data.Role}';";
            return await DbFactory.runNonQueryCommand(query, connection);
        }
    }
}
