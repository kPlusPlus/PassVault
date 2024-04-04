using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassVault
{
    public partial class Search_frm : Form
    {
        public Search_frm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_Clients sc = new Search_Clients();
            sc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_PassVault sc = new Search_PassVault();
            sc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Search_License sc = new Search_License();
            sc.Show();
        }
    }
}
