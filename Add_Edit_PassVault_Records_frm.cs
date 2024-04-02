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

namespace PassVault
{
    public partial class Add_Edit_PassVault_Records_frm : Form
    {
        private Common common = new Common();
        public Add_Edit_PassVault_Records_frm()
        {
            InitializeComponent();

            FillCombo();
            FillDataGridView();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDataGridView()
        {
            string Query = "SELECT * FROM dbo.PassVault_tbl;";
            common.ds = common.GetDataSet(Query);

            bindingSource1.DataSource = common.ds;
            bindingSource1.DataMember = common.ds.Tables[0].TableName;
            dgvPass.DataSource = bindingSource1;

            OdbcCommandBuilder updateCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.UpdateCommand = updateCommand.GetUpdateCommand();
            OdbcCommandBuilder insertCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.InsertCommand = insertCommand.GetInsertCommand();
            OdbcCommandBuilder deleteCommand = new OdbcCommandBuilder(common.adapter);
            common.adapter.DeleteCommand = deleteCommand.GetDeleteCommand();

            textBox1.DataBindings.Add("Text", bindingSource1, "ID");
            textBox2.DataBindings.Add("Text", bindingSource1, "ClientID");
            //textBox2.DataBindings.Add("Text", comboBox1.DataSource, "ClientID");
            textBox14.DataBindings.Add("Text", bindingSource1, "AL");
            textBox6.DataBindings.Add("Text", bindingSource1, "Description");
            textBox10.DataBindings.Add("Text", bindingSource1, "Username");
            textBox11.DataBindings.Add("Text", bindingSource1, "Password");
            textBox12.DataBindings.Add("Text", bindingSource1, "Comment");

        }

        private void FillCombo()
        {
            DataSet dataSet = new DataSet();
            string Query = "SELECT * FROM dbo.Clients_tbl ORDER BY Name;";
            dataSet = common.GetDataSet(Query);
            DataTable dt = dataSet.Tables[0];

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ClientID";
            comboBox1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                common.adapter.Update(common.ds, common.ds.Tables[0].TableName);
                MessageBox.Show("Data saved successfully. ");
                dgvPass.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvPass.ClearSelection();
            if (dgvPass.Rows.Count > 0)
            {
                int lastIndex = dgvPass.Rows.Count - 1;
                dgvPass.Rows[lastIndex].Selected = true;
                dgvPass.CurrentCell = dgvPass.Rows[lastIndex].Cells[0];
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dgvPass.ClearSelection();
            if (dgvPass.Rows.Count > 0)
            {
                dgvPass.Rows[0].Selected = true;
                dgvPass.CurrentCell = dgvPass.Rows[0].Cells[0];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dgvPass.CurrentRow != null)
            {
                int currentIndex = dgvPass.CurrentRow.Index;
                int previousIndex = currentIndex - 1;

                if (previousIndex >= 0)
                {
                    dgvPass.ClearSelection();
                    dgvPass.Rows[previousIndex].Selected = true;
                    dgvPass.CurrentCell = dgvPass.Rows[previousIndex].Cells[0];
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dgvPass.CurrentRow.Index;
            int nextIndex = currentRowIndex + 1;

            if (nextIndex < dgvPass.Rows.Count)
            {
                dgvPass.ClearSelection();
                dgvPass.Rows[nextIndex].Selected = true;
                dgvPass.CurrentCell = dgvPass.Rows[nextIndex].Cells[0];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvPass.ClearSelection();
            if (dgvPass.Rows.Count > 0)
            {
                int lastIndex = dgvPass.Rows.Count - 2;
                dgvPass.Rows[lastIndex].Selected = true;
                dgvPass.CurrentCell = dgvPass.Rows[lastIndex].Cells[0];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                textBox2.Text = comboBox1.SelectedValue.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.CancelEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                comboBox1.SelectedValue = textBox2.Text;
            }

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
