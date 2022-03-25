using System;
using System.Windows;
using MetroFramework.Forms;
using Pridelivery.Repository;
using Pridelivery.View.Register;

namespace Pridelivery
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (DbConnector.Instance.openConnectionAsync() != null)
                {
                    MessageBox.Show("Database Connection Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroButtonRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
