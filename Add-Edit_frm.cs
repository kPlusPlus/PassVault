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
    public partial class Add_Edit_frm : Form
    {
        public Add_Edit_frm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Add_Edit_Clients_frm();
            myForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Add_Edit_PassVault_Records_frm();
            myForm.ShowDialog();
        }

        private void LIcense_Types_botun_Click(object sender, EventArgs e)
        {
            var myForm = new Add_Edit_License_Types_frm();
            myForm.ShowDialog();
        }

        private void Certificates_botun_Click(object sender, EventArgs e)
        {
            var myForm = new Add_Edit_Certificates_frm();
            myForm.ShowDialog();
        }
    }
}
