using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Pridelivery.Repository;
using Pridelivery.Repository.Database.User;
using Pridelivery.Repository.Model;

namespace Pridelivery.View.Register
{
    internal class RegisterPresenter
    {
        MySqlConnection connection = DbConnector.Instance.createConnection();
        public async Task<bool> getRegisteredAsync(UserProfile user)
        {
            
            try
            {
                await connection.OpenAsync();
                var task = await UserRepository.registerUser(user, connection);
                return task;
            }catch (Exception ex)
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
