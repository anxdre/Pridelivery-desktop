using System;
using System.Threading.Tasks;
using System.Windows;
using MetroFramework.Forms;
using Pridelivery.Repository;
using Pridelivery.View.Login;
using Pridelivery.View.Register;

namespace Pridelivery
{
    public partial class LoginForm : MetroForm
    {
        LoginPresenter loginPresenter;
        
        public LoginForm()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    var connection = DbConnector.Instance.createConnection();
            //    if (connection != null)
            //    {
            //        MessageBox.Show("Database Connection Success");
            //        connection.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void metroButtonRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private async void metroButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var status = await Task.Factory.StartNew(() => loginPresenter.getAuthentication(metroTextBoxEmail.Text, metroTextBoxPassword.Text));
                if (status != null)
                {
                    Console.WriteLine(status.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
