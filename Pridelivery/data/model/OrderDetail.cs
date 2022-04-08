using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pridelivery.data.model
{
    public class OrderDetail
    {
        int orderId;
        int weight;
        int category;
        string fragile;
        string itemDesc;
        int pickProvince;
        int pickDistrict;
        int pickCity;
        string pickDetailAddress;
        int shipProvince;
        int shipDistrict;
        int shipCity;
        string shipDetailAddress;

        public OrderDetail(int orderId, int weight, int category, string fragile, string itemDesc, int pickProvince, int pickDistrict, int pickCity, string pickDetailAddress, int shipProvince, int shipDistrict, int shipCity, string shipDetailAddress)
        {
            this.orderId = orderId;
            this.weight = weight;
            this.category = category;
            this.fragile = fragile;
            this.itemDesc = itemDesc;
            this.pickProvince = pickProvince;
            this.pickDistrict = pickDistrict;
            this.pickCity = pickCity;
            this.pickDetailAddress = pickDetailAddress;
            this.shipProvince = shipProvince;
            this.shipDistrict = shipDistrict;
            this.shipCity = shipCity;
            this.shipDetailAddress = shipDetailAddress;
        }

        public int OrderId { get => orderId; set => orderId = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Category { get => category; set => category = value; }
        public string Fragile { get => fragile; set => fragile = value; }
        public string ItemDesc { get => itemDesc; set => itemDesc = value; }
        public int PickProvince { get => pickProvince; set => pickProvince = value; }
        public int PickDistrict { get => pickDistrict; set => pickDistrict = value; }
        public int PickCity { get => pickCity; set => pickCity = value; }
        public string PickDetailAddress { get => pickDetailAddress; set => pickDetailAddress = value; }
        public int ShipProvince { get => shipProvince; set => shipProvince = value; }
        public int ShipDistrict { get => shipDistrict; set => shipDistrict = value; }
        public int ShipCity { get => shipCity; set => shipCity = value; }
        public string ShipDetailAddress { get => shipDetailAddress; set => shipDetailAddress = value;}
    }
}
