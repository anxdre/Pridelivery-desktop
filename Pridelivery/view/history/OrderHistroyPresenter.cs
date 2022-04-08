using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Pridelivery.data.database.user;
using Pridelivery.data.model;
using Pridelivery.Repository;
using Pridelivery.Repository.Model;

namespace Pridelivery.view.history
{
    internal class OrderHistroyPresenter
    {
        MySqlConnection connection = DbConnector.Instance.createConnection();
        public async Task<List<Order>> getAllHistory(UserProfile user)
        {
            try
            {
                await connection.OpenAsync();
                var reader = await OrderRepository.getListOrder(connection,user.Id);
                List<object> result = new List<object>();
                List<Order> listOfOrder = new List<Order>();

                while (await reader.ReadAsync())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        result.Add(await reader.GetFieldValueAsync<object>(i));
                        Console.WriteLine(result[i]);
                    }
                }
                listOfOrder.Add(new Order((int)result[0], (int)result[1], (string)result[2], (string)result[3], (string)result[4], (string)result[5],(int)result[6]));
                return listOfOrder;
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
