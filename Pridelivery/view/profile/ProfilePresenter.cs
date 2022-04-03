using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Pridelivery.Repository;
using Pridelivery.Repository.Database.User;
using Pridelivery.Repository.Model;

namespace Pridelivery.view.profile
{
    internal class ProfilePresenter
    {
        MySqlConnection connection = DbConnector.Instance.createConnection();

        public async Task<bool> saveProfile(UserProfile userProfile)
        {
            try
            {
                await connection.OpenAsync();
                var task = await UserRepository.updateUser(userProfile, connection);
                return task;
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
