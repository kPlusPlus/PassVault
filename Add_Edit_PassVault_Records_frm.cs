﻿using System;
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
            FillDataGridView();
            FillCombo();
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

            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "ClientID";
            comboBox1.DataSource = dataSet;

            /*
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["Name"]);
            }
            */
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
    }
}
