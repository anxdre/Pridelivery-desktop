using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Pridelivery.data.model;
using Pridelivery.Repository.Model;
using Pridelivery.utility;

namespace Pridelivery.view.sendpacket
{
    public partial class SendPacket : MetroForm
    {
        UserProfile profile;
        SendPacketPresenter presenter;
        public SendPacket(UserProfile userData)
        {
            profile = userData;
            InitializeComponent();
            presenter = new SendPacketPresenter();
        }

        private void SendPacket_Load(object sender, EventArgs e)
        {
            metroTextBoxSendName.Text = profile.Name;
            metroTextBoxSendPhone.Text = profile.Phone;
        }

        private async void metroButtonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetail = new OrderDetail(0, (int)numericUpDownWeight.Value, comboBoxItemType.SelectedIndex, comboBoxFragile.Text, metroTextBoxPicAddress.Text, metroComboBoxPickProvince.SelectedIndex, metroComboBoxPickDistrict.SelectedIndex, metroComboBoxPickCity.SelectedIndex, metroTextBoxPicAddress.Text,
                    metroComboBoxShipProvince.SelectedIndex, metroComboBoxShipDistrict.SelectedIndex, metroComboBoxShipCity.SelectedIndex, metroTextBoxShipDetail.Text);
                var order = new Order(0, profile.Id, metroTextBoxRecName.Text, metroTextBoxRecPhone.Text, metroComboBoxDeliveryType.Text, "On Progress", int.Parse(metroTextBoxTotalPrice.Text), orderDetail);

                var status = await presenter.postOrder(order);
                startProgressBar(10);
                if (status)
                {
                    MessageBox.Show("Order Success, courier will pick your packet in 12h");
                    var key = PdfExport.RandomString(256);
                    PdfExport.exportToPdf(order,profile,key);
                    metroProgressBar1.Value = 0;
                    var keyForm = new KeyWarn(key).ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Order Failed Please Try Again");
                }
            }
            catch (Exception ex)
            {
                metroProgressBar1.Value = 0;
                MessageBox.Show(ex.Message);
            }
        }

        private void startProgressBar(int delayMils)
        {
            for (int i = 0; i <= 100; i++)
            {
                metroProgressBar1.Value = i;
                Task.Delay(delayMils).Wait();
            }
        }

        private void metroComboBoxDeliveryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBoxDeliveryType.SelectedIndex == 0)
            {
                metroTextBoxEstDelivery.Text = "3 days";
                metroTextBoxTotalPrice.Text = (2500 * (int)numericUpDownWeight.Value).ToString();
            }
            else
            {
                metroTextBoxEstDelivery.Text = "1 days";
                metroTextBoxTotalPrice.Text = (5500 * (int)numericUpDownWeight.Value).ToString();
            }
        }
    }
}
