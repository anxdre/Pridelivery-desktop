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

namespace Pridelivery.view.history
{
    public partial class OrderHistory : MetroForm
    {
        UserProfile profile;
        OrderHistroyPresenter presenter;
        public OrderHistory(UserProfile user)
        {
            InitializeComponent();
            profile = user;
            presenter = new OrderHistroyPresenter();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            
        }
    }
}
