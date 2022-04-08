using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Pridelivery.data.database.user;
using Pridelivery.data.model;
using Pridelivery.Repository;
using Pridelivery.Repository.Database.User;

namespace Pridelivery.view.sendpacket
{
    internal class SendPacketPresenter
    {
        MySqlConnection connection = DbConnector.Instance.createConnection();

        public async Task<bool> postOrder(Order order)
        {

            try
            {
                await connection.OpenAsync();
                var task = await OrderRepository.addOrder(order, connection);
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
