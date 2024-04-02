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
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Add_Edit_PassVault_Records_frm();
            myForm.Show();
        }

        private void LIcense_Types_botun_Click(object sender, EventArgs e)
        {
            var myForm = new Add_Edit_License_Types_frm();
            myForm.Show();
        }

        private void Certificates_botun_Click(object sender, EventArgs e)
        {
            var myForm = new Add_Edit_Certificates_frm();
            myForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Search_frm search = new Search_frm();
            search.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {           
            Add_Edit_License add_Edit_License = new Add_Edit_License();
            add_Edit_License.Show();
        }
    }
}
