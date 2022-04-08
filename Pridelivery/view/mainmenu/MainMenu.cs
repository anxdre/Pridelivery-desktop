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
using Pridelivery.utility;
using Pridelivery.view.profile;
using Pridelivery.view.sendpacket;

namespace Pridelivery.view.mainmenu
{
    public partial class MainMenu : MetroForm
    {
        public UserProfile profile;
        public MainMenu(UserProfile userData)
        {
            InitializeComponent();
            profile = userData;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            metroLabelName.Text = $"Hello : {profile.Name}";
            if(profile.Role == 0)
            {
                metroTabControl.SelectedIndex = 0;
                metroTabControl.TabPages.Remove(metroTabPageUser);
                metroTabControl.TabPages.Remove(metroTabPageAdmin);
            }else if(profile.Role == 1)
            {
                metroTabControl.SelectedIndex = 1;
                metroTabControl.TabPages.Remove(metroTabPageCourier);
                metroTabControl.TabPages.Remove(metroTabPageAdmin);
            }
            else
            {
                metroTabControl.SelectedIndex = 2;
                metroTabControl.TabPages.Remove(metroTabPageCourier);
                metroTabControl.TabPages.Remove(metroTabPageUser);
            }
        }

        private void metroTileProfileCourier_Click(object sender, EventArgs e)
        {
            var form = new ProfileDetail(this, profile);
            form.ShowDialog();
            this.MainMenu_Load(sender, e);
        }

        private void metroTileProfileUser_Click(object sender, EventArgs e)
        {
            var form = new ProfileDetail(this, profile);
            form.ShowDialog();
            this.MainMenu_Load(sender, e);

        }

        private void metroTabPageUser_Click(object sender, EventArgs e)
        {

        }

        private void metroTileSendPacket_Click(object sender, EventArgs e)
        {
            var form = new SendPacket(profile);
            form.ShowDialog();
        }

        private void metroTileExitUser_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTileHistoryUser_Click(object sender, EventArgs e)
        {

        }
    }
}
