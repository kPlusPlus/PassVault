using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassVault
{
    public partial class Add_Edit_Clients_frm : Form
    {
        private Common common = new Common();
        public Add_Edit_Clients_frm()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Search_Clients search_Clients = new Search_Clients();
            if(search_Clients.ShowDialog() == DialogResult.OK)
            {
                int returnValue = search_Clients.ReturnValue;
                SelectRowByValue("ID", returnValue.ToString());
            }            
        }

        private void FillDataGridView()
        {
            string Query = "SELECT * FROM dbo.Clients_tbl;";
            common.ds = common.GetDataSet(Query);

            bindingSource1.DataSource = common.ds;
            bindingSource1.DataMember = common.ds.Tables[0].TableName;
            dgvClients.DataSource = bindingSource1;

            OdbcCommandBuilder updateCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.UpdateCommand = updateCommand.GetUpdateCommand();
            OdbcCommandBuilder insertCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.InsertCommand = insertCommand.GetInsertCommand();
            OdbcCommandBuilder deleteCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.DeleteCommand = deleteCommand.GetDeleteCommand();

            ID_txt.DataBindings.Add("Text", bindingSource1, "ID");
            Client_ID_txt.DataBindings.Add("Text", bindingSource1, "ClientID");
            Client_Name_txt.DataBindings.Add("Text", bindingSource1, "Name");
            OIB_txt.DataBindings.Add("Text", bindingSource1, "OIB");
            City_txt.DataBindings.Add("Text", bindingSource1, "Address_City");
            PO_txt.DataBindings.Add("Text", bindingSource1, "PO");
            Street_txt.DataBindings.Add("Text", bindingSource1, "Address_Street");
            StreetNo_txt.DataBindings.Add("Text", bindingSource1, "Address_Street_number");
            Ext_txt.DataBindings.Add("Text", bindingSource1, "Address_ext");
            Contact_txt.DataBindings.Add("Text", bindingSource1, "Contact");
            Email_txt.DataBindings.Add("Text", bindingSource1, "Email");
            Tel_txt.DataBindings.Add("Text", bindingSource1, "Tel");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                common.adapter.Update(common.ds, common.ds.Tables[0].TableName);
                MessageBox.Show("Data saved successfully. ");
                dgvClients.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dgvClients.ClearSelection();
            if (dgvClients.Rows.Count > 0)
            {
                dgvClients.Rows[0].Selected = true;
                dgvClients.CurrentCell = dgvClients.Rows[0].Cells[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvClients.ClearSelection();
            if (dgvClients.Rows.Count > 0)
            {
                int lastIndex = dgvClients.Rows.Count - 2;
                dgvClients.Rows[lastIndex].Selected = true;
                dgvClients.CurrentCell = dgvClients.Rows[lastIndex].Cells[0];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvClients.CurrentRow.Index;
            int nextIndex = currentRowIndex + 1;

            if (nextIndex < dgvClients.Rows.Count)
            {
                dgvClients.ClearSelection();
                dgvClients.Rows[nextIndex].Selected = true;
                dgvClients.CurrentCell = dgvClients.Rows[nextIndex].Cells[0];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow != null)
            {
                int currentIndex = dgvClients.CurrentRow.Index;
                int previousIndex = currentIndex - 1;

                if (previousIndex >= 0)
                {
                    dgvClients.ClearSelection();
                    dgvClients.Rows[previousIndex].Selected = true;
                    dgvClients.CurrentCell = dgvClients.Rows[previousIndex].Cells[0];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvClients.ClearSelection();
            if (dgvClients.Rows.Count > 0)
            {
                int lastIndex = dgvClients.Rows.Count - 1;
                dgvClients.Rows[lastIndex].Selected = true;
                dgvClients.CurrentCell = dgvClients.Rows[lastIndex].Cells[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.CancelEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SelectRowByValue(string columnName, string value)
        {
            foreach (DataGridViewRow row in dgvClients.Rows)
            {
                if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString() == value)
                {
                    dgvClients.ClearSelection();
                    row.Selected = true;
                    dgvClients.FirstDisplayedScrollingRowIndex = row.Index;
                    row.Cells[0].Selected = true;
                    break;
                }
            }
        }

        
    }
}
