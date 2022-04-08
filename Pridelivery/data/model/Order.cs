using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pridelivery.data.model
{
    public class Order
    {
        int id;
        int userId;
        int courierId;
        string receipentName;
        string receipentPhone;
        string deliveryType;
        string status;
        double totalPrice;
        DateTime createdAt;
        OrderDetail detail;

        public Order(int id, int userId, int courierId, string receipentName, string receipentPhone, string deliveryType, string status, int totalPrice, OrderDetail detail = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.CourierId = courierId;
            this.ReceipentName = receipentName;
            this.ReceipentPhone = receipentPhone;
            this.DeliveryType = deliveryType;
            this.Status = status;
            this.TotalPrice = totalPrice;
            this.Detail = detail;
        }

        public Order(int id, int userId, string receipentName, string receipentPhone, string deliveryType, string status, int totalPrice, OrderDetail detail = null)
        {
            this.Id = id;
            this.UserId = userId;
            this.ReceipentName = receipentName;
            this.ReceipentPhone = receipentPhone;
            this.DeliveryType = deliveryType;
            this.Status = status;
            this.TotalPrice = totalPrice;
            this.Detail = detail;
        }

        public int Id { get => id; set => id = value; }
        public int UserId { get => userId; set => userId = value; }
        public int CourierId { get => courierId; set => courierId = value; }
        public string ReceipentName { get => receipentName; set => receipentName = value; }
        public string ReceipentPhone { get => receipentPhone; set => receipentPhone = value; }
        public string DeliveryType { get => deliveryType; set => deliveryType = value; }
        public string Status { get => status; set => status = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public OrderDetail Detail { get => detail; set => detail = value; }
    }
}
