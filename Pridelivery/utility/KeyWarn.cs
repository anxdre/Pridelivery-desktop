using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pridelivery.utility
{
    public partial class KeyWarn : Form
    {
        string keyPharase;
        public KeyWarn(string key)
        {
            InitializeComponent();
            keyPharase = key;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyWarn_Load(object sender, EventArgs e)
        {
            metroTextBox1.Text = keyPharase;
        }
    }
}
