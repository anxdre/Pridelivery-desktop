using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using MetroFramework.Forms;
using Pridelivery.Repository;
using Pridelivery.Repository.Database.User;
using Pridelivery.Repository.Model;

namespace Pridelivery.View.Register
{
    public partial class RegisterForm : MetroForm
    {
        RegisterPresenter presenter;
        public RegisterForm()
        {
            InitializeComponent();
            presenter = new RegisterPresenter();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private async void metroButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //tenary operator
                int role = metroRadioButtonUser.Checked ? 1 : 0;
                UserProfile user = new UserProfile(0, metroTextBoxName.Text, metroTextBoxEmail.Text, metroTextBoxPhone.Text, role, metroTextBoxPassword.Text);
                checkPassword(user);
                var status = await Task.Factory.StartNew(() => presenter.getRegistered(user));
                if (status)
                {

                    MessageBox.Show("Register Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Register Failed Please Try Again");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkPassword(UserProfile user)
        {
            if(user.Password != metroTextBoxRePassword.Text)
            {
                throw new ArgumentException("Password is not same, check your password again");
            }
            return true;
        }
    }
}
