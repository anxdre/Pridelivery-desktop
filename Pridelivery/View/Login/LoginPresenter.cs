using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Pridelivery.Repository;
using Pridelivery.Repository.Database.User;
using Pridelivery.Repository.Model;

namespace Pridelivery.View.Login
{
    internal class LoginPresenter
    {
        MySqlConnection connection = DbConnector.Instance.createConnection();
        public async Task<UserProfile> getAuthenticationAsync(string email, string password)
        {
            try
            {
                await connection.OpenAsync();
                var reader = await UserRepository.getAuthentication(email, password, connection);
                List<object> result = new List<object>();

                while (await reader.ReadAsync())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        result.Add(await reader.GetFieldValueAsync<object>(i));
                        Console.WriteLine(result[i]);
                    }
                }
                return new UserProfile((int)result[0], (string)result[1], (string)result[2], (string)result[3], (string)result[4], (int)result[5]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                await connection.CloseAsync();
            }
        }
    }
}
