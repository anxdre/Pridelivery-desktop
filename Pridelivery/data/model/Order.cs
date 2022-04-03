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
        string receipentName;
        string receipentPhone;
        int weight;
        int category;
        string fragile;
        string itemDesc;
        int pickProvince;
        int pickDistrict;
        int pickCity;
        string pickDetailAddress;
        string shipProvince;
        string shipDistrict;
        string shipCity;
        string shipDetailAddress;
        string deliveryType;
        string status;
        int totalPrice;
        DateTime createdAt;

        public Order(int id, int userId, string receipentName, string receipentPhone, int weight, int category, string fragile, string itemDesc, int pickProvince, int pickDistrict, int pickCity, string pickDetailAddress, string shipProvince, string shipDistrict, string shipCity, string shipDetailAddress, string deliveryType, string status, int totalPrice, DateTime createdAt)
        {
            this.Id = id;
            this.UserId = userId;
            this.ReceipentName = receipentName;
            this.ReceipentPhone = receipentPhone;
            this.Weight = weight;
            this.Category = category;
            this.Fragile = fragile;
            this.ItemDesc = itemDesc;
            this.PickProvince = pickProvince;
            this.PickDistrict = pickDistrict;
            this.PickCity = pickCity;
            this.PickDetailAddress = pickDetailAddress;
            this.ShipProvince = shipProvince;
            this.ShipDistrict = shipDistrict;
            this.ShipCity = shipCity;
            this.ShipDetailAddress = shipDetailAddress;
            this.DeliveryType = deliveryType;
            this.Status = status;
            this.TotalPrice = totalPrice;
            this.CreatedAt = createdAt;
        }

        public int Id { get => id; set => id = value; }
        public int UserId { get => userId; set => userId = value; }
        public string ReceipentName { get => receipentName; set => receipentName = value; }
        public string ReceipentPhone { get => receipentPhone; set => receipentPhone = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Category { get => category; set => category = value; }
        public string Fragile { get => fragile; set => fragile = value; }
        public string ItemDesc { get => itemDesc; set => itemDesc = value; }
        public int PickProvince { get => pickProvince; set => pickProvince = value; }
        public int PickDistrict { get => pickDistrict; set => pickDistrict = value; }
        public int PickCity { get => pickCity; set => pickCity = value; }
        public string PickDetailAddress { get => pickDetailAddress; set => pickDetailAddress = value; }
        public string ShipProvince { get => shipProvince; set => shipProvince = value; }
        public string ShipDistrict { get => shipDistrict; set => shipDistrict = value; }
        public string ShipCity { get => shipCity; set => shipCity = value; }
        public string ShipDetailAddress { get => shipDetailAddress; set => shipDetailAddress = value; }
        public string DeliveryType { get => deliveryType; set => deliveryType = value; }
        public string Status { get => status; set => status = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
    }
}
