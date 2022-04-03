using System;
using System.Windows;
using MetroFramework.Forms;
using Pridelivery.Repository.Model;
using Pridelivery.view.mainmenu;

namespace Pridelivery.view.profile
{
    public partial class ProfileDetail : MetroForm
    {
        UserProfile profile;
        ProfilePresenter profilePresenter;
        MainMenu mainMenuContext;

        public ProfileDetail(MainMenu parentContext, UserProfile userData)
        {
            InitializeComponent();
            profile = userData;
            mainMenuContext = parentContext;
            profilePresenter = new ProfilePresenter();
        }

        private void ProfileDetail_Load(object sender, EventArgs e)
        {
            metroTextBoxEmail.Text = profile.Email;
            metroTextBoxName.Text = profile.Name;
            metroTextBoxPhone.Text = profile.Phone;
            metroComboBoxRole.SelectedIndex = profile.Role;
        }

        private void metroToggleEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggleEdit.Checked)
            {
                metroTextBoxEmail.Enabled = true;
                metroTextBoxName.Enabled = true;
                metroTextBoxPhone.Enabled = true;
                metroButtonSave.Visible = true;
            }
            else
            {
                metroTextBoxEmail.Enabled = false;
                metroTextBoxName.Enabled = false;
                metroTextBoxPhone.Enabled = false;
                metroButtonSave.Visible = false;
            }
        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void metroButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                profile.Email = metroTextBoxEmail.Text;
                profile.Phone = metroTextBoxPhone.Text;
                profile.Name = metroTextBoxName.Text;
                var status = await profilePresenter.saveProfile(profile);
                if (status)
                {
                    MessageBox.Show("Update success");
                    mainMenuContext.profile = profile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
