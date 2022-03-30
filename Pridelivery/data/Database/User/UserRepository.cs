using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pridelivery.Repository.Model;

namespace Pridelivery.Repository.Database.User
{
    public abstract class UserRepository
    {
        public static async Task<UserProfile> getAuthentication(string email, string password)
        {
            var query = $"select * from user where email = '{email}' and password = SHA2('{password}', 512);";
            var connection = DbConnector.Instance.createConnection();

            List<object> result = new List<object>();          
            try
            {
                await connection.OpenAsync();
                var reader = await DbFactory.runQueryCommand(query, connection);
                while (await reader.ReadAsync())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        result.Add(await reader.GetFieldValueAsync<object>(i));
                    }
                }
                return new UserProfile((int)reader[0], (string)reader[1], (string)reader[3], (string)reader[4], (string)reader[5], (int)reader[6]);
            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                await connection.CloseAsync();
            }
        }

        public static async Task<int> registerUser(UserProfile data)
        {
            var query = $"insert into user values( null ,'{data.Name}','{data.Email}','{data.Phone}',SHA2(\"{data.Password}\", 512), '{data.Role}', now());";
            var connection = DbConnector.Instance.createConnection();
            await connection.OpenAsync();
            var task = DbFactory.runNonQueryCommand(query,connection);
            return task.Result;
        }
    }
}
