using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf;
using Pridelivery.data.model;
using Pridelivery.Repository.Model;

namespace Pridelivery.utility
{
    public static class PdfExport
    {
        public static void exportToPdf(Order data, UserProfile profile, string key)
        {
            
            Document document = new Document();
            Page page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Invoice Detail"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("---------------------------------------------"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Order Id : {data.Id}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Sender Name : {profile.Name}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Courier Name : {data.CourierId}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Receipent Name : {data.ReceipentName}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Receipent Phone : {data.ReceipentPhone}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Delivery Type : {data.DeliveryType}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Status : {data.Status}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"total Price : {data.TotalPrice}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($""));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"--------------------------------------------"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Weight : {data.Detail.Weight}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Desc : {data.Detail.ItemDesc}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Fragile : {data.Detail.Fragile}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Picked Up Province : {data.Detail.PickProvince}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Picked Up District : {data.Detail.PickDistrict}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Picked Up City : {data.Detail.PickCity}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Picked Up Address : {data.Detail.PickDetailAddress}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Shipment Province : {data.Detail.ShipProvince}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Shipment District : {data.Detail.ShipDistrict}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Shipment City : {data.Detail.ShipCity}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Item Shipment Address : {data.Detail.ShipDetailAddress}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($""));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"---------------------------------------------"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Thank You For Using Our Services"));
            document.Encrypt(profile.Password,key, Aspose.Pdf.Facades.DocumentPrivilege.ForbidAll, CryptoAlgorithm.AESx128, true);
            document.Save($"Order_{data.CreatedAt.ToLongDateString()}.pdf");
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
