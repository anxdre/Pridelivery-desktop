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
using Pridelivery.Repository.Model;

namespace Pridelivery.view.sendpacket
{
    public partial class SendPacket : MetroForm
    {
        UserProfile profile;
        public SendPacket(UserProfile userData)
        {
            profile = userData;
            InitializeComponent();
        }

        private void SendPacket_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
