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

namespace Pridelivery.view.mainmenu
{
    public partial class MainMenu : MetroForm
    {
        UserProfile profile;
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

       
    }
}
