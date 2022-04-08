using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Pridelivery.data.model;
using Pridelivery.Repository.Database;

namespace Pridelivery.data.database.user
{
    internal class OrderRepository
    {
        public static async Task<MySqlDataReader> getListOrder(MySqlConnection connection)
        {
            var query = $"select * from orders";
            try
            {
                return await DbFactory.runQueryCommand(query, connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public static async Task<MySqlDataReader> getListOrder(MySqlConnection connection,int userId)
        {
            var query = $"select * from orders where userId = {userId}";
            try
            {
                return await DbFactory.runQueryCommand(query, connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<MySqlDataReader> getCurentOrder(MySqlConnection connection)
        {
            var query = $"select * from orders limit 1";
            try
            {
                return await DbFactory.runQueryCommand(query, connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public static async Task<MySqlDataReader> getOrderDetail(int id, MySqlConnection connection)
        {
            var query = $"select * from order_details where orderId = {id}";
            try
            {
                return await DbFactory.runQueryCommand(query, connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<MySqlDataReader> getListOrderSortByDelivered(MySqlConnection connection)
        {
            var query = $"select * from orders order by status ASC";
            try
            {
                return await DbFactory.runQueryCommand(query, connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<MySqlDataReader> getListOrderSortByOnProgress(MySqlConnection connection)
        {
            var query = $"select * from orders order by timestamp DESC";
            try
            {
                return await DbFactory.runQueryCommand(query, connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<bool> addOrder(Order data, MySqlConnection connection)
        {
            List<String> listOfQuery = new List<String>();
            listOfQuery.Add($"insert into orders values( null ,'{data.UserId}','{data.CourierId}','{data.ReceipentName}','{data.ReceipentPhone}'," +
                        $"'{data.DeliveryType}','{data.Status}','{data.TotalPrice}',now());");

            listOfQuery.Add($"call add_order_detail ('{data.Detail.Weight}','{data.Detail.ItemDesc}','{data.Detail.Fragile}','{data.Detail.PickProvince}','{data.Detail.PickDistrict}','{data.Detail.PickCity}','{data.Detail.PickDetailAddress}','{data.Detail.ShipProvince}','{data.Detail.ShipDistrict}','{data.Detail.ShipCity}','{data.Detail.ShipDetailAddress}')");

            return await DbFactory.runNonQueryCommand(listOfQuery, connection);
        }
        public static async Task<bool> updateOrder(Order data, MySqlConnection connection)
        {
            var query = $"update orders SET courierId = '{data.CourierId}', receipent = '{data.ReceipentName}', receipent_phone = '{data.ReceipentPhone}'," +
                        $" delivery_type = '{data.DeliveryType}', status = '{data.Status}', total_price = '{data.TotalPrice}');";
            return await DbFactory.runNonQueryCommand(query, connection);
        }
    }
}
