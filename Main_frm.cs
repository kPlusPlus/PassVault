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
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
            lblUser.Text = Globals.username;
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var myForm2 = new Add_Edit_frm();
            myForm2.Show();
            var mainfrm = new Main_frm();
            mainfrm.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var myForm3 = new Search_frm();
            myForm3.Show();
            var mainfrm = new Main_frm();
            mainfrm.Hide();
        }
    }
}
